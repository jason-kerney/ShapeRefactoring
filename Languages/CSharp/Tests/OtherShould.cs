using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape.Lib;
using Shape.Lib.Types;

namespace Shape.Tests
{
    [TestClass]
    public class OtherShould
    {
        private static (dynamic[], dynamic) GetOther(params (double, double)[] coords)
        {
            var points = Builder.Build(coords);

            return (points, Classifier.Classify(points));
        }
        
        [TestMethod]
        public void ContainThePointsThatConstructedIt()
        {
            var (points, result) = GetOther(
                (0, 0),
                (0, 0)
            );

            CollectionAssert.AreEquivalent(points, (ICollection)result.Points);
        }

        [TestMethod]
        public void ContainsPointsWhenThereAreFourDistinctPoints()
        {
            var (points, result) = GetOther(
                (0, 0),
                (0, 5),
                (3, 5), 
                (0, 1)
            );
            
            CollectionAssert.AreEquivalent(points, (ICollection)result.Points);
        }

        [TestMethod]
        public void ContainsPointsForOpenShapeWithDuplicatePoints()
        {
            var (points, result) = GetOther(
                (0, 0),
                (0, 5),
                (0, 0),
                (0, 1)
            );
            
            CollectionAssert.AreEquivalent(points, (ICollection)result.Points, $"{result.Type}");
        }

        [TestMethod]
        public void KnowClosedShapeIsClosedAndNotOpen()
        {
            var (_, result) = GetOther(
                (0, 0),
                (0, 3),
                (3, 3),
                (0, 0),
                (-3, 0),
                (-3, -3),
                (0, 0)
            );
            
            Assert.IsTrue(result.IsClosed, "Closed");
            Assert.IsFalse(result.IsOpen, "Open");
        }

        [TestMethod]
        public void KnowOpenShapeIsOpenAndNotClosed()
        {
            var (_, result) = GetOther(
                (0, 0),
                (0, 3),
                (3, 3),
                (0, 0),
                (-3, 0),
                (-3, -3)
            );
            
            Assert.IsTrue(result.IsOpen, "Open");
            Assert.IsFalse(result.IsClosed, "Closed");
        }

        [TestMethod]
        public void CalculateTheLengthOfAShapeWIthThreePoints()
        {
            var (_, result) = GetOther(
                (0, 0),
                (0, 3),
                (3, 3)
            );
            
            Assert.AreEqual(6, result.Length, 0.001);
        }

        [TestMethod]
        public void CalculateTheLengthOfAShape()
        {
            var (_, result) = GetOther(
                (0, 0),
                (0, 3),
                (3, 3),
                (3, 0),
                (0, 0),
                (-3, 0),
                (-3, -3)
            );
            
            Assert.AreEqual(18, result.Length, 0.001);
        }
    }
}