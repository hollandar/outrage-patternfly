

# PatternflyDataList

link: [Patternfly Data List](https://www.patternfly.org/v4/components/datalist)

namespace: Outrage.Patternfly.Components.DataList

## Example usage

The grid itself:

```
<PatternflyDataList TItemModel="Item" Items="this.Items">
    <ItemTemplate>
        <div class="pf-c-data-list__item-row">
            <div class="pf-c-data-list__item-content">
                <div class="pf-c-data-list__cell">
                    @context.Flower
                </div>
                <div class="pf-c-data-list__cell">
                    @context.Color
                </div>
                <div class="pf-c-data-list__cell">
                    @context.Height
                </div>
            </div>
        </div>
    </ItemTemplate>
</PatternflyDataList>
```

Defining some items for the grid to refer to:

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

* *ItemTemplate* : The template for each item in the list.  The item for the row is passed as context to the template.

## Attributes

* *TItemModel* : The type of item to show.  This is the context type for ItemTemplate.
* *Compact* : Show the compact version of the data list. Default false.
* *WrappedItems* : A list of items already wrapped in a DataItemWrapperModel. (optional)
* *Items* : A list of items. (optional) (required if WrappedItems is not provided)
* *AriaLabel* : The aria label for the entire list. (optional)
* *ItemAriaLabel* : `Func<TItemModel, string>` : A callback that determines the aria label for each item. (optional)

## Events

* *OnItemClicked* : `EventCallback<TItemModel>` : Callback when an item in the list is clicked.
* *OnLoadItems* : `Func<DataPageLoadArgs<TItemKey>, Task<DataPageLoadResult<TItemModel>?>>? OnLoadItems` : Callback to load items, the callback is provided the details of the page, and returns the contents of the requested page.  An example of this callback is shown below.

# PatternflyPaginatedDataList

## Sections

* *ItemTemplate* : The template for each item in the list.  The item for the row is passed as context to the template.
* *NoItemsMessage* : Content to show in the event that there are no items in the list.
* *ToolbarItems* : Items to show in the toolbar in addition to the pagination controls.

## Attributes

* *TItemKey* : The type of item key to show.
* *TItemModel* : The type of item to show.  This is the context type for ItemTemplate.
* *Compact* : Show the compact version of the data list. Default false.
* *CompactPagination* : Show the compact version of the pagination control. Default false.
* *DefaultPageSize* : The starting page size for the paginated list. Default 5.
* *AriaLabel* : The aria label for the entire list. (optional)
* *ItemAriaLabel* : `Func<TItemModel, string>` : A callback that determines the aria label for each item. (optional)

## Methods

* *Refresh* : `async Task Refresh(bool reset = false)` : Reload the current page, optionally resetting to the initial page.

## Events

* *OnItemClicked* : `EventCallback<TItemModel>` : Callback when an item in the list is clicked.

## OnLoaddItems example

This example of the pagination on load items makes use of the list of items shown for the non-paginated data list.

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

## Configuration

The paginated data list makes use of an instance of the DataPageModelFactory, which must be registered.

You can register it by adding the following to your dependency services setup.
```
using Outrage.Patternfly;
builder.Services.AddPatternflyPagedModelFactory();
```