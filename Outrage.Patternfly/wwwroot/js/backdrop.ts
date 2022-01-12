class BackdropHelper {
    static apply() {
        let body = document.body;
        document.body.classList.add("pf-c-backdrop__open");
    }

    static unapply() {
        let body = document.body;
        document.body.classList.remove("pf-c-backdrop__open");
    }
}