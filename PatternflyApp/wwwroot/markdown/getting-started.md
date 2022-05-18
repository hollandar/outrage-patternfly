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

The font-awesome inclusion is optional, you can use and icon library, and you may of course reference them in other ways.

## Register the Toaster service

In your services setup, call AddPatternflyToaster:

```
using Outrage.Patternfly;

builder.Services.AddPatternflyToaster();
```
## Clean up

You wont need links to bootstrap any longer, so clean those up.  You can also remove any left over files from wwwroot.

## Whats Next?

Start my adjusting your layout, the best place to begin in with the standard [PatternflyPage](/patternfly-page), the next topic.