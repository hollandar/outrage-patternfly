
// Map holds references for all instances of the search control on the page, by search id
const map = new Map()

export function init(searchId, searchControl) {
    let searchElement = document.getElementById(searchId)

    searchElement.addEventListener("keypress", searchKeypress);

    map.set(searchId, { element: searchElement, control: searchControl })
}

function searchKeypress(event) {
    if (event.key === "Enter") {
        let searchId = event.target.id
        event.preventDefault()
        event.stopPropagation()

        let target = map.get(searchId);
        target.control.invokeMethod("SearchItems")
    }
}

export function getSearchText(searchId) {
    return map.get(searchId).element.value;
}

export function clearSearch(searchId) {
    map.get(searchId).element.value = ""
}

export function dispose(searchId) {
    map.delete(searchId);
}