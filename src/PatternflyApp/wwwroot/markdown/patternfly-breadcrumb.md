

# Patternfly Breadcrumb

link: [Patternfly Breadcrumb](https://www.patternfly.org/v4/components/breadcrumb)

namespace: Outrage.Patternfly.Components.Breadcrumb

## Example usage
```
<PatternflyBreadcrumb Length="5" />
```

## Attributes

* *IconDivider* : Icon to show between breadcrumb items. Default "angle-right".
* *IconClosed* : Icon to use when dropdown menu is closed. Default "caret-right".
* *IconOpen* : Icon to use when dropdown menu is open. Default "caret-down".
* *IconWeight* *IconLibrary* : See [Icon](/icon).
* *Length* : The count of breadcrumbs to show before the rest are placed into a dropdown. Default 2.
* *HandleVisits* : Track new page visits and put them into the breadcrumbs automatically? Default true.

## Services

You should call services.AddPatternflyBreadcrumb() to inject the BreadcrumbService.

# BreadcrumbService

A service that tracks the current breadcrumb state and stores it in the browser.

## Methods

* *GetAsync* : `Task GetAsync()` : Return the list of breadcrumbs.
* *VisitAsync* : `Task VisitAsync(string href, string title)` : Record the visit of a page.
* *ClearAsync* : `Task ClearAsync()` : Clear the current breadcrumbs.