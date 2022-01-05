
<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
# Shape Test Cases #
#### A Guide to Making the Shape Classifier ####

## Table Of Contents ##

- [Section 1: Introduction](#user-content-introduction)
- [Section 2: How to classify](#user-content-how-to-classify)
- [Section 3: What is a Line Segment](#user-content-what-is-a-line-segment)
- [Section 4: What is a Triangle](#user-content-what-is-a-triangle)
- [Section 5: What is a Rectangle](#user-content-what-is-a-rectangle)

## Introduction ##

This is to serve as documentation of the _minimum_ test cases you should have if creating a new language. It details the expected behavior of each shape.

### A note on Paradigm

The way these test cases is written may unintentionally favor an Object Oriented paradigm. If you find that to be true, please understand it is not the intent of this document. Please report it to me, or fix it and submit a pull request.
    

## How to classify ##

### Classify should classify no points as 'Empty'

This will verify that if "classify" is given no points then shape returned is a special case shape called "Empty".

### Classify should classify one point as 'Point'

This will verify that if a single point is given then a single point is returned.

Optionally, this can verify that it has the same value as the point given. However, if not done in this test then a separate test needs to be written to verify this. Different languages handle this differently so I leave it to the writer's discretion.

### Classify should classify two different points as 'Line Segment'

This will verify if given two different points a "Line Segment" is returned.

### Classify should classify the two points that are in the same location as 'Other'

This will verify that given two points that are in the same location then the shape returned is a special condition shape called "Other".

### Classify should classify four points where the first three are distinct and different points, but the first and last are the same as 'Triangle'

This will verify if given points that meet the following criteria that a "Triangle" is returned.

1. There are four points.
1. The shape is closed. (The first point and last point are in the same location.)
1. Each of the first three points are different.

> Note: This is the first time we are testing a "closed" shape. A closed shape is one where the first and last point are in the same location, thereby creating a line segment from the last logical point to the first.

### Classify should classify four points where all points are distinct as 'Other'

This will verify that if we have an "open" shape, then the shape returned is the special case shape called "Other".

### Classify should classify four points that form a closed shape with duplicate locations as 'Other'

This will verify that if we have a closed shape that has one or more of the first three points duplicated that it will return the special case shape called "Other".

### Classify should classify a closed shape with five points where the first four are distinct and every three points forms right angles as a 'Rectangle'

This will verify that if the points meet the following conditions a "Rectangle" is returned.

1. There are five points.
1. The points form a closed shape.
1. The first four are distinct and different.
1. Every two adjoining line segments form a 90 degree angle.

### Classify should classify five points that form an open shape as 'Other'

This test will verify that if given an open shape composed of five distinct and different points that the special case shape called "Other" is returned.

### Classify should classify five points that form a closed shape but have repeating points as 'Other'

This test will verify that if give a closed shape with five points, but the first four have duplication in the location then it will return the special case shape "Other".

### Classify should classify five points that form a closed shape, but do not form right angles as 'Other'

This will verify that if given a shape where the adjoining legs do not form right angle even when it is a closed shape of five points that the special case shape "Other" is returned.
    

## What is a Line Segment ##

> Note: A line segment should only be constructable from the "Classify" method/function. The test cases should not be able to construct it directly.

### A Line Segment should contain the points that constructed it

This will verify that the line segment returned from the classification process gives access to the points that define it.

### A Line Segment should contain its length

This will verify that a line segment will have access to the correct length based on the points that were given.

> Note: Length is determined by the absolute value of the following formula: ```√((x₁ - x₂)² + (y₁ - y₂)²)```

### A Line Segment should contain its slope

This will verify that a line segment will have access to the correct slope based on the points that were given.

> Note: The slope is determined by the following formula: ```(y₂ - y₁)/(x₂ - x₁)```

### A Line Segment should have a slope of "Undefined" if both points are on the same x value

This will verify that a line that is straight on the x value will have an undefined slope.
    

## What is a Triangle ##

> Note: A triangle should only be constructable from the "Classify" method/function. The test cases should not be able to construct it directly.

### A Triangle should contain the points that constructed it

This will verify that a triangle returned from the classification process will have access to the first three distinct points that were given to the process.

### A Triangle should have three legs which are line segments constructed from the points

This will verify that the Triangle will have access to three line segments forming its sides. The Sides will have the names:

- Side A
- Side B
- Side C

### A Triangle should have the correct angles

This will verify that the Triangle will have the expected angles such that:

1. "Angle A" is opposite "Side A"
1. "Angle B" is opposite "Side B"
1. "Angle C" is opposite "Side C"
1. All angles add up to 180 degrees.
1. The degrees of each angle is correctly calculated.

> Note: The angle in degrees can be calculated using the following formula:

```console
A = length of Side A
B = length of Side B
C = length of Side C

∠A = ((B² + C² - A²) / (2BC))(180/π)
∠B = ((A² + C² - B²) / (2AC))(180/π)
∠C = ((A² + B² - C²) / (2AB))(180/π)
```

### A Triangle should have the correct area

This will verify that a Triangle will have access to its area which is correctly calculated.

> Note: The area of a triangle can be calculated using Heron's Formula. (Thanks to [omnicalculator](https://www.omnicalculator.com/math/triangle-area)).

```console
A = length of Side A
B = length of Side B
C = length of Side C

area = ¼√((A + B + C)(-A + B + C)(A - B + C)(A + B - C))
```

### A Triangle should have the correct perimeter

This will verify that the Triangle will have access to its perimeter which will be equal to the sum of its three side lengths.
    

## What is a Rectangle ##

> Note: A rectangle should only be constructable from the "Classify" method/function. The test cases should not be able to construct it directly.

### A Rectangle should contain the points that constructed it

This will verify that the Rectangle returned from the classification process will have access the distinct points form the collection used by the classification process.

### A Rectangle should contain its sides

This will verify that a Rectangle will have access to the four line segments that form its sides. Such that:

1. Side A - First line segment formed from the first two points provided.
1. Side B - Second line segment formed from the second and third points provided.
1. Side C - Third line segment formed from the third and fourth point provided.
1. Side D - Fourth line segment formed from the fourth and first/fifth point provided.

### A Rectangle should contain its area

This will verify that the rectangle has access to its area and its area is calculated correctly.

> Note: the area of a Rectangle can be calculated using this formula: ```(hight)(width)```

### A Rectangle should contain its perimeter

This will verify that the rectangle has access to its perimeter and its perimeter is the same as the sum of its side lengths.
    

<!-- GENERATED DOCUMENT! DO NOT EDIT! -->
    