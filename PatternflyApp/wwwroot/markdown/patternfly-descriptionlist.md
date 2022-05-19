

# PatternflyDescriptionList

link: [Patternfly Description List](https://www.patternfly.org/v4/components/description-list)

namespace: Outrage.Patternfly.Components.DescriptionList

## Example usage
```
    <PatternflyDescriptionList>
        <PatternflyDescriptionItem>
            <Term>Name</Term>
            <Description>Example</Description>
        </PatternflyDescriptionItem>
        <PatternflyDescriptionItem>
            <Term>Namespace</Term>
            <Description><a href="#">mary-test</a></Description>
        </PatternflyDescriptionItem>
        <PatternflyDescriptionItem>
            <Term>Labels</Term>
            <Description>Example</Description>
        </PatternflyDescriptionItem>
    </PatternflyDescriptionList>
```

## Sections

Child content.

## Attributes

* *Horizontal* : Show a horizontal list, instead of vertical. Default false.
* *Compact* : Display the list in the compact form. Default false.
* *Columns* : How should columns in the list be handled? [default (default), columns2, columns3onlg, autofit]

# PatternflyDescriptionItem

## Sections

* *Term* : The term section of the description item.
* *Description* : The description section of the description item.

## Attributes

* *Icon* *IconWeight* *IconLibrary* : See [Icon](/icon)
