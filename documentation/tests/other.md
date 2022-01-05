<!--bl
(filemeta
    (title "What is the Other shape"))
/bl-->

> Note: The other shape should only be constructable from the "Classify" method/function. The test cases should not be able to construct it directly.

### Other should contain the points that constructed it

This will verify that the Other shape returned from the classification process contains all points used by the classification process in classifying it as other.

### Other should know a closed shape is not an open one

This will verify that the Other shape will grant access to knowing if the shape is closed or open such that:

1. A closed shape is one where the first and last point are in the same location.

### Other should know an open shape is not a closed one

This will verify that the Other shape will grant access to knowing if the shape is open or closed such that:

1. A closed shape is one where the first and last point are in the same location.

### Other should have a length

This will verify that the Other shape will grant access to its length and its length will be the sum of all lines segments constructed from its points.