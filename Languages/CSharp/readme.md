
<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
# Shape Refactoring Exercise #
#### A Refactoring Chew Toy ####

## Table Of Contents ##

- [Section 1: Introduction](#user-content-introduction)
- [Section 2: Requirements](#user-content-requirements)
- [Section 3: Setup](#user-content-setup)
- [Section 4: Run the tests](#user-content-run-the-tests)
- [Section 5: Changes that need to be made](#user-content-changes-that-need-to-be-made)

## Introduction ##

This document is specific for the C# version of the exercise and all commands listed are intended to be run within then CSharp directory.

This is a different kind of refactoring exercise. Most code exercises have a specific answer and are designed to be solved within a couple of hours. This one is intended to have a large number of solutions and take more then 10 hours without completion.

The idea is to be an exercise that you can continuously go back to and see new things. This is not intended for someone who is new to "_test based refactoring_" but for those who are familiar with the process and want to stay sharp or want to dive deeper.
    

## Requirements ##

To use this exercise you need the following installed:

- [node](https://nodejs.org/en/download/)
- [Gittey](https://www.npmjs.com/package/gittey) globally installed
  - `npm i gittey -g`
- [.Net 5.X](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
    

## Setup ##

### Global Setup

You need [gittey](https://www.npmjs.com/package/gittey) installed globally.

`npm i gittey -g`

### Local Setup

Run:

`gittey setup`
    

## Run the tests ##

To run the tests you must first have the requirements installed.

`gittey test`

This will run the tests. If the tests pass it will then prompt to commit files that changed.

### Explore code

`gittey check`

> Try not to use this one.

This will run the tests but without trying to commit.

### Commit code regardless of test passing

`gittey commit`

### Get rid of Current changes

`gittey undo`
    

## Changes that need to be made ##

Now to make the refactoring more focused, we have two expected changes that need to happen. These are optional for the purpose of the exercise but help us have a goal in mind.

### A Bug

**Expected Behavior:**
If three points are on the same line they should be classified as a line segment between the two furthest points.

**Actual Behavior:**
The segment is classified as 'Other' and contains all points.

### New Feature

**Parallelogram**
If given 5 points that form a parallelogram, but not a rectangle the shape returned should be a parallelogram. The fifth point should be the same as the first forming a closed shape. Each of the other 4 points are unique.

A parallelogram has 4 line segments, side A, side B, side C and side D with side A being the first line segment and all other line segments being consecutive. It has for angles angle A, angle B, angle C and angle D, with angle A being the first angle, and all other angles being consecutive.

A parallelogram should have a height, a width, a perimeter, and a volume.
    

<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
    