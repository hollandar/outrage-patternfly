

# Patternfly Panel

link: [Patternfly Panel](https://www.patternfly.org/v4/components/panel)

namespace: Outrage.Patternfly.Components.Panel

## Example usage
```
<PatternflyPanel Raised="true" Bordered="true">
    <Header>A Panel</Header>
    <Body>
        This is the contents of the panel.
    </Body>
    <Footer>
        Some footer content.
    </Footer>
</PatternflyPanel>
```

## Sections

* *Header* : The panel header. (optional)
* *Body* : The body content section of the panel.
* *Footer* : The footer section of the panel

## Attributes

* *Raised* : Show a drop shadow on the panel? Default false.
* *Bordered* : Show a border on the panel? Default false.
* *Scrollable* : Is the panel scrollable?  If so also specify MaxHeightPx. (optional)
* *MaxHeightPx* : The maximum height of the panel, after which it is scrollable. (optional)

