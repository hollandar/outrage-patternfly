# Getting Started

Welcome to Patternfly for Blazor.

## A Preconfigured App

If you dont want to start with your own project, you can clone the WebAssemblyClient project at [https://www.github.com/hollandar/outrage-patternfly/main/src/WebassemblyClient](https://www.github.com/hollandar/outrage-patternfly/main/src/WebassemblyClient)

## Install the Nuget Package

Rather modify an existing app to integrate Patternfly?

Install the latest package Outrage.Patternfly in your project from Nuget.

## Link the Patternfly css

In your Layout or the index.html for your app, reference the following css:

```
<link href="_content/Outrage.Patternfly/css/patternfly.base.css" rel="stylesheet" />
<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" rel="stylesheet" />
```

Both of these items are optional, they can be included from a CDN or from your project rather than from the embedded resource.

## Register the Toaster service

In your services setup, call AddPatternflyToaster and AddPatternflyPagedModelFactory:

```
using Outrage.Patternfly;

builder.Services.AddPatternflyToaster(); // Required for toaster

builder.Services.AddPatternflyPagedModelFactory(); // Required for datalist and table
```

While these setup calls are required for certain controls, they are not required to use the library unless you are using those controls.

## Clean up

You wont need links to bootstrap any longer, so clean those up.  You can also remove any left over files from wwwroot.

## Whats Next?

Start by adjusting your layout, the best place to begin is with the standard [PatternflyPage](/patternfly-page).