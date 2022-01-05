<!--bl
(filemeta
    (title "What is a Rectangle"))
/bl-->

> Note: A rectangle should only be constructable from the "Classify" method/function. The test cases should not be able to construct it directly.

### A Rectangle should contain the points that constructed it

This will verify that the Rectangle returned from the classification process will grant access to the distinct points form the collection used by the classification process.

### A Rectangle should contain its sides

This will verify that a Rectangle will grant access to the four line segments that form its sides. Such that:

1. Side A - First line segment formed from the first two points provided.
1. Side B - Second line segment formed from the second and third points provided.
1. Side C - Third line segment formed from the third and fourth point provided.
1. Side D - Fourth line segment formed from the fourth and first/fifth point provided.

### A Rectangle should contain its area

This will verify that the rectangle will grant access to its area and its area is calculated correctly.

> Note: the area of a Rectangle can be calculated using this formula: ```(hight)(width)```

### A Rectangle should contain its perimeter

This will verify that the rectangle will grant access to its perimeter and its perimeter is the same as the sum of its side lengths.