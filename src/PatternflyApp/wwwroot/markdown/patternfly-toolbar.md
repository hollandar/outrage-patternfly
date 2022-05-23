

# Patternfly Toolbar

link: [Patternfly Toolbar](https://www.patternfly.org/v4/components/toolbar)

namespace: Outrage.Patternfly.Components.Toolbar

# PatternflyToolbar
## Example usage
```
<PatternflyToolbar>
    <PatternflyToolbarGroup GroupType="ToolbarGroupType.button">
        <PatternflyActionList>
            <PatternflyAction Color="ButtonColor.Primary">Save</PatternflyAction>
            <PatternflyAction Color="ButtonColor.Secondary">Version</PatternflyAction>
            <PatternflyAction Color="ButtonColor.SecondaryDanger">Remove</PatternflyAction>
        </PatternflyActionList>
    </PatternflyToolbarGroup>
    <PatternflyToolbarDivider Vertical="true" />
    <PatternflyToolbarGroup GroupType="ToolbarGroupType.iconButton">
        <PatternflyButton Color="ButtonColor.Plain" Icon="save"></PatternflyButton>
        <PatternflyButton Color="ButtonColor.Plain" Icon="certificate"></PatternflyButton>
        <PatternflyButton Color="ButtonColor.Plain" Icon="times"></PatternflyButton>
    </PatternflyToolbarGroup>
    <PatternflyToolbarItem>
        <PatternflyDropdown Style="DropdownStyle.kebab">
            <PatternflyDropdownButton>Edit</PatternflyDropdownButton>
            <PatternflyDropdownButton>Copy</PatternflyDropdownButton>
            <PatternflyDropdownButton>Paste</PatternflyDropdownButton>
        </PatternflyDropdown>
    </PatternflyToolbarItem>
</PatternflyToolbar>
```
## Sections

Child content, usually toolbar items.

# PatternflyToolbarGroup

A group of items that respond together.

## Sections

Child content.

## Attributes 

* *GroupType* : The type of group. [none (default), filter, iconButton, button]

# PatternflyToolbarDivider 

## Attributes

* *Vertical* : Is the divider vertical or horizontal?  Default true.

# PatternflyToolbarItem

## Sections

Child content.

## Attributes

* *ItemType* : The kind of item contained. [none (default), bulkSelect, overflowMenu, pagination, searchFilter, label]