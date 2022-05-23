

# Patternfly Navigation

link: [Patternfly Navigation](https://www.patternfly.org/v4/components/navigation)

namespace: Outrage.Patternfly.Components.Navigation

## Example usage

The following is a portion of the navigation shown to the left.

```
<PatternflyNavigation>
    <PatternflyNavigationGroup Title="Introduction">
        <PatternflyNavigationLink Href="getting-started" Icon="play">Getting Started</PatternflyNavigationLink>
    </PatternflyNavigationGroup>
    <PatternflyNavigationGroup Title="Components">
        <PatternflyNavigationLink Href="patternfly-accordion" Icon="square">Accordion</PatternflyNavigationLink>
        <PatternflyNavigationLink Href="patternfly-actionlist" Icon="exclamation">Actions</PatternflyNavigationLink>
    </PatternflyNavigationGroup>
</PatternflyNavigation>
```

# PatternflyNavigation

The root navigation item

## Sections

Child content.

## Attributes

* *Horizontal* : Show the navigation horizontally, as in the top menu. Default false;

# PatternflyNavigationGroup

A group of items, optionally with a title.

## Sections

Child content.

## Attributes

* *Title* : The title of the section. (optional)

# PatternflyNavigationItem

A non-specific navigation entry, you can include whatever content.

## Sections

Child content.

# PatternflyNavigationAction 

An action rendered as an anchor tag that calls a clicked event.

## Sections

Child Content.

## Attributes

* *Icon* *IconWeight* *IconLibrary* : See [Icon](/icon)
* *Text* : The text for the action.
* *Active* : The active state of the item.  Default true.

## Events

* *Clicked* : `EventCallback<MouseEventArgs>` : An callback to execute on click.

# PatternflyNavigationLink

A link to an internal page or external site via an anchor tag.

## Sections

Child Content.

## Attrbutes

* *Icon* *IconWeight* *IconLibrary* : See [Icon](/icon)
* *Text* : The text for the action.
* *Active* : The active state of the item.  Default true.
* *Href* : A link to visit on click.
* *Match* : NavLinkMatch enumeration, used in determining if this is the current navigation item.

# PatternflyNavigationExpandable

An expandable section that contains items, expands on click.

## Sections

Child content.  No need to include a PatternflyNavigationGroup.

## Attributes

* *Icon* *IconWeight* *IconLibrary* : See [Icon](/icon)
* *IconExpanded* : Name of the icon to use to indicate the section is expanded.
* *IconCollapsed* : Name of the icon to use to indicate the section is collapsed.
* *Text* : The text for the action.
* *Expanded* : Is the section expanded? Default false;

## Events

* *OnExpanded* : `EventCallback<bool>` : A callback when the section is expanded, indicating the expanded state.
