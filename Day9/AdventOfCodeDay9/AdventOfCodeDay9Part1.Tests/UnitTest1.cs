using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace AdventOfCodeDay9Part1.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var input = "35\n" +
                        "20\n" +
                        "15\n" +
                        "25\n" +
                        "47\n" +
                        "40\n" +
                        "62\n" +
                        "55\n" +
                        "65\n" +
                        "95\n" +
                        "102\n" +
                        "117\n" +
                        "150\n" +
                        "182\n" +
                        "127\n" +
                        "219\n" +
                        "299\n" +
                        "277\n" +
                        "309\n" +
                        "576";
            var intList = input.Split("\n").ToList().Select(x => long.Parse(x)).ToList();
            result = Functions.findValue(intList, 5);
        }

        [Test]
        public void It_should_be_127() => Assert.AreEqual(127, result);

        long result;
    }

    [TestFixture]
    public class test_sum_permutations
    {
        List<long> result;

        [OneTimeSetUp]
        public void Setup()
        {
            result = Functions.getSums(new List<long> {1, 1, 2});
        }

        [Test]
        public void It_should_contain_two_elements() => Assert.AreEqual(2, result.Count);

        [Test]
        public void It_should_contain_2() => Assert.IsTrue(result.Contains(2));

        [Test]
        public void It_should_contain_3() => Assert.IsTrue(result.Contains(3));
    }
}