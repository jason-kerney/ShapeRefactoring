<!--bl
(filemeta
    (title "What is a Line Segment"))
/bl-->

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