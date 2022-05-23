

# Patternfly 

link: [Patternfly Accordion](https://www.patternfly.org/v4/components/accordion)

namespace: Outrage.Patternfly.Components.Accordion

## Example usage
```
<PatternflyHint Title="Do more with blazor">
    <Body>
        Do you want more assistance to get started?
    </Body>
    <Footer>
        <PatternflyButton Color="ButtonColor.Link">Get started</PatternflyButton>
    </Footer>
</PatternflyHint>
```
## Sections

* *Body* : Body content for the hint.
* *Footer* : Footer content for the hint.
* *Actions* : Actions in the top right, consider a kebab dropdown if there are multiple actions

## Attributes

* *AccordionId* : A unique html id for this accordion. Default RNG. (optional)
* *StateId* : An id used to track the state of the accordion. Default RNG. (optional)
* *CloseOthers* : Should opening one panel close all others? Default false. (optional)
* *UseSavedState* : Should the state of the accordion for this StateId be saved within the current session? Default false. (optional)

## Methods

* *CloseAll* : `async Task CloseAll()` : Close up all accordion panels.

# PatternflyAccordionPanel

## Sections

* *Header* : The content for the accordion panel/tab.
* *Body* : The content of the accordion panel.

## Attributes

* *Visible* : Is the accordion panel shown by default? Default false.

## Methods

* *Show* : `async Task Show()` : Shows the panel (closing others).
* *SetVisible* : `async Task SetVisible(bool visible)` : Closes or opens the panel independently.

## Events

* *VisibleChanged* : `EventCallback<bool>` : A notification that the panel visibility has changed, passes the new visibility state.