using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace AdventOfCodeDay8Part1.Tests
{
    [TestFixture]
    public class Tests
    {
        int count;

        [SetUp]
        public void Setup()
        {
            var instructions = "nop +0\n" +
                               "acc +1\n" +
                               "jmp +4\n" +
                               "acc +3\n" +
                               "jmp -3\n" +
                               "acc -99\n" +
                               "acc +1\n" +
                               "jmp -4\n" +
                               "acc +6\n";
            count = Functions.Execute(instructions.Split("\n").ToList());
        }

        [Test]
        public void It_should_be_5() => Assert.AreEqual(5, count);
    }
}