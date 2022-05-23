

# PatternflyButton

link: [Patternfly Button](https://www.patternfly.org/v4/components/button)

namespace: Outrage.Patternfly.Components.Button

## Example usage
```
<PatternflyButton>I'm Primary</PatternflyButton>
<PatternflyButton Color="ButtonColor.Secondary">I'm Secondary</PatternflyButton>
<PatternflyButton Color="ButtonColor.Danger" Icon="bell" Clicked="HandleClicked">To click or not to click</PatternflyButton>
```
## Sections

Child content.

## Attributes

* *Color* : The button color. [plain, primary (default), secondary, secondarydanger, tertiary, danger, warning, link, inlinelink, linkdanger, control]
* *Icon* *IconLibrary* *IconWeight* *IconSize* : See [Icon](/icon)
* *IconPosition* : Position of the icon [start (default), end]
* *HRef* : A link to visit via the navigation manager? Takes precedence over the Clicked event if specified. (optional)
* *Type* : Html type of button. Default button.
* *Parent* : Something that implements ICloseOnClick, CloseAsync is called when the button is clicked. (optional)

## Events

* *Clicked* : `EventCallback<MouseEventArgs>` : A callback when the button is clicked.
