<!--bl
(filemeta
    (title "Changes that need to be made"))
/bl-->

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