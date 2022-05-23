

# Patternfly Tree View

link: [Patternfly Tree View](https://www.patternfly.org/v4/components/tree-view)

namespace: Outrage.Patternfly.Components.TreeView

A tree view that supports blazor drag drop.

## Example usage
```
<PatternflyTreeView>
    <PatternflyTreeItem>
        <Text>Root</Text>
        <Children>
            <PatternflyTreeItem>
                <Text>Leaf with Action</Text>
                <Action>
                    <PatternflyButton Color="ButtonColor.Plain" Icon="cog"></PatternflyButton>
                </Action>
            </PatternflyTreeItem>
            <PatternflyTreeItem>
                <Text>Branch</Text>
                <Children>
                    <PatternflyTreeItem>
                        <Text>Leaf</Text>
                    </PatternflyTreeItem>
                    <PatternflyTreeItem>
                        <Text>Leaf</Text>
                    </PatternflyTreeItem>
                    <PatternflyTreeItem>
                        <Text>Leaf</Text>
                    </PatternflyTreeItem>
                </Children>
            </PatternflyTreeItem>
            <PatternflyTreeItem>
                <Text>Leaf</Text>
            </PatternflyTreeItem>
            <PatternflyTreeItem>
                <Text>Leaf</Text>
            </PatternflyTreeItem>
        </Children>
    </PatternflyTreeItem>
</PatternflyTreeView>
```

# PatternflyTreeView

## Sections

Child content, a PatternflyTreeItem.

# PatternflyTreeItem

## Sections

* *Text* : The content of the tree node.
* *Action* : Actions related to the item.
* *Children* : Children of this item, PatternflyTreeItems.

## Attributes

* *Expanded* : Is the item expanded? Default false.
* *Icon* : Icon when the item is closed. Default "folder".
* *IconOpen* : Icon when the item is open. Default "folder-open".

## Events

* *Clicked* : `EventCallback<MouseEventArgs>` : Event called when the item is clicked.
* *OnExpanded* : `EventCallback` : Event called when the item is expanded.
* *OnCollapsed* : `EventCallback` : Event called when the item is collapsed.
* *OnDragStart* : `EventCallback` : Event called when dragging the item starts.
* *OnDrop* : `EventCallback` : Event called when the item has another item dropped on it.
* *OnDragEnter* : `EventCallback` : Event called when a dragged item enters this item.
* *OnDragLeave* : `EventCallback` : Event called when a dragged item leaves this item.
