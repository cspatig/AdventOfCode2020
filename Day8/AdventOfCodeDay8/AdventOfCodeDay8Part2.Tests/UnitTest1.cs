using System.Linq;
using NUnit.Framework;

namespace AdventOfCodeDay8Part2.Tests
{
    [TestFixture]
    public class Tests
    {
        int count;

        [SetUp]
        public void Setup()
        {
            var input = "nop +0\n" +
                        "acc +1\n" +
                        "jmp +4\n" +
                        "acc +3\n" +
                        "jmp -3\n" +
                        "acc -99\n" +
                        "acc +1\n" +
                        "jmp -4\n" +
                        "acc +6";
            count = Functions.ExecuteReplaced(input.Split("\n").ToList());
        }

        [Test]
        public void It_should_be_8() => Assert.AreEqual(8, count);
    }
}