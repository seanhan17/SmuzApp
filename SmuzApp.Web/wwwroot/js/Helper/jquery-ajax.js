JS.ajaxcall = {
    get(url, input, successCall, failureCall) {
        if (uiLoad === undefined) {
            uiLoad = true;
        }
        $('#divLoader').show();
        $.ajax({
            url: FXSCRIPT.URL.RelPath + url + "?time=" + new Date(),
            data: input,
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (JS.IsJsonFormat(response)) {
                    var tempJSON = jQuery.parseJSON(response);
                    response = tempJSON;
                }
                successCall(response);
                if (uiLoad) {
                    $('#divLoader').hide();
                }
            },
            fail: function () {
                failureCall();
                $('#divLoader').hide();
            },
            dataType: "html",
            get: "GET"
        });
    },
    post(url, request, successCall, failureCall) {
        try {
            JS.pageloader.showLoader();

            $.ajax({
                type: "POST",
                url: url,
                data: JSON.stringify(request),
                contentType: "application/json; charset=utf-8",
                cache: false,
                dataType: "html",
                success: function (response) {
                    response = JS.parseJson(response);

                    //if (typeof (response) == 'object') {
                    //    if (response.hasOwnProperty('RedirectUrl') && response.hasOwnProperty('ResultCode')) {
                    //        if (response.RedirectUrl && response.ResultCode != RESULTCODE.Failure) {
                    //            isRedirecting = true;
                    //            setTimeout(function () {
                    //                var currentPath = window.location.href;
                    //                var hostPath = currentPath.replace(window.location.pathname, "") + "/";
                    //                window.location.replace(hostPath + response.RedirectUrl);
                    //            }, 2000)
                    //        }
                    //    }
                    //}

                    //FXSCRIPT.appendMsgHtml(response, messageTimeout);
                    
                    //successCall(response);
                    //JS.pageloader.hideLoader();
                },
                fail: function () {
                    failureCall();
                    JS.pageloader.hideLoader();
                },
            });
        } catch (e) {
            JS.pageloader.hideLoader();
        }
    },
    submit(form, successCall, failureCall) {

        form.submit(function (evt) {
            evt.preventDefault();

            if ($(this).valid()) {
                JS.pageloader.showLoader();

                $.ajax({
                    cache: false,
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize()
                }).done(function (response) {
                    console.log(response, "before")
                    response = JS.parseJson(response);

                    var errorList = "";
                    var lastErrorIndex = response.errorMessage.length - 1;
                    response.errorMessage.forEach(function (item, index) {
                        var msg = lastErrorIndex != index ? item + ", " : item;
                        errorList = errorList.concat(msg);
                    })

                    response.errorMessage = errorList;

                    console.log(response, "after")

                    //if (typeof (response) == 'object') {
                    //    if (response.hasOwnProperty('RedirectUrl') && response.hasOwnProperty('ResultCode')) {
                    //        if (response.RedirectUrl && response.ResultCode != RESULTCODE.Failure) {
                    //            setTimeout(function () {
                    //                var currentPath = window.location.href;
                    //                var hostPath = currentPath.replace(window.location.pathname, "") + "/";
                    //                window.location.replace(hostPath + response.RedirectUrl);
                    //            }, 2000)
                    //        }
                    //    }
                    //}

                    //FXSCRIPT.appendMsgHtml(response);
                    successCall(response);

                    JS.pageloader.hideLoader();
                }).fail(function (jqXHR, textStatus, errorThrown) {
                    console.log(jqXHR, textStatus, errorThrown)
                    failureCall(response);
                    JS.pageloader.hideLoader();
                });
            }
        });
    }
};