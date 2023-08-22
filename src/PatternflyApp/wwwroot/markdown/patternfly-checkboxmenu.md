

# Patternfly Checkbox Menu

link: [Patternfly Checkbox Menu](https://www.patternfly.org/components/toolbar#with-filters)

namespace: Outrage.Patternfly.Components.CheckboxMenu

# PatternflyCheckboxMenu

## Example usage

```
<PatternflyCheckboxMenu TKey="int" TValue="string" Options="values" Text="Select number(s)" @bind-SelectedKeys="selectedValues">
	<ItemTemplate>
		<span>@context.Key</span> - <span>@context.Value</span>
	</ItemTemplate>
</PatternflyCheckboxMenu>
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
Bind the selected values:
```
HashSet<int> selectedValues { get; set; }
```

## Sections

* *ItemTemplate(KeyValuePair<TKey,TValue>)* : A template for the menu item label. Optional, uses context.Value.ToString() by default.

## Attributes

* *TKey* : The type of the item key.
* *TValue* : The value presented in the select.
* *Expanded* : Is the select dropped down? Default false.
* *Text* : The text to show with no selection. Default "Select".
* *Options* : KeyValuePair<TKey, TValue>'s of items to be selected from.
* *SelectedKeys* : The value of the selected items, by their keys.
* *IconLibrary* *IconWeight* : See [Icon](/icon).
* *IconCaretDown* : Icon to use for a dropdown. Default "caret-down".
* *IconCheck* : Icon to show for the checked item. Default "check".

## Events 

* *SelectedKeysChanged* : `EventCallback<HashSet<TKey>>` : Callback when a new selection is made.

