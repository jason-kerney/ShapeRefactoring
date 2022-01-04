using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape.Lib;
using Shape.Lib.Types;

namespace Shape.Tests
{
    [TestClass]
    public class ClassifyBasicsShould
    {
        [TestMethod]
        public void ClassifyAnEmptyArrayAsEmpty()
        {
            var points = Builder.Build();
            var result = Classifier.Classify(points);

            Assert.AreEqual("Empty", result.Type);
        }

        [TestMethod]
        public void ClassifyASinglePointAsPoint()
        {
            var point = Builder.Build(0, 0);
            var points = new[] { point };
            var result = Classifier.Classify(points);
            
            Assert.AreEqual("Point", result.Type);
            Assert.AreEqual(point.X, result.X);
            Assert.AreEqual(point.Y, result.Y);
            Assert.AreEqual(point, result);
        }
    }
}
