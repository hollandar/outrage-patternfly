var PatternflySearch = PatternflySearch || {};

PatternflySearch.scrollIntoView = function (elementId) {
    var element = document.getElementById(elementId);
    element.scrollIntoView({ behaviour: "smooth", block: "nearest", inline: "center" });
}

export { PatternflySearch };