

# PatternflyMenu

link: [Patternfly Menu](https://www.patternfly.org/v4/components/menu)

namespace: Outrage.Patternfly.Components.Menu

## Example usage
```
<PatternflyMenu MenuStyle="MenuStyle.DrillDown">
    <PatternflyMenuItem Text="Action 1"></PatternflyMenuItem>
    <PatternflyMenuItem Text="Action 2"></PatternflyMenuItem>
    <PatternflyMenuDivider />
    <PatternflyMenuItem Text="Action 3">
        <Actions>
            <PatternflyMenuAction Icon="bell"></PatternflyMenuAction>
        </Actions>
    </PatternflyMenuItem>
    <PatternflyMenuItem Text="Submenu">
        <Menus>
            <PatternflyMenu>
                <PatternflyMenuBack></PatternflyMenuBack>
                <PatternflyMenuDivider></PatternflyMenuDivider>
                <PatternflyMenuItem Text="Do something"></PatternflyMenuItem>
            </PatternflyMenu>
        </Menus>
    </PatternflyMenuItem>
</PatternflyMenu>
```

## Sections

Child content.

## Attributes

* *MenuStyle* : The menu style. [Normal (default), Flyout, Drilldown]
* *Scrollable* : Is the menu scrollable and have a fixed height? Default false.
* *MaxHeightPx* : The maximum menu height in pixels.

## Methods

* *ResetExpanded* : `async Task ResetExpanded()` : Reset all expanded items in the menu.

# PatternflyMenuItem

A menu item within a menu.

## Sections

* *Actions* : Actions related to the menu item.
* *Menus* : Submenus within this menu.

## Attributes

* *Text* : The menu text.
* *Icon* *IconSize* *IconWeight* *IconLibrary* : See [Icon](/icon).
* *IconCaret* : The icon from the referenced library to use for the right caret on a submenu link.
* *Description* : The description shown under the menu text. (optional)
* *Expanded* : Is the menu item expanded? Default false.

## Methods

* *ResetExpanded* : `async Task ResetExpanded()` : Collapse this menu and reset the top level menus.

## Events

* *Clicked* : `EventCallback<MouseEventArgs>` : The menu item was clicked.  Not that this wont be received if the item contains a submenu.

# PatternflyMenuDivider

Shows a horizontal rule to divide the menu.

# PatternflyMenuBack

Repeats the parent menu item name with a left caret, to drill up to the previous menu.

## Attributes

* *Text* : Override the text of the menu item parent for the return link. (optional)
* *IconCaret* : The icon to use for the back link.  Default angle-left;
* *IconSize* *IconWeight* *IconLibrary* : See [Icon](/icon).

# PatternflyMenuAction

A button for use in the Actions section of the menu item.

## Attributes

* *Icon* *IconSize* *IconWeight* *IconLibrary* : See [Icon](/icon).

## Events

* *Clicked* : `EventCallback<MouseEventArgs>` : The action item was clicked.
