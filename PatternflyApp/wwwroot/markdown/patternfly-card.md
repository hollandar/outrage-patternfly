

# PatternflyCard

link: [Patternfly Card](https://www.patternfly.org/v4/components/card)

namespace: Outrage.Patternfly.Components.Card

## Example usage
```
<PatternflyCard>
    <Header>I'm in the header</Header>
    <Actions>
        <PatternflyButton Color="ButtonColor.InlineLink">Action</PatternflyButton>
    </Actions>
    <Title>A card with a title</Title>
    <Body><p>Content in the body of the card</p></Body>
    <Footer>Closing content, buttons or whatever</Footer>
</PatternflyCard>
```
## Sections

* *Header* : Content to show in the header of the card. (optional)
* *Actions* : Actions to provide on the card, often using PatternflyDropdown in the kebab style.  Requires header to be set as well. (optional)
* *Title* : Main title for the card. (optional)
* *Body* : Main body of the card. (optional)
* *Footer* : Footer, often actions or links relating to the card. (optional)
