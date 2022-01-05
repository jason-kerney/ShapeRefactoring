<!--bl
(filemeta
    (title "How to classify"))
/bl-->

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