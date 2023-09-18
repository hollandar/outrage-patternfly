

# Patternfly / FontAwesome Icon


namespace: Outrage.Patternfly.Components.Utilities

An icon.

The only library supported currently is the font awesome icon library version 5.

## Example usage
```
<Icon Name="cog"/>
```

## Attributes

* *Library* : Library that the icon comes from [fontawesome (default), fontawesome_5, fontawesome_6]
* *Weight* : Weight of the icon [thin, light, regular, solid (default), sharp, duotone, brand]
* *Size* : Size of the icon [xs2, xs, sm, regular (default), lg, x2, x3, x5, x7, x10]
* *Name* : Name of the icon, excluding any library specific leadin.  cog is fa-cog.
* *FixedWidth* : Fix the width of the icon for vertical alignment.

Note that libraries support different combinations of weight and size.  If you specify an invalid combination, the icon will not be displayed.
You can set PatternFlyDefaults.IconLibrary to change the default library globally.  The same is available for Weight and Size.