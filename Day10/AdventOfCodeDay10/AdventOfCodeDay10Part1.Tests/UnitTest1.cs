using System.Collections.Generic;
using NUnit.Framework;

namespace AdventOfCodeDay10Part1.Tests
{
    [TestFixture]
    public class Tests
    {
        int result;

        [SetUp]
        public void Setup()
        {
            var joltList = new List<int> {16, 10, 15, 5, 1, 11, 7, 19, 6, 12, 4};

            result = Functions.Execute(joltList);
        }

        [Test]
        public void It_should_be_35() => Assert.AreEqual(35, result);
    }
}