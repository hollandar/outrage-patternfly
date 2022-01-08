class LabelledControl {
    static Apply(control: HTMLDivElement) {
        new LabelledControl(control);
    }

    constructor(element: HTMLDivElement) {
        this.ApplyControl(element);
    }

    ApplyControl(element: HTMLElement) {
        var self = this;
        var label = element.querySelector("label");
        var input = element.querySelector("input, textarea, select");
        if (input.matches("select")) {
            let newInput = document.createElement("div");
            newInput.classList.add("select-container");
            input.replaceWith(newInput);
            newInput.appendChild(input);
        }
        input.addEventListener("focus", (e) => { self.OnFocus(e); });
        input.addEventListener("blur", (e) => { self.OnBlur(e); });
        input.addEventListener("change", (e) => { self.OnChange(e); });
        this.ToggleFixed(element.querySelector(".edit-surface"), input);
    }

    OnFocus(event) {
        var placeholder = event.target.getAttribute("data-placeholder");
        if (placeholder)
            event.target.setAttribute("placeholder", placeholder);
        var labelledControl = event.target.parentElement;
        labelledControl.classList.add("focused");
    }

    OnBlur(event) {
        event.target.removeAttribute("placeholder");
        var labelledControl = event.target.parentElement;
        if (!labelledControl.classList.contains("focused-fixed"))
            labelledControl.classList.remove("focused");
    }

    OnChange(event) {
        var input = event.target;
        var control = event.target.parentElement;
        this.ToggleFixed(control, input);
    }

    ToggleFixed(control, input) {
        if (input.value) {
            control.classList.add("focused");
            control.classList.add("focused-fixed");
        } else {
            control.classList.remove("focused-fixed");
        }
    }
}