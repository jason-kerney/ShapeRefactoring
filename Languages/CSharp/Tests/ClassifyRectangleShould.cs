using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape.Lib;
using Shape.Lib.Types;

namespace Shape.Tests
{
    [TestClass]
    public class ClassifyRectangleShould
    {
        [TestMethod]
        public void ClassifyFivePointsWhereFirstFourAreDistinctAndLastOneMatchesFirstAndAllAnglesAreRightAsRectangle()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 4),
                (3, 4),
                (3, 0),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Rectangle", result.Type);
        }

        [TestMethod]
        public void ClassifyFiveDistinctPointsAsOther()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 4),
                (3, 4),
                (3, 0),
                (0, 1)
            );

            var results = Classifier.Classify(points);
            Assert.AreEqual("Other", results.Type);
        }

        [TestMethod]
        public void ClassifyFivePointsWhereFirstFourHaveRepeatsAsOther()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 3),
                (0, 0),
                (3, 3),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Other", result.Type);
        }

        [TestMethod]
        public void ClassifySixPointsWithRepeatInFirstFiveAndLastAndFirstAreSameAsOther()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 5),
                (4, 5),
                (4, 0),
                (4, 5),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Other", result.Type);
        }

        //[Ignore("Need line Segment to have length")]
        [TestMethod]
        public void ClassifyFivePointsThatDoNotFormRightAnglesAsOther()
        {
            var points = Builder.Build(
                (0, 0),
                (1, 4),
                (3, 4),
                (3, 1),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Other", result.Type);
        }
    }
}