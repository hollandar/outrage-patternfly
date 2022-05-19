

# Patternfly Loading

namespace: Outrage.Patternfly.Components.Loading

Shows a loading indicator while a target value is null or complete is false.  Once complete is true or a target has a value, loading stops and the children are displayed instead.
## Example usage
```
<PatternflyLoading Message="Loading" Target="somethingNull">
	<p>I'm visible once loading is complete</p>
</PatternflyLoading>
```
## Sections

Child content.

## Attributes

* *Target* : An optional nullable item, that while null displays the loader.  Once not null the child content is displayed.
* *Complete* : Set loading as complete, or not. Default false.
* *Message* : The message to show while loading? Default "Loading...".

## Methods

* *SetComplete* : `async Task SetComplete()` : Mark loading as complete, and display child content.
* *SetLoading* : `async Task SetLoading()` : Mark loading as NOT complete, and display the progress loader.
