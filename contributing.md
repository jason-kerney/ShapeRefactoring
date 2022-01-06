
<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
# How to contribute #
#### A welcome guide to helping out ####

## Table Of Contents ##

- [Section 1: Intention of Design](#user-content-intention-of-design)
- [Section 2: The Basics](#user-content-the-basics)
- [Section 3: Adding an Exercise](#user-content-adding-an-exercise)
- [Section 4: Optimizations and Bug Fixes](#user-content-optimizations-and-bug-fixes)

## Intention of Design ##

This exercise has two main intents:

1. Take a long time to complete
2. Have many different ways to complete it

This guide will walk you through how to contribute so that those two intents are not violated.
    

## The Basics ##

The biggest ask I have is that any code added is well tested. I would suggest that you do it Test Driven, but do not require it.
    

## Adding an Exercise ##

### A Note

Remembering the intent with adding an Exercise, I ask that you do not look at any of the current solutions. I do not want the exercise for every language to look like every other language.

Instead the goal is to use the best aspects of your language to recreate the desired behavior but having the solution be a language native solutions.

You can also read this full [guide](./new_exercises.md)

### Focus on Tests

Since the goal is expected behavior then I ask people to start by focusing on the tests. If you use the tests as a guide instead of the target code, you are in a better position for building a language native solution. This solution should be well designed.

You can always refer to this [guide](./test_cases.md) on the test cases to help you along.

### A Difference of Paradigm

The initial solutions were done in an Object Oriented paradigm. If your language uses a different paradigm or even supports a different paradigm it is desirable that the refactoring not be held to being Object Oriented. In that case, I expect the tests to be very different.

The main thing here is that the intent of the behavior of the test is kept. So if a shape would have been classified as a rectangle in the OO code, it still should be classified as a such.

### A Good Design First

Like I said before, your initial solution should be a well designed solution. Once you have a good solution, you will then destructure the solution to be a mess.

### A Path to Destructuring

With any language there are a **_LOT_** of ways to make ugly code. That does not mean you will want to use them all. Even though this exercise is targeting people who have some experience with refactoring the goal in destructuring is not obfuscation.

The logic I used to decide if a destructuring was going to occur was:

> If I have seen the thought process that would lead to someone typing this code in production then it is okay.

**Example:** In C# I have seen people assign things to lambdas that would be better done as a method. There for destructuring a method to a lambda is okay, even when it makes things really complex and duplicated.

**Counter Example:** I have never met a programmer that wanted to type JavaScript Assembly. Therefore I would not embed JavaScript Assembly in the JavaScript version.
    

## Optimizations and Bug Fixes ##

### Reporting Needed Changes

Please feel free to submit bug reports and change requests as long as they are not requests to add a language. I am recruiting language experts to help with each language so, if you want to add a language, I invite you to do so.

### Bugs

So... If you find a bug in the app code, that is awesome! It now becomes a reason for people to fix it. Please tell me about it, so that I can add it to the documentation.

If you find a bug in the tests, well that is a different issue. Please either report it or fix it and submit a pull request.

### Optimizations / Enhancements

You may find a destructuring that can be done to the app code, a spelling error or other change that would make the exercise better. Please either report it, or make the change (test supported of course) and submit a pull request.
    

<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
    