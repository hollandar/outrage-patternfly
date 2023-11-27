# Patternfly Search

namespace: Outrage.Patternfly.Components.Select

link: [Patternfly Search](https://www.patternfly.org/components/search-input)

An autocomplete search box that selected from loaded items.  Supports keyboard navigation and selection.

# PatternflySearch

## Example usage

```
<PatternflyEditForm Model="this.model">
    <PatternflySearch TItem="string" TItemKey="Guid?" LoadItems="LoadFruits" @bind-Value="this.model.Id"/>
</PatternflyEditForm>
```

Refer to the following for the search logic for example items:
```
public class Model
{
    public Guid? Id { get; set; }
}

class FruitItem
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

static List<FruitItem> fruits = new List<FruitItem> {
    new FruitItem { Id = Guid.NewGuid(), Name = "Apple" },
    new FruitItem { Id = Guid.NewGuid(), Name = "Banana" },
    new FruitItem { Id = Guid.NewGuid(), Name = "Cherry" },
    new FruitItem { Id = Guid.NewGuid(), Name = "Date" },
    new FruitItem { Id = Guid.NewGuid(), Name = "Elderberry" },
    new FruitItem { Id = Guid.NewGuid(), Name = "Fig" }
};

private Task<IEnumerable<KeyValuePair<Guid?, string>>> LoadFruits(string search)
{
    if (String.IsNullOrWhiteSpace(search)) {
        return Task.FromResult<IEnumerable<KeyValuePair<Guid?, string>>>(fruits.Select(f => new KeyValuePair<Guid?, string>(f.Id, f.Name)).ToList());
    }
    else {
        return Task.FromResult<IEnumerable<KeyValuePair<Guid?, string>>>(fruits.Where(f => f.Name.Contains(search, StringComparison.OrdinalIgnoreCase)).Select(f => new KeyValuePair<Guid?, string>(f.Id, f.Name)).ToList());
    }
}
```

## Attributes

* *TItemKey* : The type of the item key.
* *TItem* : The value presented in the search.  This is usually string.
* *Value* : The value of the selected item, by its key.
* *LoadItems* : Task<IEnumerable<KeyValuePair<TItemKey, TItem>>>>?: A function call that should return a list of potential items.

## Events 

* *ValueChanged* : `EventCallback<TItemKey>` : Callback when a new selection is made.

## Methods

* *Clear* : Clear the current selection.

## Controls

* *Up* : Move up through the item list.
* *Down* : Move down through the item list.
* *Enter* : Select the current item.
* *Tab* : Select the current item and move to the next control.
* *Escape* : Clear the current section.

## Notes

This control is debounced, in that it will not perform multiple search requests in parallel as the user types.
It does not delay lookups, so remains responsive even if it is debouncing keystrokes.

This control is a work in progress, it contains similar behaviout to the patternfly search control.