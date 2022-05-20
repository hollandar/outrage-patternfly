

# Patternfly Pagination

link: [Patternfly Pagination](https://www.patternfly.org/v4/components/pagination)

namespace: Outrage.Patternfly.Components.Pagination

## Example usage
```
<PatternflyPagination Page="5" PageSize="200" TotalRecords="1000"/>
```
## Attributes

* *Page* : The current page (0 based).  Default 0;
* *PageSize* : The number of records per page of data. Default 5.
* *TotalRecords* : The total count of records you are paging through.
* *Sticky* : Render the pagination control as stuck to the content, includes drop shadows for top and bottom position paginators. Default false.
* *Compact* : Show the compact version which has less padding. Default false.
* *Position* : Where is the pagination control positioned relative to the content? [Top (default), Bottom]

## Methods

* *SelectPageSize* : `async Task SelectPageSize(int pageSize)` : Change the number of records that are shown on the page.
* *SelectPage* : `async Task SelectPage(int pageNumber)` : Set the current page that the paginator is showing as visible.

## Events

* *PageSizeSelected* : `EventCallback<int>` : Callback when a new page size is selected.
* *PageSelected* : `EventCallback<int>` : Callback when a new page is selected.