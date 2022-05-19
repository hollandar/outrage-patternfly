

# PatternflyDropdown

link: [Patternfly Dropdown](https://www.patternfly.org/v4/components/dropdown)

namespace: Outrage.Patternfly.Components.Dropdown

## Example usage
```
<PatternflyDropdown Text="Actions">
    <PatternflyDropdownButton>Link</PatternflyDropdownButton>
    <PatternflyDropdownButton>Action</PatternflyDropdownButton>
    <PatternflyDropdownButton Disabled="true">Disabled link</PatternflyDropdownButton>
    <PatternflyDropdownButton Disabled="true">Disabled action</PatternflyDropdownButton>
    <PatternflyDropdownDivider />
    <PatternflyDropdownButton>Separated link</PatternflyDropdownButton>
    <PatternflyDropdownButton>Separated action</PatternflyDropdownButton>
</PatternflyDropdown>
```
## Sections

Child content.

## Attributes

* *Expanded* : Is the dropdown expanded? Default false.
* *Style* :Dropdown style. [ regular (default), kebab]
* *AlignRight* : Right align the dropdown elements? Default false.
* *IsGrouped* : Handle a dropdown list containing groups? Default false.

## Methods

* *CloseAsync* : `async Task CloseAsync()` : Close the open dropdown.

# PatternflyDropdownDivider

Renders a divider in the dropdown.

# PatternflyDropdownItem

Renders any other content as an item in the dropdown.

## Sections

Child content.

# PatternflyDropdownGroup

Renders a dropdown group

## Sections

Child content.

## Attributes 

* *Title* : The title of the group.

# PatternflyDropdownButton

## Sections

Child content.

## Attributes

* *Icon* *IconLibrary* *IconWeight* : See [Icon](/icon)
* *Disabled* : Is this button disabled? Default false.

## Events

* *Clicked* : `EventCallback<MouseEventArgs>` : A notification that the button was clicked.