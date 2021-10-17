JS.toast = {
    prompt: {
        info(description = null, title = null, settings = {}) {
            JS.toast.settings();
            toastr.info(description, title, settings);
        },
        warning(description, title, settings) {
            JS.toast.settings();
            toastr.warning(description, title, settings);
        },
        success(description, title, settings) {
            JS.toast.settings();
            toastr.success(description, title, settings);
        },
        error(description, title, settings) {
            JS.toast.settings();
            toastr.error(description, title, settings);
        }
        // Sample - Override global options
        // toastr.success('We do have the Kapua suite available.', 'Turtle Bay Resort', { timeOut: 5000 })
    },
    action: {
        remove() {
            // Immediately remove current toasts without using animation
            toastr.remove();
        },
        clear() {
            // Remove current toasts using animation
            toastr.clear();
        }
    },
    settings() {
        toastr.options.showMethod = 'slideDown';
        toastr.options.preventDuplicates = true;
        toastr.options.timeOut = 5000; // How long the toast will display without user interaction
        toastr.options.extendedTimeOut = 5000; // How long the toast will display after a user hovers over it
        toastr.options.progressBar = true;
        //toastr.options.positionClass = "toast-top-full-width";
    }
}