
<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
# Shape Refactoring Exercise #
#### A Refactoring Chew Toy ####

## Table Of Contents ##

- [Section 1: Note on Refactoring](#user-content-note-on-refactoring)
- [Section 2: Introduction](#user-content-introduction)
- [Section 3: Definitions](#user-content-definitions)
- [Section 4: Setup](#user-content-setup)
- [Section 5: Run the tests](#user-content-run-the-tests)
- [Section 6: Purpose of Code](#user-content-purpose-of-code)
- [Section 7: Changes that need to be made](#user-content-changes-that-need-to-be-made)
- [Section 8: Contributors ✨](#user-content-contributors-✨)
- [Section 9: How to contribute](#user-content-how-to-contribute)
- [Section 10: A Note on Tooling](#user-content-a-note-on-tooling)

## Note on Refactoring ##

_If_ you have to change a test to make a change work, you are not refactoring. You are instead rearchitecting. Now this code can benefit from a change to architecture but don't call it refactoring.
    

## Introduction ##

This is a different kind of refactoring exercise. Most code exercises have a specific answer and are designed to be solved within a couple of hours. This one is intended to have a large number of solutions and take more then 10 hours without completion.

The idea is to be an exercise that you can continuously go back to and see new things. This is not intended for someone who is new to "_test based refactoring_" but for those who are familiar with the process and want to stay sharp or want to dive deeper.
    

## Definitions ##

**Refactoring**: Throughout this exercise the word "refactoring" means changing structure _without_ changing external behavior.
    

## Setup ##

### Global Setup

You need [gittey](https://www.npmjs.com/package/gittey) installed globally.

`npm i gittey -g`

### Local Setup

In the directory for the exercise run:

`gittey setup`

### Recommendations

It is suggested that you:

1. Clone this repository
1. Delete the ```.git``` directory
1. Delete all the languages you are not planning to work in
1. Set up the directory for your language according to the readme
   1. Run: ```gittey setup```
1. run a ```git init``` in that directory
1. Run the tests
   1. ```gittey test```
1. start working

    

## Run the tests ##

`gittey test`

This will run the tests. If the tests pass it will then prompt to commit files that changed.

### Explore Code

`gittey check`

> Try not to use this one.

This will run the tests but without trying to commit.

### Commit Code regardless of test passing

`gittey commit`
    

## Purpose of Code ##

The code takes an array of points and returns an objects that represents the shape and some of its properties.

### Types of Shapes

- Empty
- Point
- Line Segment
- Triangle
- Rectangle
- Other

### Basic Shapes

#### Empty

The empty shape is a non-shape. It is formed from an empty array of points and has no properties except being an empty shape.

#### Point

The point shape is formed from an array containing a single point and has an X and Y.

### Line Segment

The line segment is formed from an array containing 2 points. It has both points as properties as well as length and slope.

### Triangle

The triangle is formed from an array with 4 points, the first and last are the same point forming a closed shape. The first 3 points are unique. It will have three line segments, formed from the three points: side A, side B, and side C with side A being formed from the first two points and consecutively from there.

It will have three angles, angle A, angle B, and angle C. Angle A, is opposite side A, angle B is opposite side B, and angle C is opposite side C. Each angle will be formed of two line segments that form the angle and have the degrees of the angle.

A triangle will also contain the area of the triangle.

### Rectangle

The rectangle is formed by an array of 5 points, the first and last are the same point forming a closed shape. The first 4 points are unique. A rectangle will contain 4 line segments, side A, side B, side C, and side D. Side A is formed from the first two points, and each side if formed consecutively from there. To be a rectangle the angle between any adjoining sides will be 90 degrees.

A rectangle will contain the area of the rectangle.

### Other

The other shape is formed by an array of points that do not make any other shape. It contains the points that formed it.
    

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
    

## Contributors ✨ ##

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="https://github.com/edf-re"><img src="https://avatars.githubusercontent.com/u/13739273?v=4?s=100" width="100px;" alt=""/><br /><sub><b>EDF Renewables</b></sub></a><br /><a href="#financial-edf-re" title="Financial">💵</a></td>
    <td align="center"><a href="http://www.chrisstead.net/"><img src="https://avatars.githubusercontent.com/u/4184510?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Chris Stead</b></sub></a><br /><a href="#tool-cmstead" title="Tools">🔧</a></td>
    <td align="center"><a href="https://github.com/thomas-desmond"><img src="https://avatars.githubusercontent.com/u/24610108?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Thomas Desmond</b></sub></a><br /><a href="#ideas-thomas-desmond" title="Ideas, Planning, & Feedback">🤔</a></td>
  </tr>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!
    

## How to contribute ##

The guide to how to contribute is here: [How To Contribute](./contributing.md).
    

## A Note on Tooling ##

When developing this exercise I used two tools I want to call out. The first is ```Gittey```.

**[Gittey](https://www.npmjs.com/package/gittey)** is a free command automation that has understanding of git. It is used to help automate workflows. I have also used it to ensure a common feel between exercises of different languages.

**[Book Lisp](https://www.npmjs.com/package/booklisp)** is a mark down document generator that was used to build the document you are currently reading. Book Lisp allows me to break the document into smaller manageable chunks and then compile them into bigger documents.

Both of these tools were created and maintained by [Chris Stead](https://github.com/cmstead). I give him a due thanks for the work he puts into making developer lives easier.
    

<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
    