

# PatternflyDrawer

link: [Patternfly Drawer](https://www.patternfly.org/components/drawer)

namespace: Outrage.Patternfly.Components.Drawer

## Description

Control to scroll the page back to the top of a container element specified by CSS selector. The default container is the first main section.

## Example usage
```
<PatternflyDrawer @ref="drawer">
    <Content>
        <p>
            Donec interdum sapien non bibendum sagittis. Etiam eu nisl sit amet lectus volutpat maximus id eleifend erat. Mauris consectetur
            finibus posuere. Fusce vel magna velit. Etiam semper libero a arcu tempus, a pulvinar mauris sodales. Aenean non mattis nisl.
            Vivamus eu lorem nisi. Quisque leo lorem, congue nec quam sed, placerat dapibus diam. Aenean scelerisque luctus gravida. Mauris
            erat libero, mollis ut metus quis, hendrerit tincidunt urna. Fusce et urna laoreet, vulputate turpis vitae, suscipit nisi.
        </p>
        <PatternflyButton Color="ButtonColor.Primary" Clicked="() => drawer?.ToggleDrawer()">Toggle Drawer</PatternflyButton>
    </Content>
    <Header>More details in the drawer...</Header>
    <Body>
        <p>
            Sed malesuada eros ipsum, in blandit ante euismod et. Suspendisse tincidunt justo lacus, vitae consectetur quam feugiat non.
            Nam aliquet venenatis elementum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.
            Nam vitae lectus pharetra, bibendum mauris vel, sodales dolor. Nam a laoreet ipsum. Nulla nunc lectus, vestibulum non risus in,
            egestas eleifend arcu. Mauris auctor ligula et erat luctus congue. Pellentesque imperdiet felis ut augue viverra, nec molestie
            odio tristique. Integer scelerisque porttitor mi, vitae hendrerit massa rutrum ac.
        </p>
    </Body>
</PatternflyDrawer>
```
### Sections

* *Content* : The main content of the drawer.
* *Body* : The side content, shown when the drawer is open.
* *Header* : Header content, shown at the top of the open drawer.

## Attributes

* *Open* : boolean : Is the drawer open?.
* *OnOpen* : EventCallback<bool> : Event raised when the drawer is opened.
* *OnClose* : EventCallback<bool> : Event raised when the drawer is closed.
* *Position* : PanelPosition : Position of the drawer. Default is PanelPosition.Right.

## Methods

* *ToggleDrawer* : Toggle the drawer open/closed.
* *OpenDrawer* : Open the drawer.
* *CloseDrawer* : Close the drawer.