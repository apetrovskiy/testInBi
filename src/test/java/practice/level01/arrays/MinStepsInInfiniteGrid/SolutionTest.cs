namespace practice.level01.arrays.MinStepsInInfiniteGrid
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
        [TestCase(new int[] { 4, 8, -7, -5, -13, 9, -7, 8 }, new int[] { 4, -15, -10, -3, -13, 12, 8, -8 }, 108)]
        public void TestCoverPoints(int[] firstArray, int[] secondArray, int expectedResult)
        {
            Console.WriteLine(@"{firstArray} {secondArray} {expectedResult}");
            Assert.AreEqual(expectedResult, new Solution().coverPoints(firstArray.ToList(), secondArray.ToList()));
        }
    }
}
