# PatternflyManySelect

namespace: Outrage.Patternfly.Components.ManySelect

Presents a searchable list of items and the ability to select one or more of them, depending on the parent control you use.

## Example usage
```
<PatternflyTitle HeadingLevel="2">Single Select</PatternflyTitle>

<PatternflySingleSelect TKey="Guid?" @bind-Value="this.model.Id">
    <Viewer>
        <PatternflyManySelectSingleValue TKey="Guid?"
                                            TValue="FruitItem"
                                            OnLoadItem="LoadFruit"
                                            ToViewString="FruitToString" />
    </Viewer>
    <Finder>
        <PatternflyManySelectSearch TKey="Guid?"
                                    TValue="FruitItem"
                                    OnLoadItems="LoadFruits"
                                    ToViewString="FruitToString"
                                    ToKey="(v) => v.Id" />
    </Finder>
</PatternflySingleSelect>

<PatternflyTitle HeadingLevel="2">Many Select</PatternflyTitle>

<PatternflyManySelect TKey="Guid?" @bind-Value="this.model.Ids">
    <Viewer>
        <PatternflyManySelectMultipleValue TKey="Guid?"
                                            TValue="FruitItem"
                                            OnLoadItems="LoadFruit"
                                            ToViewString="FruitToString"
                                            ToKey="(v) => v.Id"/>
    </Viewer>
    <Finder>
        <PatternflyManySelectSearch TKey="Guid?"
                                    TValue="FruitItem"
                                    OnLoadItems="LoadFruits"
                                    ToViewString="FruitToString"
                                    ToKey="(v) => v.Id" 
                                    Multiselect />
    </Finder>
</PatternflyManySelect>
```

## Models and Loaders

This structure uses two callbacks to load the values for the elements in the selectable list, below shown as LoadFruit and LoadFruits.
In this example the data is generated in memory, but it could just as well be loaded from a database or other source.


```csharp
Model model = new();

    public class Model
    {
        public Guid? Id { get; set; }
        public HashSet<Guid?> Ids { get; set; } = new();
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

    Task<ManySelectLoadResponse<FruitItem>> LoadFruits(ManySelectLoadArgs args)
    {
        var result = fruits.ToList();
        if (!String.IsNullOrEmpty(args.Search))
            result = fruits.Where(f => f.Name.Contains(args.Search, StringComparison.OrdinalIgnoreCase)).ToList();

        return Task.FromResult(new ManySelectLoadResponse<FruitItem>()
        {
            Page = args.Page,
            PageSize = args.PageSize,
            TotalRecords = result.Count,
            Values = result.Skip(args.Page * args.PageSize).Take(args.PageSize).ToList()
        });
    }

    Task<FruitItem?> LoadFruit(Guid? id)
    {
        return Task.FromResult(fruits.FirstOrDefault(f => f.Id == id));
    }

    string FruitToString(FruitItem? fruit)
    {
        return fruit?.Name ?? String.Empty;
    }
```

All controls accept type parameters:

* *TKey* : The type of the key used to identify the selected item(s).
* *TValue* : The type of the value that is loaded and presented.

Because TValue can be any type, the control needs to know how to convert the TValue to a string for presentation, and how to convert the TValue to a TKey for storage in the parent control.

* *ToViewString* : Func<TValue?, string>? : A callback that converts the TValue to a string for display in the list.
* *ToKey* : Func<TValue?, TKey>? : A callback that converts the TValue to a TKey for storage in the parent control.

# PatternflyManySelect

The parent control that presents the view of the selected element, and the control that is able to find items from the list.

## Sections

* *Viewer* : A container for a control able to view the selected items in the list.
* *Finder* : A container for a control that allows selection of one or more items from the list.

## Attributes

* *Disabled* : Is the control disabled?
* *Value*: The value of the control.  For single select this is a single value, for multi select this is a list of values.  Both are presented in a HashSet of TKeys structure.
* *ValueChanged*: An event that fires when the value of the control changes.
* *CloseOnSelect*: Should the finder close when an item is selected?

# PatternflySingleSelect

Equivalent configuration to PatternflyManySelect but its value is presented as a single value of type TKey rather than as a HashSet of TKey.
This API is convenient when mapping to a single rather than multiple values.

# PatternflyManySelectSearch

A searchable select that allows the selection of one or more items from the list.  This is placed in the Finder section of the parent control.

## Sections

None

## Attributes

* *OnLoadItems* : Func<ManySelectLoadArgs, Task<ManySelectLoadResponse<TValue>?>>? : A callback that is able to load a list of items, and search for items, from a backing list or database.
* *ToViewString* : Func<TValue?, string>? : A callback that converts the TValue to a string for display in the list.
* *ToKey* : Func<TValue?, TKey>? : A callback that converts the TValue to a TKey for storage in the parent control.
* *Search* : boolean : Should the control be searchable?
* *Multiselect* : boolean : Should the control allow multiple selections?
* *WhenNull* : string : The text to display when the value is null.

# PatternflyManySelectSingleValue

A presentation control when shows the string representation of a single selected value.  This is placed in the Viewer section of the parent control.

## Sections

None

## Attributes

* *OnLoadItem* : Func<TKey?, Task<TValue?>>? : A callback that is able to load a single item from a backing list or database.
* *ToViewString* : Func<TValue?, string>? : A callback that converts the TValue to a string for display in the list.

# PatternflyManySelectMultipleValue

A presentation control that present multiple selections.  Each selection is removable by clicking on the X.  This is placed in the Viewer section of the parent control.

## Sections

None

## Attributes

* *OnLoadItems* : Func<IEnumerable<TKey?>, Task<IEnumerable<TValue>>>? : A callback that is able to load a list of items from a backing list or database.
* *ToViewString* : Func<TValue?, string>? : A callback that converts the TValue to a string for display in the list.
* *ToKey* : Func<TValue?, TKey>? : A callback that converts the TValue to a TKey for storage in the parent control.
 