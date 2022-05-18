

# PatternflyAlert

link: [Patternfly Alert](https://www.patternfly.org/v4/components/alert)

namespace: Outrage.Patternfly.Components.Alert

## Example usage
```
<PatternflyAlert Class="pf-u-m-md" Icon="crow" Title="Something happened" Dismissable="false"></PatternflyAlert> 
<PatternflyAlert Class="pf-u-m-md" Icon="bell" Title="Success happens" Color="AlertColor.Success">
    <Body>This one needs more description, clearly.</Body>
</PatternflyAlert> 
<PatternflyAlert Class="pf-u-m-md" Icon="exclaimation" Title="Something bad happened" Color="AlertColor.Danger">
    <Body>This one needs more description, clearly.</Body>
    <Actions><PatternflyButton Color="ButtonColor.Link">Action</PatternflyButton></Actions>
</PatternflyAlert> 
```
## Sections

* *Body* : The content of the alert. (optional)
* *Actions* : An action section, usually containing buttons. (optional)

## Attributes

* *Title* : Title to show on the alert. (optional)
* *Description* : Text to show in the body of the alert. (optional)
* *Icon* : Icon to show next to the title. (optional)
* *IconWeight*, *IconLibrary* : See [Icon](/icon)
* *Inline* : Show the inline variant? Default false. (optional)
* *Dismissable* : Can the alert be dismissed?  Default true.
* *Color* : Alert color [default (default), info, success, warning, danger]

## Events

* *OnDismiss* : EventCallback : An event callback on dismiss of the alert.
