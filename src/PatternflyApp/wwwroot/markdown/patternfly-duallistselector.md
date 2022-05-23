# PatternflyDualListSelector

link: [Patternfly Dual List Selector](https://www.patternfly.org/v4/components/dual-list-selector)

namespace: Outrage.Patternfly.Components.DualListSelector

## Example usage

The definition of the list:
```
<PatternflyDualListSelector TKey="int" Items="Items"></PatternflyDualListSelector>
```

The items in the list:
```
public IEnumerable<DualListItem<int>> Items { get; } = new DualListItem<int>[]
{
    new (1, "one", 10), new (2, "two"), new (3, "three", 30, true), new (4, "four"), new (5, "five"),
    new (6, "six"), new (7, "seven"), new (8, "eight"),
};
```

## Section

* *AvailableAction* : Additional actions to sort available to the available list.  Consider a kebab dropdown.
* *SelectedAction* : Additional actions to sort available to the available list.  Consider a kebab dropdown.

## Attributes

* *TKey* : The type of the key to items in the list.
* *Items* : A list of DualListItem<TKey> that is rendered in the list.
* *AvailableHeading* : The heading for the list on the left available side. Default "Available options".
* *SelectedHeading* : The heading for the list on the right selected side. Default "Selected options".

## Properties

* *AvailableItems* : An IEnumerable<DualListItem<TKey>> of available items (not selected).
* *SelectedItems* : An IEnumerable<DualListItem<TKey>> of selected items (selected).

## Events

* *SelectedItemsChanged* : `EventCallback` : A callback that notifies you that the selected items in the list has changed.