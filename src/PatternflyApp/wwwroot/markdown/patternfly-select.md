

# Patternfly Select

link: [Patternfly Select](https://www.patternfly.org/v4/components/select)

namespace: Outrage.Patternfly.Components.Select

# PatternflySelect

## Example usage

```
<PatternflySelect TKey="int" TValue="string" Options="values" Text="Select a number" />
```

Refer to the following for items for selection:
```
IEnumerable<KeyValuePair<int, string>> values = new KeyValuePair<int, string>[]
{
	new KeyValuePair<int, string>(1, "One"),
	new KeyValuePair<int, string>(2, "Two"),
	new KeyValuePair<int, string>(3, "Thre"),
	new KeyValuePair<int, string>(4, "Four"),
};
```

## Attributes

* *TKey* : The type of the item key.
* *TValue* : The value presented in the select.
* *Expanded* : Is the select dropped down? Default false.
* *Text* : The text to show with no selection. Default "Select".
* *Options* : KeyValuePair<TKey, TValue>'s of items to be selected from.
* *SelectedKey* : The value of the selected item, by its key.
* *IconLibrary* *IconWeight* : See [Icon](/icon).
* *IconCaretDown* : Icon to use for a dropdown. Default "caret-down".
* *IconCheck* : Icon to show for the checked item. Default "check".

## Events 

* *SelectedKeyChanged* : `EventCallback<TKey>` : Callback when a new selection is made.

# PatternflySelectTypeahead

## Example usage

```
<PatternflySelectTypeahead TItem="string" Items="typeaheads" Placeholder="Select a country" />
```

Refer to the following for items for selection:
```
IEnumerable<TypeaheadItem<string>> typeaheads = new TypeaheadItem<string>[]
    {
        new ("Switzerland"),
        new ("Norway"),
        new ("Italy"),
        new ("Germany"),
        new ("Belgium"),
        new ("France")
    };
```

## Attributes

* *TItem* : The type of the items being selected from.
* *Expanded* : Is the select dropped down? Default false.
* *Items* : An enumerable list of the items.
* *LoadItems* : A function call that should return a list of potential items.  Overrides Items.
* *IconLibrary* *IconWeight* : See [Icon](/icon).
* *IconCheck* : Icon to show for the checked item. Default "check".
* *IconCaret* : Icon to use for a dropdown. Default "caret-down".
* *IconClear* : Icon to use to clear current selection. Default "times-circle".

## Events 

* *OnItemSelected* : `EventCallback<TKey>` : Callback when a new selection is made.
* *OnItemCleared* : `EventCallback<TKey>` : Callback when the current selection is cleared.
* *OnItemCreated* : `EventCallback<string>` : Callback when a new item is to be created, pwith the entered value.

