# PatternflyPage

link: [Patternfly Page](https://www.patternfly.org/v4/components/page)

namespace: Outrage.Patternfly.Components.Page

## Introduction

Encapsulates the Page component from Patternfly

## Example usage
```
<PatternflyPage FillMainContent="true">
    <Logo>
        <img class="pf-c-brand pf-u-display-block pf-u-display-none-on-md" style="height: 64px;"src="/images/icon_only.svg" alt="Patternfly">
        <img class="pf-c-brand pf-u-display-none pf-u-display-block-on-md" style="height: 64px;" src="/images/icon.svg" alt="Patternfly">
    </Logo>
    <Header>
        <PatternflyNavigation Horizontal="true">
            <PatternflyNavigationGroup>
                <PatternflyNavigationLink Href="" Match="NavLinkMatch.All">Home</PatternflyNavigationLink>
            </PatternflyNavigationGroup>
        </PatternflyNavigation>
    </Header>
    <Sections>
        <PatternflyPageSection Fill="true" Color="SectionColor.normal">
            @Body
        </PatternflyPageSection>
        <PatternflyPageSection Color="SectionColor.dark_200">
            Outrage Patternfly is Copyright (C) Webefinity Pty. Ltd. 2022.
        </PatternflyPageSection>
    </Sections>
    <Sidebar>
        <PatternflyNavigation>
            <PatternflyNavigationGroup>
                <PatternflyNavigationLink Href="getting-started" Icon="play">Getting Started</PatternflyNavigationLink>
                <PatternflyNavigationLink Href="patternfly-page" Icon="newspaper">Patternfly Page</PatternflyNavigationLink>
                ...
            </PatternflyNavigationGroup>
        </PatternflyNavigation>
    </Sidebar>
</PatternflyPage>
```
## Sections

* *Toggle* : Include a control to toggle the Sidebar section (optional)
* *Logo* : A place for your logo (optional)
* *Header* : The center navigation menu, usually a container for a horizontal [PatternflyNavigator](/patternfly-navigator). (optional)
* *Tools* : Tools to the right of your menu; login status for profile links. (optional)
* *Sidebar* : The sidebar navigation, usually a container for a [PatternflyNavigator](/patternfly-navigator). (optional)
* *Sections* : A collection of PatternflySection components, see PatternflyPageSection (below) (optional)
* *Body* : A specific section that it set to fill the main content area (optional)
* *Footer* : A specific section set to stick at the bottom of the main section. (optional)

## Attributes

* *LogoLinkUrl* : A url link to the home of your site.  Default "".
* *FillMainContent* : Should the sections cause the page to fill 100vh of the site? Default false.
* *StickFooter* : Should your footer section stick to and float the the bottom of the page? Default false.

## Methods

None.

<a name="patternfly-section"></a>
# PatternflyPageSection

## Introduction

Provides a content section within a page.

## Example usage

```
<PatternflyPageSection Fill="true" Color="SectionColor.normal">
    @Body
</PatternflyPageSection>
```

## Sections

Child content.

## Attributes

* *Fill* : Should this fill the remaining part of the page, if the page is set to fill site?  Default false.
* *Color* : What is the background color of the section? [normal (default), light_100, light_200, dark]
* *Shadow* : Does the section have a drop shadow? [none (default), top, bottom]
* *Sticky* : Does the section stick to a page location [node (default), top, bottom]
* *Center* : Is the content of the section centered? Default false.
* *OverflowScroll* : If the content is longer than the section, does it scroll? Default false.

## Methods

None.