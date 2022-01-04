using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape.Lib;
using Shape.Lib.Types;

namespace Shape.Tests
{
    [TestClass]
    public class RectangleShould
    {
        private static (dynamic[] points, dynamic result) GetRectangle(double x, double y, double height, double length)
        {
            var points = Builder.Build(
                (x, y),
                (x + height, y),
                (x + height, y + length),
                (x, y + length),
                (x, y)
            );

            var result = Classifier.Classify(points);
            return (points, result);
        }

        private static void CheckRectangle(Random random, Action<dynamic, double, double, double, double, IReadOnlyList<dynamic>> check)
        {
            var length = random.NextDouble() * 100;
            var height = random.NextDouble() * 100;
            var x = random.NextDouble() * 10;
            var y = random.NextDouble() * 10;

            var (points, result) = GetRectangle(x, y, height, length);

            check(result, x, y, height, length, points);
        }
        
        [TestMethod]
        public void ContainTheDistinctPointsThatCreatedIt()
        {
            var (points, result) = GetRectangle(0, 0, 3, 4);
            
            Assert.AreEqual(points[0], result.P1);
            Assert.AreEqual(points[1], result.P2);
            Assert.AreEqual(points[2], result.P3);
            Assert.AreEqual(points[3], result.P4);
        }

        [TestMethod]
        public void ContainLineSegments()
        {
            var random = new Random();

            void Check(dynamic result, double x, double y, double height, double length, IReadOnlyList<dynamic> points)
            {
                Assert.AreEqual("Line Segment", result.SideA.Type, $"A x: {x}, y:{y}, height:{height}, length: {length}");
                Assert.AreEqual(points[0], result.SideA.P1, $"A.P1 x: {x}, y:{y}, height:{height}, length: {length}");
                Assert.AreEqual(points[1], result.SideA.P2, $"A.P2 x: {x}, y:{y}, height:{height}, length: {length}");
            
                Assert.AreEqual("Line Segment", result.SideB.Type, $"B x: {x}, y:{y}, height:{height}, length: {length}");
                Assert.AreEqual(points[1], result.SideB.P1, $"B.P1 x: {x}, y:{y}, height:{height}, length: {length}");
                Assert.AreEqual(points[2], result.SideB.P2, $"B.P2 x: {x}, y:{y}, height:{height}, length: {length}");
            
                Assert.AreEqual("Line Segment", result.SideC.Type, $"C x: {x}, y:{y}, height:{height}, length: {length}");
                Assert.AreEqual(points[2], result.SideC.P1, $"C.P1 x: {x}, y:{y}, height:{height}, length: {length}");
                Assert.AreEqual(points[3], result.SideC.P2, $"C.P2 x: {x}, y:{y}, height:{height}, length: {length}");
            
                Assert.AreEqual("Line Segment", result.SideD.Type, $"D x: {x}, y:{y}, height:{height}, length: {length}");
                Assert.AreEqual(points[3], result.SideD.P1, $"D.P1 x: {x}, y:{y}, height:{height}, length: {length}");
                Assert.AreEqual(points[0], result.SideD.P2, $"D.P2 x: {x}, y:{y}, height:{height}, length: {length}");
            }

            for (var i = 0; i < 100; i++)
            {
                CheckRectangle(random, Check);
            }
        }

        [TestMethod]
        public void CalculatesArea()
        {
            var random = new Random();

            void Check(dynamic result, double x, double y, double height, double length, IReadOnlyList<dynamic> points)
            {
                Assert.AreEqual(height * length, result.Area, 0.001, $"l: {length}, h: {height}, x:{x}, y: {y}");
            }

            for (var i = 0; i < 100; i++)
            {
                CheckRectangle(random, Check);
            }
        }

        [TestMethod]
        public void CalculatePerimeter()
        {
            var random = new Random();

            void Check(dynamic result, double x, double y, double height, double length, IReadOnlyList<dynamic> points)
            {
                Assert.AreEqual(2 * (height + length), result.Perimeter, 0.001, $"l: {length}, h: {height}, x:{x}, y: {y}");
            }

            for (var i = 0; i < 100; i++)
            {
                CheckRectangle(random, Check);
            }
        }
    }
}