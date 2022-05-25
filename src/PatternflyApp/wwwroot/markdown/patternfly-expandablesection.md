

# PatternflyExpandableSection

link: [Patternfly Expandable Section](https://www.patternfly.org/v4/components/expandable-section)

namespace: Outrage.Patternfly.Components.ExpandableSection

## Example usage
```
<PatternflyExpandableSection>
    This content is hidden by default, but can be expanded
</PatternflyExpandableSection>
```
## Sections

Child content.

## Attributes

* *ShowMore* : The text do display when the list is collapsed. Default "Show more".
* *ShowLess* : The text do display when the list is expanded. Default "Show less".
* *Expanded* : Is the section expanded? default false.
* *IconLibrary* *IconWeight* : See [Icon](/icon).
* *IconExpand* : Icon to show for section expansion. Default "angle-right".

## Methods

* *ToggleExpanded* : `async Task ToggleExpanded()` : Toggle panel expansion.

