JS = {};

JS.pageloader = {
    showLoader() {
        if ($(".preloader").is(":hidden")) {
            $(".preloader").fadeIn();
        }
    },
    hideLoader() {
        if ($(".preloader").is(":visible")) {
            $(".preloader").fadeOut();
        }
    }
};

JS.parseJson = function (string) {
    try {
        if (JSON.parse(string)) {
            return jQuery.parseJSON(string);
        }
        else {
            return string;
        }
    } catch (e) {
        return string;
    }
};