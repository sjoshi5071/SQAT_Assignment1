using NUnit.Framework;
using Assignment1;

namespace Tests
    
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Equilateral()
        {
            Assert.AreEqual("Triangle is equilateral.", TriangleSolver.TriangleType(10,10,10));
        }
        [Test]
        public void Test_Isoscales()
        {
            Assert.AreEqual("Triangle is isoscales.", TriangleSolver.TriangleType(8,12,8));
        }
        [Test]
        public void Test_Scalene()
        {
            Assert.AreEqual("Triangle is scalene.", TriangleSolver.TriangleType(8, 9, 10));
        }
        [Test]
        public void Test_ZeroEntered()
        {
            Assert.AreEqual("Zero entered", TriangleSolver.TriangleType(10, 0, 7));

        }
        [Test]
        public void Test_NegativeEntered()
        {
            Assert.AreEqual("Negative entered", TriangleSolver.TriangleType(10, -1, 7));

        }
        [Test]
        public void Test_Character()
        {
            Assert.AreEqual("String entered", TriangleSolver.TriangleType(10, 0, *));

        }
        [Test]
        public void Test_NegativeZero()
        {
            Assert.AreEqual("One negative and one Zero length added", TriangleSolver.TriangleType(10, -1, 0));

        }

        [Test]
        public void Test_ThreeZero()
        {
            Assert.AreEqual("Triangler not formed", TriangleSolver.TriangleType(0, 0, 0));

        }
    }
}