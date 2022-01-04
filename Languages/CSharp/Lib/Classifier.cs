using System.Collections.Generic;

namespace Shape.Lib
{
    public static class Classifier
    {
        public static dynamic Classify(IReadOnlyList<dynamic> points)
        {
            return Utils.SortingHat(points);
        }
    }
}
