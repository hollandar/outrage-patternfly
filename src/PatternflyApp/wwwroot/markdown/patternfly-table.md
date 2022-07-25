

# Patternfly Table

link: [Patternfly Table](https://www.patternfly.org/v4/components/table)

namespace: Outrage.Patternfly.Components.Table

# PatternflyTable

A table of data, not paginated.

## Example usage
```
<PatternflyTable TItemKey="Guid" TItem="Item" Items="Items">
    <Columns>
        <TableColumn>Id</TableColumn>
        <TableColumn>Flower</TableColumn>
        <TableColumn>Height</TableColumn>
        <TableColumn>Color</TableColumn>
    </Columns>
    <RowTemplate>
        <TableCell>@context.Id</TableCell>
        <TableCell>@context.Flower</TableCell>
        <TableCell>@context.Height</TableCell>
        <TableCell>@context.Color</TableCell>
    </RowTemplate>
</PatternflyTable>
```

Where source data is defined as:

```
public class Item
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Flower { get; set; }
    public string Height { get; set; }
    public string Color { get; set; }
}

public Item[] Items { get; } = new Item[]
{
    new Item { Flower="Daisy", Height = "30 centimeters", Color = "Yellow" },
    new Item { Flower="Correa", Height = "60 centimeters", Color = "Red/Green" },
    new Item { Flower="Sunflower", Height = "1 meter", Color = "Yellow" },
    new Item { Flower="Protea", Height = "3 meters", Color = "Red/Green" }
};
```
## Sections

* *Columns* : Column headings, a TableColumn for each column in the data.
* *RowTemplate* : A template for the row containing table cell data
* *NoItemsMessage* : The messages when there are no rows in the table.

## TableCells

* *TableCell* : A simple cell, include data as child content of the cell.
* *TableBoolean* : A true/false cell, you can specify the WhenTrue and WhenFalse values to render.
* *TableCellAction* : A cell flagged as containing an action or actions.
* *TableText* : A table cell mapping a value via ToString provided via the Value attribute.
* *TableActionLink* : A table cell that renders a Value as a link via Href.

## Attributes

* *Compact* : Render the compact version of the table. Default false.
* *Striped* : Alternate the color of each row? Default false.
* *FallbackPoint* : At what point does the table fall back to a single column for responsiveness? [Medium (default), Large, XLarge, XXLarge, Custom]
* *Label* : The screen reader (aria) label for the table.
* *Items* : Items to render in the rows of the table.
* *UseSelection* : When a row is clicked, mark it as selected, for dependent table views. Default false.

## Events

* *OnRowClicked* : `EventCallback<TItem>` : An event when the row is clicked.

# PatternflyListTable

## Example usage

```
<PatternflyListTable>
    <Columns>
        <TableColumn>Make</TableColumn>
        <TableColumn>Model</TableColumn>
        <TableColumn>Color</TableColumn>
    </Columns>
    <Rows>
        <TableRow>
            <TableCell>Toyota</TableCell>
            <TableCell>FJ Cruiser</TableCell>
            <TableCell>Red</TableCell>
        </TableRow>
        <TableRow>
            <TableCell>Nissan</TableCell>
            <TableCell>Leaf</TableCell>
            <TableCell>Blue</TableCell>
        </TableRow>
        <TableRow>
            <TableCell>Mazda</TableCell>
            <TableCell>6</TableCell>
            <TableCell>Black</TableCell>
        </TableRow>
    </Rows>
</PatternflyListTable>
```

## Sections

* *Columns* : Column headings, a TableColumn for each column in the data.
* *Rows* : Rows of the table, each contained in a TableRow.

## Attributes

* *FallbackPoint* : At what point does the table fall back to a single column for responsiveness? [Medium (default), Large, XLarge, XXLarge, Custom]
* *Label* : The screen reader (aria) label for the table.

# PatternflyPaginatedTable

A table that makes use of a table loader, and is able to paginate its content.

## Example usage

```
<PatternflyPaginatedTable TItemKey="Guid" TItem="Item" OnLoadItems="LoadItems" DefaultPageSize="2">
    <Columns>
        <TableColumn>Id</TableColumn>
        <TableColumn>Flower</TableColumn>
        <TableColumn>Height</TableColumn>
        <TableColumn>Color</TableColumn>
    </Columns>
    <RowTemplate>
        <TableCell>@context.Id</TableCell>
        <TableCell>@context.Flower</TableCell>
        <TableCell>@context.Height</TableCell>
        <TableCell>@context.Color</TableCell>
    </RowTemplate>
</PatternflyPaginatedTable>
```

OnLoadItems definiton, uses the data from previous examples.
```
public Task<DataPageLoadResult<Item>> LoadItems(DataPageLoadArgs<Guid> args)
{
    var items = Items.Skip(args.Page * args.PageSize).Take(args.PageSize);

    return Task.FromResult(new DataPageLoadResult<Item>()
        {
            Page = args.Page,
            PageSize = args.PageSize,
            Items = items,
            TotalRecords = Items.Count()
        });
}
```

## Sections

* *Columns* : Column headings, a TableColumn for each column in the data.
* *RowTemplate* : A template for the row containing table cell data
* *NoItemsMessage* : The messages when there are no rows in the table.
* *ToolbarItems* : A location for toolbar items, to the left of the pagination controls.

## TableCells

* *TableCell* : A simple cell, include data as child content of the cell.
* *TableBoolean* : A true/false cell, you can specify the WhenTrue and WhenFalse values to render.
* *TableCellAction* : A cell flagged as containing an action or actions.
* *TableText* : A table cell mapping a value via ToString provided via the Value attribute.
* *TableActionLink* : A table cell that renders a Value as a link via Href.

## Attributes

* *StateId* : An id used to track the page state of the table between visits.  Default RNG.
* *DefaultPageSize* : The default size of pages. Default 20.
* *ShowPagination* : Position to display pagination controls. [Top, Bottom, TopAndBottom (default)]
* *Compact* : Render the compact version of the table. Default false.
* *CompactPagination* : Use a compact paginator. Default false.
* *Striped* : Alternate the color of each row? Default false.
* *FallbackPoint* : At what point does the table fall back to a single column for responsiveness? [Medium (default), Large, XLarge, XXLarge, Custom]
* *Label* : The screen reader (aria) label for the table.
* *Items* : Items to render in the rows of the table.
* *UseSelection* : When a row is clicked, mark it as selected, for dependent table views. Default false.

## Methods

* *SelectPage* : `Task SelectPage(int page)` : Switch to a new page.  Page is zero based.
* *SelectPageSize* : `Task SelectPageSize(int pageSize)` : Change the current page size.
* *Refresh* : `Task Refresh(bool reset = false)` : Refresh the current page, and optionally return to page 0 (reset == true).
* *SelectById* : `Task SelectById(TItemKey id)` : Select a row in the table.

## Events

* *OnLoadItems* : `Func<DataPageLoadArgs<TItemKey>, Task<DataPageLoadResult<TItem>?>>? OnLoadItems` : A function that returns rows based on the current page.
* *OnRowClicked* : `EventCallback<TItem>` : An event when the row is clicked.

# PatternflyPaginatedFlex

A table that makes use of a table loader, and is able to paginate its content.

## Example usage

```
<PatternflyPaginatedFlex TItemKey="Guid" TItem="Item" OnLoadItems="LoadItems" DefaultPageSize="2">
    <RowTemplate>
        Row content
    </RowTemplate>
</PatternflyPaginatedFlex>
```

OnLoadItems definiton, uses the data from previous examples.
```
public Task<DataPageLoadResult<Item>> LoadItems(DataPageLoadArgs<Guid> args)
{
    var items = Items.Skip(args.Page * args.PageSize).Take(args.PageSize);

    return Task.FromResult(new DataPageLoadResult<Item>()
        {
            Page = args.Page,
            PageSize = args.PageSize,
            Items = items,
            TotalRecords = Items.Count()
        });
}
```

## Sections

* *RowTemplate* : A template for the row containing table cell data
* *NoItemsMessage* : The messages when there are no rows in the table.
* *ToolbarItems* : A location for toolbar items, to the left of the pagination controls.

## Attributes

* *StateId* : An id used to track the page state of the table between visits.  Default RNG.
* *DefaultPageSize* : The default size of pages. Default 20.
* *ShowPagination* : Position to display pagination controls. [Top, Bottom, TopAndBottom (default)]
* *Compact* : Render the compact version of the table. Default false.
* *CompactPagination* : Use a compact paginator. Default false.
* *Key* : A Func which returns the key from an item.  Default null.

## Methods

* *SelectPage* : `Task SelectPage(int page)` : Switch to a new page.  Page is zero based.
* *SelectPageSize* : `Task SelectPageSize(int pageSize)` : Change the current page size.
* *Refresh* : `Task Refresh(bool reset = false)` : Refresh the current page, and optionally return to page 0 (reset == true).
* *SelectById* : `Task SelectById(TItemKey id)` : Select a row in the table.

## Events

* *OnLoadItems* : `Func<DataPageLoadArgs<TItemKey>, Task<DataPageLoadResult<TItem>?>>? OnLoadItems` : A function that returns rows based on the current page.

# PatternflyPaginatedGallery

A gallery that makes use of a table loader, and is able to paginate its content.

## Example usage

```
<PatternflyPaginatedGallery TItemKey="Guid" TItem="Item" OnLoadItems="LoadItems" DefaultPageSize="2">
    <RowTemplate>
        Row content
    </RowTemplate>
</PatternflyPaginatedGallery>
```

OnLoadItems definiton, uses the data from previous examples.
```
public Task<DataPageLoadResult<Item>> LoadItems(DataPageLoadArgs<Guid> args)
{
    var items = Items.Skip(args.Page * args.PageSize).Take(args.PageSize);

    return Task.FromResult(new DataPageLoadResult<Item>()
        {
            Page = args.Page,
            PageSize = args.PageSize,
            Items = items,
            TotalRecords = Items.Count()
        });
}
```

## Sections

* *RowTemplate* : A template for the row containing table cell data
* *NoItemsMessage* : The messages when there are no rows in the table.
* *ToolbarItems* : A location for toolbar items, to the left of the pagination controls.

## Attributes

* *StateId* : An id used to track the page state of the table between visits.  Default RNG.
* *DefaultPageSize* : The default size of pages. Default 20.
* *ShowPagination* : Position to display pagination controls. [Top, Bottom, TopAndBottom (default)]
* *Compact* : Render the compact version of the table. Default false.
* *CompactPagination* : Use a compact paginator. Default false.
* *Key* : A Func which returns the key from an item.  Default null.
* *Gutter* : Use a gutter spacer between items? Default true.
* *GalleryStyle* : Override the style property on the galaery to set CSS values. Default "".

## Methods

* *SelectPage* : `Task SelectPage(int page)` : Switch to a new page.  Page is zero based.
* *SelectPageSize* : `Task SelectPageSize(int pageSize)` : Change the current page size.
* *Refresh* : `Task Refresh(bool reset = false)` : Refresh the current page, and optionally return to page 0 (reset == true).
* *SelectById* : `Task SelectById(TItemKey id)` : Select a row in the table.

## Events

* *OnLoadItems* : `Func<DataPageLoadArgs<TItemKey>, Task<DataPageLoadResult<TItem>?>>? OnLoadItems` : A function that returns rows based on the current page.
