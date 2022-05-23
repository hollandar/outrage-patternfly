# Patternfly Toaster

namespace: Outrage.Patternfly.Components.Toaster

## Example usage

To inject the toaster, usually on the main page:

```
@using Outrage.Patternfly.Components.Toaster
<PatternflyToaster></PatternflyToaster>
```

To post to the toaster, anywhere:

```
@using Outrage.Patternfly.Components.Alert
@using Outrage.Patternfly.Services
@inject ToasterService Toast

await this.Toast.Publish("A message", AlertColor.Default);
```

## Attributes

* *Expiry* : The number of seconds before the posted alert expires. Default 5 seconds.