

# PatternflyView

namespace: Outrage.Patternfly.Components.View

Provides two controls that provider inner routing and attribute passing between views, without passing through the @page directive.

## Example usage
```
<PatternflyViewManager CurrentView="/pages/page1/4D774361-6D8B-4B4E-8F68-9BB9B1A55A33" ShowView="true">
    <Views>
        <PatternflyView TComponent="Page1" Route="/pages/page1/{Id}"/>
        <PatternflyView TComponent="Page2" Route="/pages/page2/{Id}"/>
    </Views>
</PatternflyViewManager>
```
Where Page1 is a component:
```
@using Outrage.Patternfly.Components.View
<PatternflyH3>Page1 (@Id)</PatternflyH3>
<PatternflyButton Clicked="Page2">Page 2</PatternflyButton>
<PatternflyButton Clicked="Page3">Page 3</PatternflyButton>

@code {
    [CascadingParameter(Name = "ViewManager")] public PatternflyViewManager ViewManager { get; set; } = default!;
    [Parameter] public int Id { get; set; }
    public async Task Page2()
    {
        await this.ViewManager.NavigateTo("/pages/page2/B8A33B15-495D-44A1-B807-A71739A65282");
    }
    
    public async Task Page3()
    {
        await this.ViewManager.NavigateTo("/pages/page3/04033D80-B568-44AB-AABB-355451BBA38A");
    }
}
```

# PatternflyViewManager

## Sections

* *View* : A collection of views with appropriate identity paths.

## Attributes

* *CurrentView* : The path to the view that is current.
* *ShowView* : Show a view that allows the current view path to be edited? Default false.

## Methods

* *NavigateTo* : `async Task NavigateTo(path)` : Navigate the view manager to a new path.  Access the view manager via the ViewManager cascading parameter.

## Events

* *CurrentViewChanged* : EventCallback<string> : Called when the current view is changed.

# PatternflyView

## TypeParams

* *TComponent* : The type of component to show for this route. Parameters are mapped onto the view according to the Route rules.  Component parameters should be marked with the [Parameter] attribute and the names should match the route.

Note: If the component does not define a parameter that is passed in the route, the value in the route is ignored.

## Sections

None.

## Attributes

* *Route* : The route of this view component (a path with attributes {Attribute}, or using a regular expression with named groups).
* *Visible* : Is the accordion panel shown by default? Default false.

## Methods

* *Show* : `async Task Show(path)` : Show the view with a particular path.  The path must match the views Ident.
* *Hide* : `async Task Hide()` : Hide the view.

Note: You should not call Show or Hide directly on a view, rather use the CurrentView.NavigateTo method on the view manager.

## Events

* *VisibleChanged* : `EventCallback<bool>` : A notification that the view visibility has changed, passes the new visibility state.