using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape.Lib;
using Shape.Lib.Types;

namespace Shape.Tests
{
    [TestClass]
    public class ClassifyLineSegmentShould
    {
        [TestMethod]
        public void ClassifyTwoDifferentPointsAsLineSegment()
        {
            var points = Builder.Build(
                (0, 0), 
                (50, 0)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Line Segment", result.Type);
        }

        [TestMethod]
        public void ClassifyTwoPointsOfTheSameLocationAsOther()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Other", result.Type);
        }
    }
}