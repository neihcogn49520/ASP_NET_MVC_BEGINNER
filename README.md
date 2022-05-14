# ASP_NET_MVC_BEGINNER
<p align="center">
  <img src="https://rawcdn.githack.com/popperjs/popper-core/8805a5d7599e14619c9e7ac19a3713285d8e5d7f/docs/src/images/popper-logo-outlined.svg" alt="Popper" height="300px"/>
</p>

<div align="center">
  <h1>Tooltip & Popover Positioning Engine</h1>
</div>

<p align="center">
  <a href="https://www.npmjs.com/package/@popperjs/core">
    <img src="https://img.shields.io/npm/v/@popperjs/core?style=for-the-badge" alt="npm version" />
  </a>
  <a href="https://www.npmjs.com/package/@popperjs/core">
    <img src="https://img.shields.io/endpoint?style=for-the-badge&url=https://runkit.io/fezvrasta/combined-npm-downloads/1.0.0?packages=popper.js,@popperjs/core" alt="npm downloads per month (popper.js + @popperjs/core)" />
  </a>
  <a href="https://rollingversions.com/popperjs/popper-core">
    <img src="https://img.shields.io/badge/Rolling%20Versions-Enabled-brightgreen?style=for-the-badge" alt="Rolling Versions" />
  </a>
</p>

<br />
<!-- </HEADER> // NOW BEGINS THE README -->

**Positioning tooltips and popovers is difficult. Popper is here to help!**

Given an element, such as a button, and a tooltip element describing it, Popper
will automatically put the tooltip in the right place near the button.

It will position _any_ UI element that "pops out" from the flow of your document
and floats near a target element. The most common example is a tooltip, but it
also includes popovers, drop-downs, and more. All of these can be generically
described as a "popper" element.

## Demo

[![Popper visualized](https://i.imgur.com/F7qWsmV.jpg)](https://popper.js.org)

## Docs

- [v2.x (latest)](https://popper.js.org/docs/v2/)
- [v1.x](https://popper.js.org/docs/v1/)

We've created a
[Migration Guide](https://popper.js.org/docs/v2/migration-guide/) to help you
migrate from Popper 1 to Popper 2.

To contribute to the Popper website and documentation, please visit the
[dedicated repository](https://github.com/popperjs/website).
## Why Popper?

With the CSS drawbacks out of the way, we now move on to Popper in the
JavaScript space itself.

Naive JavaScript tooltip implementations usually have the following problems:

- **Scrolling containers**: They don't ensure the tooltip stays with the
  reference element while scrolling when inside any number of scrolling
  containers.
- **DOM context**: They often require the tooltip move outside of its original
  DOM context because they don't handle `offsetParent` contexts.
- **Compatibility**: Popper handles an incredible number of edge cases regarding
  different browsers and environments (mobile viewports, RTL, scrollbars enabled
  or disabled, etc.). Popper is a popular and well-maintained library, so you
  can be confident positioning will work for your users on any device.
- **Configurability**: They often lack advanced configurability to suit any
  possible use case.
- **Size**: They are usually relatively large in size, or require an ancient
  jQuery dependency.
- **Performance**: They often have runtime performance issues and update the
  tooltip position too slowly.

**Popper solves all of these key problems in an elegant, performant manner.** It
is a lightweight ~3 kB library that aims to provide a reliable and extensible
positioning engine you can use to ensure all your popper elements are positioned
in the right place.

When you start writing your own popper implementation, you'll quickly run into
all of the problems mentioned above. These widgets are incredibly common in our
UIs; we've done the hard work figuring this out so you don't need to spend hours
fixing and handling numerous edge cases that we already ran into while building
the library!

Popper is used in popular libraries like Bootstrap, Foundation, Material UI, and
more. It's likely you've already used popper elements on the web positioned by
Popper at some point in the past few years.

Since we write UIs using powerful abstraction libraries such as React or Angular
nowadays, you'll also be glad to know Popper can fully integrate with them and
be a good citizen together with your other components. Check out `react-popper`
for the official Popper wrapper for React.

## Installation

### 1. Package Manager

```bash
# With npm
npm i @popperjs/core

# With Yarn
yarn add @popperjs/core
```

### 2. CDN

```html
<!-- Development version -->
<script src="https://unpkg.com/@popperjs/core@2/dist/umd/popper.js"></script>

<!-- Production version -->
<script src="https://unpkg.com/@popperjs/core@2"></script>
```

### 3. Direct Download?

Managing dependencies by "directly downloading" them and placing them into your
source code is not recommended for a variety of reasons, including missing out
on feat/fix updates easily. Please use a versioning management system like a CDN
or npm/Yarn.

## Usage

The most straightforward way to get started is to import Popper from the `unpkg`
CDN, which includes all of its features. You can call the `Popper.createPopper`
constructor to create new popper instances.
