

# PatternflyForm

link: [Patternfly Form](https://www.patternfly.org/v4/components/form)

namespace: Outrage.Patternfly.Components.Form

## Example usage

```
<PatternflyEditForm Model="formModel" OnValidSubmit="SubmitForm">
    <DataAnnotationsValidator />
    <PatternflyFieldGroup Label="Name">
        <Help>Your name</Help>
        <Editors>
            <PatternflyInputText @bind-Value="formModel.Name"/>
            <PatternflyValidationMessage For="() => formModel.Name"/>
        </Editors>
    </PatternflyFieldGroup>
    <PatternflyFieldGroup Label="Age">
        <Help>Your age</Help>
        <Editors>
            <PatternflyInputText @bind-Value="formModel.Age"/>
            <PatternflyValidationMessage For="() => formModel.Age"/>
        </Editors>
    </PatternflyFieldGroup>
    <PatternflyValidationSummary/>
    <PatternflyActionGroup>
        <PatternflyButton Type="submit">Save</PatternflyButton>
    </PatternflyActionGroup>
</PatternflyEditForm>
```

# PatternflyEditForm

Produces a standard Blazor EditForm
## Sections

Child content.

## Attributes

* *Horizontal* : Render the form horizontally instead of vertically. Default false.

# PatternflyForm

For use inside a Blazor EditForm.  Causes child elements to be rendered using form styles, but it is not an EditForm itself.

## Sections

Child content.

## Attributes

* *Horizontal* : Render the form horizontally instead of vertically. Default false.

# PatternflyActionGroup

Shows a list of actions in a row, for example save and cancel buttons.

## Sections

Child content.

# PatternflyFieldGroup

Show a field with one or more editors for it.  Handles label and help sections for you.

## Sections

* *Help* : The help to show for the field.
* *Editors* : Editors and other elements for the field.

## Attributes

* *IsRequired* : Render an is required indicator on the label? Default false.
* *Label* : The label for the field. (optional)
* *Name* : The Html name of the field. (optional)
* *Stack* : Show space between the editors in a stack. Default false.
* *IconLibrary* *IconWeight* : See [Icon](/icon).
* *IconHelp* : Icon to show for access to help. Default "question-circle".

# PatternflyBooleanSelect

An editor that maps true and false selections to an underlying boolean value.

## Attributes

* *WhenTrue* : The text to show for the true entry.
* *WhenFalse* : The text to show for the true entry.
* *Value* : Binding to the underlying field value.

# PatternflyCheckbox

A multi state checkbox.

## Attributes

* *Name* : Name for the checkbox control.
* *Label* : Label for this checkbox.
* *Disabled* : Is this checkbox disabled? Default false.
* *Value* : Binding to the underlying field value.

# PatternflyInputNumber, PatternflyInputText, PatternflyInputTextArea

Standard field, but can be bound on change or in input.

## Attributes

* *BindOnInput* : Bind on change (false), or on input (true). Default false.
* *ReadOnly* : Make the field readonly. Default false.

# Other controls

These controls follow the standard Blazor controls.

* PatternflyInputRadio
* PatternflyInputSelect
* PatternflyInputCheckbox 
* PatternflyInputDateOnly
* PatternflyInputTimeOnly
* PatternflyInputDateTime
* PatternflyFileDropZone - A file drop zone that falls back to a standard InputFile control.

# PatternflyValidationMessage

Display the validation message for a field

## Attributes

* *For* : An expression that references the field for which the message is displayed.

# PatternflyValidationSummary

## Attributes

* *Model* : The model to validate.  In the default scenario the EditContext will be used. Default null.
* *Title* : The title to show if there are more than one errors.  If there is one error, it will be shown as the title. Default "Fields on the form require your attention:".
* *Icon* : Icon to show in the alert header. Default exclamation-circle.
* *IconLibrary* *IconWeight* *IconSize* : See [Icon](/icon).




