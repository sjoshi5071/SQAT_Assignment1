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

        public void Test_Isoscales()
        {
            Assert.AreEqual("Triangle is isoscales.", TriangleSolver.TriangleType(8,12,8));
        }
        
        public void Test_Scalene()
        {
            Assert.AreEqual("Triangle is equilateral.", TriangleSolver.TriangleType(10, 10, 10));
        }

        public void Test_StringEntered()
        {
            Assert.AreEqual("String entered", TriangleSolver.TriangleType(10,"Hello", "Hi");
        }


        }
    }
}