# Getting Started

Welcome to Patternfly for Blazor.

## Install the Nuget Package

Install the latest package Outrage.Patternfly in your project from Nuget.

## Link the Patternfly css

In your Layout or the index.html for your app, reference the following css:

```
<link href="_content/Outrage.Patternfly/css/patternfly.base.css" rel="stylesheet" />
<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" rel="stylesheet" />
```

Both of these items are optional, they can be included from a CDN or from your project rather than from the embedded resource.

## Register the Toaster service

In your services setup, call AddPatternflyToaster:

```
using Outrage.Patternfly;

builder.Services.AddPatternflyToaster(); // Required for toaster

builder.Services.AddPatternflyPagedModelFactory(); // Required for datalist and table
```

While these setup calls are required for certain controls, they are not required to use the library unless you are using those controls.

## Clean up

You wont need links to bootstrap any longer, so clean those up.  You can also remove any left over files from wwwroot.

## Whats Next?

Start my adjusting your layout, the best place to begin is with the standard [PatternflyPage](/patternfly-page), the next topic.