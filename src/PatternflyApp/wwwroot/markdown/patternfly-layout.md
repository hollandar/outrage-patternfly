

# PatternflyBullseye

link: [Patternfly Bullseye](https://www.patternfly.org/v4/layouts/bullseye)

namespace: Outrage.Patternfly.Components.Layouts

Shows content centered in the section that contains it.

## Example usage
```
<PatternflyBullseye>
	<div>I'm in the moddle</div>
</PatternflyBullseye>
```
## Sections

Child content.

# PatternflyFlex, PatterflyFlexItem

link: [Patternfly Flex](https://www.patternfly.org/v4/layouts/flex)

namespace: Outrage.Patternfly.Components.Layouts

Applies standard flex behaviour to a number of items.

## Example usage
```
<PatternflyFlex>
	<PatternflyFlexItem>A item</PatternflyFlexItem>
	<PatternflyFlexItem>Another item</PatternflyFlexItem>
</PatternflyFlex>
```
## Flex attributes

* *Column* : Use vertical orientation instead of horizontal. Default false.
* *Grow* : Allow items to grow evenly to fit the container. Default false.
* *Justify* : Justify items within the container. [FlexStart (default), SpaceBetween, FlexEnd]

## FlexItem attributes

* *Grow* : Grow to take remaining available space given other items? Default false.

# PatternflyGrid, PatternflyGridItem

link: [Patternfly Grid](https://www.patternfly.org/v4/layouts/grid)

namespace: Outrage.Patternfly.Components.Layouts

Arranges items in a grid.

## Example usage

```
<PatternflyGrid>
	<PatternflyGridItem></PatternflyGridItem>
</PatternflyGrid>

```

## Grid attributes

* *Gutter* : Show gutters around items in the grid? Default false.

# PatternflyGallery, PatternflyGalleryItem

link: [Patternfly Gallery](https://www.patternfly.org/v4/layouts/grid)

namespace: Outrage.Patternfly.Components.Layouts

Arranges items in a gallery.

## Example usage

```
<PatternflyGallery>
	<PatternflyGalleryItem></PatternflyGalleryItem>
</PatternflyGallery>

```

## Gallery attributes

* *Gutter* : Show gutters around items in the gallery? Default false.

# PatternflySplit, PlatternflySplitItem

link: [Patternfly Split](https://www.patternfly.org/v4/layouts/split)

namespace: Outrage.Patternfly.Components.Layouts

A horizontal split set of controls.  One item can fill the remaining width.

## Example usage

```
<PatternflySplit>
	<PatternflySplitItem>An item</PatternflySplitItem>
	<PatternflySplitItem Fill="true">Another item</PatternflySplitItem>
</PatternflySplit>

```

## Split attributes

* *Gutter* : Show gutters around items in the grid? Default false.

## SplitItem attributes

* *Fill* : Cause this item fill the remaining width after accounting for other elements? Default false.

# PatternflyStack, PlatternflyStackItem

link: [Patternfly Stack](https://www.patternfly.org/v4/layouts/stack)

namespace: Outrage.Patternfly.Components.Layouts

A vertical stack of control, with the possibility to fill the view height with one.

## Example usage

```
<PatternflyStack>
	<PatternflyStackItem>An item</PatternflyStackItem>
	<PatternflyStackItem Fill="true">Another item</PatternflyStackItem>
</PatternflyStack>

```

## Stack attributes

* *Gutter* : Show gutters around items in the grid? Default false.

## StackItem attributes

* *Fill* : Cause this item fill the remaining height after accounting for other elements? Default false.

