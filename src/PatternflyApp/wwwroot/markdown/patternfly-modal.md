

# Patternfly Modal 

link: [Patternfly Modal](https://www.patternfly.org/v4/components/modal)

namespace: Outrage.Patternfly.Components.Modal

# PatternflyActionModal

A modal that shows predefined actions related to an item, which you can pass through the modal.
If you are using PatternflyPage, put the modal withing a PatternflyOnPage element per the example, it pushes the modal out so that the page sidebar doesnt interfere with it.

## Example usage

```
<PatternflyOnPage>
    <PatternflyActionModal @ref="okCancelModal" TItemType="string" Confirmation="ConfirmationEnum.okcancel" Confirmed="OkCancelConfirmed">
        <Header>Please confirm or decline</Header>
        <Body>
            Clicking ok or cancel will close the dialog, Confirmed or Declined callbacks will be called.
        </Body>
    </PatternflyActionModal>
</PatternflyOnPage>
```
## Sections

* *Header* : The header of the dialog.  The item that you passed to Show is available in the Context.
* *Body* : The body of the dialog.  The item that you passed to Show is available in the Context.
* *Footer* : The footer of the dialog.  The item that you passed to Show is available in the Context.

## Attributes

* *TItemType* : The type of the item that will be passed through show.
* *Confirmation* : The confirmation type. [ok, close (default), okcancel, yesno, custom]
* *ConfirmText* : Override the confirmation button text. (optional)
* *DeclineText* : Override the confirmation button text. (optional)
* *Size* : The size of the modal? [Small, Medium (default), Large, Full]

## Events

* *Confirmed* : `EventCallback<TItemType>` : A callback when the confirmed action is chosen.  Ok, Close and Yes are confirmed actions.
* *Declined* : `EventCallback<TItemType>` : A callback when the declined action is chosen. Cancel and No are declined actions.

## Methods

* *Show* : `async Task Show(TItemType item)` : Show the dialog, passing the specific item your are confirming.
* *Show* : `async Task Show(Func<Task<TItemType>> func)` : Show the dialog, using an inline function to determine the item you are confirming.
* *Hide* : `async Task Hide()` : Hide the modal without calling Confirmed or Declined events.

## Exceptions

If during the confirmed event, the follow on process fails, throw and ActionModalException.

The message returned by the exception will be shown on the dialog and it will remain open.

```
throw new ActionModdalException("The action failed, try again..");
```

# PatternflyModal

A regular modal, where you handle the close login yourself.
If you are using PatternflyPage, put the modal withing a PatternflyOnPage element per the example, it pushes the modal out so that the page sidebar doesnt interfere with it.

## Example usage

```
<PatternflyOnPage>
    <PatternflyModal @ref="patternflyModal">
        <Header>Modal</Header>
        <Help>A standard modal, with help.</Help>
        <Body>
            The body of the modal.
        </Body>
        <Footer>
            <PatternflyActionList>
                <PatternflyAction Clicked="() => patternflyModal.Hide()">Close</PatternflyAction>
            </PatternflyActionList>
        </Footer>
    </PatternflyModal>
</PatternflyOnPage>
```
## Sections

* *Header* : The header of the dialog.  
* *Help* : A help section for the dialog.
* *Body* : The body of the dialog.  
* *Footer* : The footer of the dialog.

## Attributes

* *CreateOnShow* : If this is true, the dialog html does not exist until it is shown; when false it is simply hidden. Default false.
* *Size* : The size of the modal? [Small, Medium (default), Large, Full]
* *Shown* : Is the dialog visible (including initially visible)? Default false.
* *IconLibrary* *IconWeight* : See [Icon](/icon).
* *IconHelp* : Icon to get help. Default "question-circle".
* *IconClose* : Icon to show for close. Default "times".

## Events

* *ShownChanged* : `EventCallback<bool>` : A notification that the modal is shown or hidden.

## Methods

* *Show* : `async Task Show()` : Show the modal.
* *Hide* : `async Task Hide()` : Hide the modal.

# PatternflyEditModal

An edit modal is one which contains an EditForm, and supports data annotations.
If you are using PatternflyPage, put the modal withing a PatternflyOnPage element per the example, it pushes the modal out so that the page sidebar doesnt interfere with it.

## Example usage

```
<PatternflyOnPage>
    <PatternflyEditModal @ref="patternflyModal" Model="editModel" OnValidSubmit="Save">
        <Annotations><DataAnnotationsValidator/></Annotations>
        <Header>Modal</Header>
        <Help>A standard modal, with help.</Help>
        <Body>
            <PatternflyFieldGroup Label="Name">
                <Editors>
                    <PatternflyInputText @bind-Value="editModal.Name"/>
                </Editors>
            </PatternflyFieldGroup>
        </Body>
        <Footer>
            <PatternflyActionList>
                <PatternflyAction Type="submit">Close</PatternflyAction>
            </PatternflyActionList>
        </Footer>
    </PatternflyEditModal>
</PatternflyOnPage>
```

## Sections

* *Annotations* : The header of the dialog.  
* *Header* : The header of the dialog.  
* *Help* : A help section for the dialog.
* *Body* : The body of the dialog.  
* *Footer* : The footer of the dialog.

## Attributes

* *CreateOnShow* : If this is true, the dialog html does not exist until it is shown; when false it is simply hidden. Default false.
* *Size* : The size of the modal? [Small, Medium (default), Large, Full]
* *Shown* : Is the dialog visible (including initially visible)? Default false.
* *Model* : The model to edit using the EditForm.
* *IconLibrary* *IconWeight* : See [Icon](/icon).
* *IconHelp* : Icon to get help. Default "question-circle".
* *IconClose* : Icon to show for close. Default "times".

## Events

* *ShownChanged* : `EventCallback<bool>` : A notification that the modal is shown or hidden.
* *OnValidSubmit* : `EventCallback<EditContext>` : The form is submitted validly.  Handle the submission in this callback.
* *OnInvalidSubmit* : `EventCallback<EditContext>` : The form is submitted in an invalid way.

### Handling errors in OnValidSubmit

In OnValidSubmit, if a subsequent validation error or submission error occurs that you want to show on the modal, throw an ActionModalException with a UI friendly message.

## Methods

* *Show* : `async Task Show()` : Show the modal.
* *Hide* : `async Task Hide()` : Hide the modal.

