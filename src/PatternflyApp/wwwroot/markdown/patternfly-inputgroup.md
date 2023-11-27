# PatternflyHint

link: [Patternfly Hint](https://www.patternfly.org/components/input-group)

namespace: Outrage.Patternfly.Components.InputGroup

## Example usage
```
<PatternflyEditForm Model="this.model">
    <PatternflyFieldGroup Label="Email Address">
        <Editors>
            <PatternflyInputGroup>
                <PatternflyInputGroupItem Box>
                    <PatternflyInputGroupText>@@</PatternflyInputGroupText>
                </PatternflyInputGroupItem>
                <PatternflyInputGroupItem Fill>
                    <PatternflyInputText @bind-Value="model.EmailAddress"></PatternflyInputText>
                </PatternflyInputGroupItem>
            </PatternflyInputGroup>
        </Editors>
    </PatternflyFieldGroup>
</PatternflyEditForm>

```

# PatternflyInputGroup

No sections or attributes, contains one or more PatternflyInputGroupItem's.

# PatternflyInputGroupItem

## Attributes
* *Box* : Adds a box around the item, useful to encapsulate non-input controls.
* *Fill* : Fills the remaining space in the group with the item.
* *Plain* : Indicates the item is plain.
* *Disabled* : Indicates the item is disabled.

# PatternflyInputGroupText

Text content within an input group item.
