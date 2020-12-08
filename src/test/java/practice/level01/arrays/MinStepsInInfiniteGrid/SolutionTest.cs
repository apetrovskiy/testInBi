namespace practice.level01.MinStepsInInfiniteGrid
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestPlatform.Utilities;
    using NUnit.Framework;

    public class SolutionTest
    {
        private Solution cut;

        [SetUp]
        public void SetUp()
        {
            cut = new Solution();
        }

        [TestCase(new int[] { -2 }, new int[] { 7 }, 0)]
        [TestCase(new int[] { -7, -13 }, new int[] { 1, -5 }, 6)]
        public void TestCoverPoints(int[] firstArray, int[] secondArray, int expectedResult)
        {
            Console.WriteLine(@"{firstArray} {secondArray} {expectedResult}");
            Assert.AreEqual(expectedResult, new Solution().coverPoints(firstArray.ToList(), secondArray.ToList()));
        }
    }
}
