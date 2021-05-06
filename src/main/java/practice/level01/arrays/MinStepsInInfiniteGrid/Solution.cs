namespace practice.level01.MinStepsInInfiniteGrid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int coverPoints(List<int> A, List<int> B)
        {
            var result = 0;
            if (A.Count() < 2 && B.Count() < 2)
                return result;
            result = Enumerable.Range(1, A.Count() - 1)
                .Select(index =>
                {
                    var diffInFirstArray = Math.Abs(A[index] - A[index - 1]);
                    var diffInSecondArray = Math.Abs(B[index] - B[index - 1]);
                    return diffInFirstArray > diffInSecondArray ? diffInFirstArray : diffInSecondArray;

                })
                .Sum();
            return result;
        }
    }
}
