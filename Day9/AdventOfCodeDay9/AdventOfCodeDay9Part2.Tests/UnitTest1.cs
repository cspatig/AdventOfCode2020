using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace AdventOfCodeDay9Part2.Tests
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
            var longList = input.Split("\n").ToList().Select(x => long.Parse(x)).ToList();
            computeResult = Functions.compute(longList, 127);
            sumResult = Functions.sumSmallLarge(computeResult);
        }

        [Test]
        public void It_should_have_4_elements() => Assert.AreEqual(4, computeResult.Count);

        [Test]
        public void It_should_contain_15() => Assert.True(computeResult.Contains(15));

        [Test]
        public void It_should_contain_25() => Assert.True(computeResult.Contains(25));

        [Test]
        public void It_should_contain_47() => Assert.True(computeResult.Contains(47));

        [Test]
        public void It_should_contain_40() => Assert.True(computeResult.Contains(40));

        [Test]
        public void It_should_sum_to_62() => Assert.AreEqual(62, sumResult);

        List<long> computeResult;
        long sumResult;
    }

    [TestFixture]
    public class testSubCompute
    {
        List<long> result;

        [OneTimeSetUp]
        public void Setup()
        {
            var testList = new List<long> {1, 1, 2, 3};
            result = Functions.subCompute(testList, 0, 2);
        }

        [Test]
        public void It_should_have_2_elements() => Assert.AreEqual(2, result.Count);

        [Test]
        public void It_should_have_1_as_the_first_element() => Assert.AreEqual(1, result.First());

        [Test]
        public void It_should_have_1_as_the_second_element() => Assert.AreEqual(1, result.Last());
    }
    
    [TestFixture]
    public class testSubComputeNoResult
    {
        List<long> result;

        [OneTimeSetUp]
        public void Setup()
        {
            var testList = new List<long> {1, 1, 2, 3};
            result = Functions.subCompute(testList, 0, 8);
        }

        [Test]
        public void It_should_have_0_elements() => Assert.AreEqual(0, result.Count);
        
    }
}