using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape.Lib;
using Shape.Lib.Types;

namespace Shape.Tests
{
    [TestClass]
    public class TriangleShould
    {
        [TestMethod]
        public void ContainTheDistinctPointsThatConstructedIt()
        {
            var p1 = Builder.Build(0, 0);
            var p2 = Builder.Build(0, 5);
            var p3 = Builder.Build(3, 5);

            var result = Classifier.Classify(new[] { p1, p2, p3, p1 });
            
            Assert.AreEqual(p1, result.P1);
            Assert.AreEqual(p2, result.P2);
            Assert.AreEqual(p3, result.P3);
        }

        [TestMethod]
        public void ContainDifferentPointsItsConstructedWith()
        {
            var p1 = Builder.Build(60, 90);
            var p2 = Builder.Build(-1, 5);
            var p3 = Builder.Build(-50, -5);

            var result = Classifier.Classify(new[] { p1, p2, p3, p1 });
            
            Assert.AreEqual(p1, result.P1);
            Assert.AreEqual(p2, result.P2);
            Assert.AreEqual(p3, result.P3);
        }

        [TestMethod]
        public void HaveLegLengthsOfThreeFourFive()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 3),
                (4, 3),
                (0, 0)
            );
        
            var result = Classifier.Classify(points);
        
            Assert.AreEqual("Line Segment", result.SideA.Type);
            Assert.AreEqual("Line Segment", result.SideB.Type);
            Assert.AreEqual("Line Segment", result.SideC.Type);
        
            Assert.AreEqual(3, result.SideA.Length, 0.001);
            Assert.AreEqual(4, result.SideB.Length, 0.001);
            Assert.AreEqual(5, result.SideC.Length, 0.001);
            
            Assert.IsFalse(result.SideA.Slope.IsSome, "SideA.Slope.IsSome");
            
            Assert.IsTrue(result.SideB.Slope.IsSome, "SideB.Slope.IsSome");
            Assert.AreEqual(0, result.SideB.Slope.Value, 0.001);
            
            Assert.IsTrue(result.SideC.Slope.IsSome, "SideC.Slope.IsSome");
            Assert.AreEqual(0.75, result.SideC.Slope.Value, 0.001);
        }

        [TestMethod]
        public void HaveLegLengthsOfTwelveSixteenTwenty()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 12),
                (16, 12),
                (0, 0)
            );
        
            var result = Classifier.Classify(points);
        
            Assert.AreEqual("Line Segment", result.SideA.Type);
            Assert.AreEqual("Line Segment", result.SideB.Type);
            Assert.AreEqual("Line Segment", result.SideC.Type);
        
            Assert.AreEqual(12, result.SideA.Length, 0.001);
            Assert.AreEqual(16, result.SideB.Length, 0.001);
            Assert.AreEqual(20, result.SideC.Length, 0.001);
            
            Assert.IsFalse(result.SideA.Slope.IsSome, "SideA.Slope.IsSome");
            
            Assert.IsTrue(result.SideB.Slope.IsSome, "SideA.Slope.IsSome");
            Assert.AreEqual(0, result.SideB.Slope.Value, 0.001);
            
            Assert.IsTrue(result.SideC.Slope.IsSome, "SideC.Slope.IsSome");
            Assert.AreEqual(0.75, result.SideC.Slope.Value, 0.001);
        }

        [TestMethod]
        public void HaveAnglesRightTriangleOfThreeFourFive()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 3),
                (4, 3),
                (0, 0)
            );
        
            var result = Classifier.Classify(points);
            
            Assert.AreEqual(36.87, result.AngleA.Degrees, 0.001);
            Assert.AreEqual(53.13, result.AngleB.Degrees, 0.001);
            Assert.AreEqual(90, result.AngleC.Degrees, 0.001);
        }

        [TestMethod]
        public void CorrectlyHandleThirtySixtyNinetyTriangle()
        {
            const double a = 3.0;
            var b = a * Math.Sqrt(3);
            var points = Builder.Build(
                (a, 0),
                (0, 0),
                (0, b),
                (a, 0)
            );

            var result = Classifier.Classify(points);
            
            Assert.AreEqual(a, result.SideA.Length, 0.001);
            Assert.AreEqual(b, result.SideB.Length, 0.001);
            Assert.AreEqual(2 * a, result.SideC.Length, 0.001);
            
            Assert.IsTrue(result.SideA.Slope.IsSome, "SideA.Slope.IsSome");
            Assert.AreEqual(0, result.SideA.Slope.Value, 0.001);
            
            Assert.IsFalse(result.SideB.Slope.IsSome, "SideB.Slope.IsSome");
            
            Assert.IsTrue(result.SideC.Slope.IsSome, "SideC.Slope.IsSome");
            Assert.AreEqual(-1.732, result.SideC.Slope.Value, 0.001);
            
            Assert.AreEqual(30, result.AngleA.Degrees, 0.001);
            Assert.AreEqual(60, result.AngleB.Degrees, 0.001);
            Assert.AreEqual(90, result.AngleC.Degrees, 0.001);
            
            Assert.AreEqual(7.794, result.Area, 0.001);
        }

        [TestMethod]
        public void CorrectlyHandleFirstAndLastPointOnSameX()
        {
            
            var points = Builder.Build(
                (1, 0),
                (0, 0),
                (1, 2),
                (1, 0)
            );

            var result = Classifier.Classify(points);
            
            Assert.AreEqual(1, result.SideA.Length, 0.001);
            Assert.AreEqual(2.236, result.SideB.Length, 0.001);
            Assert.AreEqual(2, result.SideC.Length, 0.001);
            
            Assert.IsTrue(result.SideA.Slope.IsSome, "SideA.Slope.IsSome");
            Assert.AreEqual(0, result.SideA.Slope.Value, 0.001);
            
            Assert.IsTrue(result.SideB.Slope.IsSome, "SideB.Slope.IsSome");
            Assert.AreEqual(2, result.SideB.Slope.Value, 0.001);
            
            Assert.IsFalse(result.SideC.Slope.IsSome, "SideC.Slope.IsSome");
            
            Assert.AreEqual(26.565, result.AngleA.Degrees, 0.001);
            Assert.AreEqual(90, result.AngleB.Degrees, 0.001);
            Assert.AreEqual(63.434, result.AngleC.Degrees, 0.001);
            
            Assert.AreEqual(1, result.Area, 0.001);
        }

        [TestMethod]
        public void CorrectlyHandleFortyFiveFortyFiveNinetyTriangle()
        {
            const double change = 3;
            const double x = 0;
            const double y = 0;
            var points = Builder.Build(
                (x, y),
                (x + change, y),
                (x + change, change + y),
                (x, y)
            );

            var result = Classifier.Classify(points);
            
            Assert.AreEqual(45, result.AngleA.Degrees, 0.001);
            Assert.AreEqual(45, result.AngleB.Degrees, 0.001);
            Assert.AreEqual(90, result.AngleC.Degrees, 0.001);
            Assert.AreEqual(4.5, result.Area, 0.001);
        }

        [TestMethod]
        public void CalculateTheAreaOfEquilateralTriangle()
        {
            const double a = 16;
            var p1 = Builder.Build(0, 0);
            var p2 = Builder.Build(a, 0);
            var p3 = Builder.Build(a / 2.0, (Math.Sqrt(3) * a) / 2.0);

            var result = Classifier.Classify(new[] { p1, p2, p3, p1 });
            
            Assert.AreEqual(110.851, result.Area, 0.001);
        }

        [TestMethod]
        public void CalculateAreaOfThreeFourFiveTriangle()
        {
            var points = Builder.Build(
                (0, 0),
                (0, 3),
                (4, 3),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            
            Assert.AreEqual(6, result.Area, 0.001);
        }

        [TestMethod]
        public void CalculateThePerimeterOfAnEquilateralTriangle()
        {
            const double a = 16;
            var points = Builder.Build(
                (0, 0),
                (a, 0),
                (a / 2.0, (Math.Sqrt(3) * a) / 2.0),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            
            Assert.AreEqual(a * 3, result.Perimeter, 0.001);
        }

        [TestMethod]
        public void CalculateThePerimeterOfThreeFourFiveTriangle()
        {
            var points = Builder.Build(
                (0, 0),
                (3, 0),
                (3, 4),
                (0, 0)
            );

            var result = Classifier.Classify(points);
            
            Assert.AreEqual(12, result.Perimeter, 0.001);
        }
    }
}