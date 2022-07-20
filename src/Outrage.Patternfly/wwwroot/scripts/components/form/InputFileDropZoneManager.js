
class BrowserFile {
    constructor(name, size, contentType, lastModified, file) {
        this.name = name;
        this.contentType = contentType;
        this.lastModifiedMs = lastModified;
        this.file = file;
        this.size = size;
    }

    name;
    contentType;
    lastModifiedMs;
    file;
    size;
}

class InputFileDropZoneManager {
    dropZone = null;
    inputFile = null;
    dni = null;

    pendingFiles = 0;
    files = [];

    constructor(dropZone, dni) {
        this.dni = dni;
        this.dropZone = dropZone;

        this.dropZone.addEventListener("dragover", this.onDragOver);
        this.dropZone.addEventListener("drop", this.onDrop);

        this.inputFile = this.dropZone.querySelector("input[type=file]");
        if (this.inputFile != null) {
            this.inputFile.addEventListener("change", this.onChange);
        }
    }

    onDragOver = (event) => {
        event.preventDefault();
        event.dataTransfer.dropEffect = "copy";
    }

    onDrop = (event) => {
        event.preventDefault();
        if (event.dataTransfer.files)
            this.readFiles(event.dataTransfer.files);
    }

    onChange = (event) => {
        if (event.target.files)
            this.readFiles(event.target.files);
    }

    clear = () => {
        if (this.inputFile)
            this.inputFile.value = "";
    }

    browse = () => {
        if (this.inputFile != null)
            this.inputFile.click();
    }

    readFiles = (files) => {
        this.pendingFiles = 0;
        this.files = [];
        for (let i = 0; i < files.length; i++) {
            let file = files[i];
            this.readFile(file);
        }

        setTimeout(() => { this.finalize.apply(this); }, 100);
    }

    finalize = () => {
        if (this.files.length < this.pendingFiles) {
            setTimeout(() => { this.finalize.apply(this) }, 100);
        }

        this.dni.invokeMethodAsync("Complete", this.files);
    }

    readFile = (file) => {
        let size = file.size;
        let reader = new FileReader();
        reader.addEventListener("load", async (event) => {
            let byteBuffer = new Uint8Array(reader.result);
            const jsStreamReference = DotNet.createJSStreamReference(byteBuffer);
            this.files.push(new BrowserFile(file.name, file.size, file.type, file.lastModified, jsStreamReference));
        });

        reader.readAsArrayBuffer(file);
    }

    static attach(dropZone, dni) {
        let r = new InputFileDropZoneManager(dropZone, dni);
        return r;
    }

    static supported() {
        return ('draggable' in document.createElement('span'));
    }
}
export { InputFileDropZoneManager };