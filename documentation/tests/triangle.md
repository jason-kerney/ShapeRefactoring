<!--bl
(filemeta
    (title "What is a Triangle"))
/bl-->

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

### A Triangle should have the correct area

This will verify that a Triangle will have access to its area which is correctly calculated.

### A Triangle should have the correct perimeter

This will verify that the Triangle will have access to its perimeter which will be equal to the sum of its three side lengths.