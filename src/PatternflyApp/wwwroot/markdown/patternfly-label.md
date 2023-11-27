

# PatternflyLabel

link: [Patternfly Label](https://www.patternfly.org/components/label)

namespace: Outrage.Patternfly.Components.Label

## Example usage

```
<PatternflyLabelGroup>
    <PatternflyLabelGroupListItem>
        <PatternflyLabel Color="LabelColor.Blue" Icon="info" Text="Information"></PatternflyLabel>
    </PatternflyLabelGroupListItem>
    <PatternflyLabelGroupListItem>
        <PatternflyLabel Color="LabelColor.Purple" Icon="question" Text="Question"></PatternflyLabel>
    </PatternflyLabelGroupListItem>
</PatternflyLabelGroup>
```

# PatternflyLabelGroup

## Sections

Child content contains a number of PatternflyLabelGroupListItem's.

## Attributes

* *Description* : Description for screen readers.

# PatternflyLabelGroupListItem

A member of the label group list, this is a container for a PatternflyLabel when it is used inside a PatternflyLabelGroup.

# PatternflyLabel

## Attributes

* *Text* : A unique html id for this accordion. Default RNG. (optional)
* *Color* : The label color. [Default (default), Gray, Blue, Green, Orange, Red, Purple, Cyan]
* *Icon* *IconWeight* *IconLibrary* : See [Icon](/icon)
* *Compact* : Show a compact version of the label? Default false.
* *Outline* : Show an outline on the label? Default false.

## Events 

* *Closed* : `EventCallback` : When defined, shows a close x on the label and calls back when it is clicked, on label removal for example.
* *Clicked* : `EventCallback` : When defined, calls back when the label is clicked.