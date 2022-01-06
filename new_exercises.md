
<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
# How to add an Exercise #

## Table Of Contents ##

- [Section 1: Intention of Design](#user-content-intention-of-design)
- [Section 2: The Basics](#user-content-the-basics)
- [Section 3: Setting up Gittey](#user-content-setting-up-gittey)
- [Section 4: How to Document](#user-content-how-to-document)
- [Section 5: Document's Required Sections](#user-content-document's-required-sections)

## Intention of Design ##

This exercise has two main intents:

1. Take a long time to complete
2. Have many different ways to complete it

This guide will walk you through how to create a new exercise so that your pull request will be easier.
    

## The Basics ##

### A Note

Remembering the intent with adding an exercise, I ask that you do not look at any of the current solutions. I do not want the exercise for every language to look like every other language.

Instead the goal is to use the best aspects of your language to recreate the desired behavior but having the solution be a language native solutions.

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
    

## Setting up Gittey ##

Gittey is heavily part of the ecosystem of these exercises so it is impoatant to have Gittey configured correctly.

### Gittey Config File

It is worth reading the [Gittey documentation](https://github.com/cmstead/gittey/blob/main/README.md) as this document will only discuss the parts that pertain directly to what is needed for exercises.

There need to be a number aliases defined for Gittey, but most of these can be copied from any other Gittey config.

- test
  - This will be different in your exercise as it will run what ever command is used to test the code. It needs to start with ```cls;``` followed by your command and then it then needs to have ```&& gittey commit``` appended to the end of it.
- check
  - Again this one will be different. It needs to start with ```cls;``` followed by your test command.
- undo
  - Copy this command as it is the same no matter what.
- docs
  - Copy this command as it is the same no matter what.
- setup
  - This command will be different for each exercise. Its intent is to setup the directory for work with the assumption that any requirements are already installed on a machine. It should start with ```cls;``` followed by whatever command is needed to setup the directory.
- shrink
  - this will be different depending on exercise. This command removes any objects that are not user code. The idea is to make the directory small enough to be shared by a zip or other file archiving application.
    

## How to Document ##

This project uses Book Lisp to generate documentation, which makes some things easier while adding a small amount of complexity. It is worth reading the [Book Lisp Documentation](https://github.com/cmstead/booklisp/blob/master/README.md).

### Main.md is Everything

This project uses the ```main.md``` file to control the flow of the resulting readme document. You can look at any main document to see how it is laid out or read the Book Lisp documentation.

### The Documentation Directory

The documentation directory is where the pieces of documentation that get compiled into the final readme sit. In this directory, you will find the ```main.md``` and all other markdown documents that represent sections of the document.

This directory should reside at the same level as the gittey config file. Which should be the root directory for the exercise.
    

## Document's Required Sections ##

There are a number of sections that are required for any exercise. These are there to ensure that the information that is nessesary is readily availible via a readme.

They also follow in the order provided.

### Introduction

Just copy the ```intro.md``` file and edit it if necessary.

### Requirements

This section explains what requirements are needed for some one to work on the exercise. It should contain links to any software that should be required.

> Note: Do not put suggestions here, only strict requirements.

### Setup

Just copy the ```setup.md``` as the Gittey config should be configured so that every exercise's setup is the same.

### Run the Tests

Just copy the ```run.md``` as the Gittey config should be configured so that everyone's experience is the same.

### Changes that need to be made

Just copy the ```new.md``` file. Edit it for any variance that happened due to your implementation.
    

<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
    