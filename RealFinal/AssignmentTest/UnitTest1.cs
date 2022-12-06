using Class_Library_Assignment;
using NUnit.Framework;
using System;
using System.Drawing;
using System.IO;

namespace AssignmentTest
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSequentialSearch()
        {
            string Expected = "Search Student Id found at index : 0";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Class_Library_Assignment.Program.RunSequentialSearch();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [Test]
        public void TestBinarySearch()
        {
            string Expected = "Result is PARK wooleezip4@gmail.com 0475887423 english 12/12 1";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Class_Library_Assignment.Program.RunBinarySearch();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [Test]
        public void TestBubbleSortWithCompareTo()
        {
            string Expected = "Pass!";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Class_Library_Assignment.Program.RunBubbleSortWithCompareTo();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

    }
}