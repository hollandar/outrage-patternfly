# Patternfly Tabs

link: [Patternfly Tabs](https://www.patternfly.org/v4/components/tabs)

namespace: Outrage.Patternfly.Components.Tabs

# PatternflyTabs

## Example usage
```
<PatternflyTabs>
    <PatternflyTab Title="First Tab" Icon="tablet">
        Content of the first tab.
    </PatternflyTab>
    <PatternflyTab Title="Second Tab" Icon="table-tennis">
        Content of the second tab.
    </PatternflyTab>
    <PatternflyTab Title="Third Tab" Icon="scroll">
        Content of the third tab.
    </PatternflyTab>
</PatternflyTabs>
```
## Sections

Child content.  A number of PatternflyTab's

## Events

* *OnTabSelected* : `EventCallback<string>` : A callback that occurs when a tab is selected, passed the TabId of the tab.

# PatternflyTab

## Sections

Child content.  The content of the tab.

## Attributes

* *TabId* : The id of the tab.  Default RNG.
* *Disabled* : Is the tab enabled or disabled? Default false.
* *Title* : The text shown in the tab in the tab list.
* *Icon* *IconWeight* *IconLibrary* : See [Icon](/icon).
* *PanelCssClass* : Css class names applied to the panel.
* *TabCssClass* : Css class names applied to the tab.

## Methods

* *ActivateTab* : `Task ActivateTab()` : Activate this tab.
