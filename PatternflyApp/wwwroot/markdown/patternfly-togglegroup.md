

# Patternfly Toggle Group

link: [Patternfly Toggle Group](https://www.patternfly.org/v4/components/toggle-group)

namespace: Outrage.Patternfly.Components.ToggleGroup

Provides the choice between a number of bound values.

## Example usage
```
<PatternflyToggleGroup @bind-Value="selectedValue">
    <PatternflyToggleGroupItem Value="@("One")">
        Item One
    </PatternflyToggleGroupItem>
    <PatternflyToggleGroupItem Value="@("Two")">
        Item Two
    </PatternflyToggleGroupItem>
    <PatternflyToggleGroupItem Value="@("Three")">
        Item Three
    </PatternflyToggleGroupItem>
</PatternflyToggleGroup>
```

# PatternflyToggleGroup

## Sections

Child content.  A list of PatternflyToggleGroupItem's

## Attributes

* *TValueType* : The type of the value that the toggle group tracks.
* *Value* : The current value of the toggle group.
* *Compact* : Is the compact version of the toggle group used?  Default false.

# PatternflyToggleGroupItem

## Sections

Child content.

## Attributes

* *Value* : The value of this item in the group.
* *Icon* *IconWeight* *IconLibrary* : See [Icon](/icon).
* *IconPosition* : Position of the icon on relation to the content. [Start (default), End]

## Events

* *Clicked* : `EventCallback<TValueType>` : Notification that a group item was clicked.