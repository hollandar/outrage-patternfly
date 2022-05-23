

# Patternfly Progress

link: [Patternfly Progress](https://www.patternfly.org/v4/components/progress)

namespace: Outrage.Patternfly.Components.Progress

## Example usage
```
<PatternflyProgress ValueMin="0" ValueMax="100" Value="50" Description="50%"/>
```

## Attributes

* *Description* : A description of the progression. 
* *Complete* : Is the progress complete? Default false.
* *ValueMin* : Value that represents 0% progress. Default 0.
* *ValueMax* : Value that represents 100% progress. Default 100.
* *Value* : The value that represents the current level of progress. Default 0.
* *CompleteTimeout* : The amount of time to wait after progress finishes before raising the complete event. Default 1000.

## Methods

* *SetProgress* : `async Task SetProgress(int value)` : Set the current value of progress.
* *MarkComplete* : `async Task MarkComplete()` : Move progress to 100% and after a timeout, raise the complete event.

## Events

* *OnComplete* : `EventCallback` : On completion this callback is executed.