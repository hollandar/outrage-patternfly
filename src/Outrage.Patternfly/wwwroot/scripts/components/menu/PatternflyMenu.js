var PatternflyMenu = PatternflyMenu || {};

PatternflyMenu.resizeMenuContent = function (element) {
    console.log(element.classList.toString());

    if (!element.parentElement.classList.contains("pf-m-drilldown"))
        return;


    // No current path, at the top so reset
    let currentPaths = element.querySelectorAll(".pf-m-current-path");
    if (currentPaths.length == 0) {
        element.setAttribute("style", "");
        return;
    }

    // Discover top level menu list padding
    let menuList = element.querySelector(".pf-v5-c-menu__list");
    let computedStyle = window.getComputedStyle(menuList, null);
    let paddingTop = parseInt(computedStyle.getPropertyValue("padding-top"), 10);
    let paddingBottom = parseInt(computedStyle.getPropertyValue("padding-bottom"), 10);
    let heightExtension = paddingTop + paddingBottom;

    // Adjust the height based on current path
    var currentPath = currentPaths.item(currentPaths.length - 1);
    let menu = currentPath.querySelector(".pf-v5-c-menu");
    if (menu) {
        let height = menu.offsetHeight;
        element.setAttribute("style", "--pf-v5-c-menu__content--Height:" + (height + heightExtension) + "px;");
    }

}

export { PatternflyMenu };