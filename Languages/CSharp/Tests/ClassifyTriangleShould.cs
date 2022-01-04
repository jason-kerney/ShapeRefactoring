using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape.Lib;
using Shape.Lib.Types;

namespace Shape.Tests
{
    [TestClass]
    public class ClassifyTriangleShould
    {
        [TestMethod]
        public void ClassifyFourPointsWhereTheFirstThreeAreUniqueAndLastAndFirstAreTheSameAsTriangle()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 5),
                (3, 5),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Triangle", result.Type);
        }

        [TestMethod]
        public void ClassifyFourPointsWhereFirstAndLastAreDifferentAsOther()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 5),
                (3, 5),
                (0, 1)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Other", result.Type);
        }

        [TestMethod]
        public void ClassifyFourPointsWhereFirstThreeAreNotUniqueAsOther()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 5),
                (0, 5),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            Assert.AreEqual("Other", result.Type);
        }
    }
}