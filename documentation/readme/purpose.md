<!--bl
(filemeta
    (title "Purpose of Code"))
/bl-->

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