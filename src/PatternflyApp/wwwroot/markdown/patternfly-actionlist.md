

# PatternflyActionList

link: [Patternfly Action List](https://www.patternfly.org/v4/components/action-list)

namespace: Outrage.Patternfly.Components.Actions

## Example usage
```
<PatternflyActionList>
    @{
        string item = "someItem";
    }
    <PatternflyActionListGroup>
        <PatternflyAction Color="ButtonColor.Primary" Icon="home"Clicked="ActionClicked">Save</PatternflyAction>
        <PatternflyAction Color="ButtonColor.Secondary" Icon="cogs" Clicked="ActionClicked">Cancel</PatternflyAction>
    </PatternflyActionListGroup>

    <PatternflyActionListGroup>
        <PatternflyActionItem TItem="string" Item="@item" Color="ButtonColor.Danger" Icon="cogs" Clicked="ItemClicked">Delete</PatternflyActionItem>
    </PatternflyActionListGroup>

</PatternflyActionList>
```
## Sections

Child content.

# PatternflyAction

An action button that handles a clicked event.

## Sections

Child content.

## Attributes

* *Color* : The color of the button to show. See [Button Color](/patternfly-button). Default primary.
* *Icon* : The icon shown in the button.  Use the icon class without extensions, instead of fa-home, use just home. (optional)
* *IconLibrary* : The icon library that the icon is from.  Must be fontawesome (v5).
* *IconPosition* : The position of the icon. [start (default), end]
* *IconWeight* : The weight class of the icon [light, regular, solid (default), duotone]
* *Type* : The html type of the button. Default "button".

## Methods

None.

## Events

* *Clicked* : `EventCallback` : An event callback when the button is clicked.

# PatternflyActionListGroup

Groups action items together and enforces spacing between controls.

## Sections

Child content. Add PatternflyActionItems here.

## Attributes

None.

## Methods

None.

## Events

None.


# PatternflyActionItem

An action button that handles a clicked event, passing back a specific item to the clicked action.

## Sections

Child content.

## Attributes

* *TItem* : The type of item the button is linked to.
* *Color* : The color of the button to show. See [Button Color](/patternfly-button). Default primary.
* *Icon* : The icon shown in the button.  Use the icon class without extensions, instead of fa-home, use just home. (optional)
* *IconLibrary* : The icon library that the icon is from.  Must be fontawesome (v5).
* *IconPosition* : The position of the icon. [start (default), end]
* *IconWeight* : The weight class of the icon [light, regular, solid (default), duotone]
* *Type* : The html type of the button. Default "button".

## Methods

None.

## Events

* *Clicked* : `EventCallback<TItem>` : An event callback when the button is clicked.  This receives an ItemEventArgs containing the item attached to the action, and the MouseEventArgs related to the click.

## Example click handler

Where TItem="string" the event handler would be:

```
Task ActionClicked(ItemEventArgs args) {
    Console.Writeline($"The item {args.Value} was clicked.");
}
```