class PatternflyElementClick {
    callbackObject: any;
    inputFile: HTMLInputElement;
    inputText: HTMLInputElement;

    constructor(callbackObject: any, inputFileId: string, inputTextId: string) {
        this.callbackObject = callbackObject;
        this.inputFile = document.getElementById(inputFileId) as HTMLInputElement;
        this.inputText = document.getElementById(inputTextId) as HTMLInputElement;
        this.inputFile.addEventListener("change", () => { this.handleFiles(); }, false);
    }

    clickElement() {
        if (this.inputFile != null)
            this.inputFile.click();
    }

    handleFiles() {
        const fileList = this.inputFile.files;
        let names = "";
        for (let i = 0; i < fileList.length; i++) {
            let file = fileList.item(i);
            names += file.name + " ";
        }
        this.inputText.value = names;
    }

    static attach(callbackObject: any, inputFileId:string, inputTextId: string): any {
        var handlerObject = new PatternflyElementClick(callbackObject, inputFileId, inputTextId);
        return handlerObject;
    }
}