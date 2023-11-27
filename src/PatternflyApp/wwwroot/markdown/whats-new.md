# Upgrading - Whats New

## Changes

With the release of Patternfly version 5, this version of the control suite brings an upgrade to the new styling framework provided by Patternfly.
Any custom styling add onto the patternfly v4 classes will need to be updated to the new v5 classes.  See the notes on upgrading to Patternfly V5 for more information.

## Icons

This library now supports V6 of the FontAwesome icon group, along with V5.  V5 remains the default version, but you can now change several defaults using the PatternflyDefaults settings.
To use font awesome V6, set the following during application startup:

```csharp
PatternflyDefaults.IconLibrary = LibraryEnum.fontawesome_6;
```

When you change the above setting, dont forget to link the new version of font awesome in your index.html.

## New Controls

Several new controls have been added to the library:

* **PatternflyBackToTop** - A back to top button that appears when the user scrolls down the page.
* **PatternflyCheckboxMenu** - A dropdown that allows the selection of one or more items from a checkbox list.
* **PatternflyDrawer** - A toggled draw that slides over content from a side of the page.
* **PatternflyInputTimespan** - Choose a time range using this control.
* **PatternflyInputGroup** - Provides for extensions around input controls, or the consolidation of multiple form controls into one.
* **PatternflyLabelGroup** - Allows you to group a number of labels together, with appropriate spacing.
* **PatternflyManySelect** - A flexible search and select control that allows the selection of one or more items from a searchable list.
* **PatternflySearch** - A debounced autocomplete control with full keyboard support.
* **PatternflySwitch** - A switch control backed by a checkbox.
* **PatternflyToggleGroupMultiselect** - A toggle group for a HashSet of values, more than one value can be selected.



