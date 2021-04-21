class Solution:
    # @param A : list of integers
    # @param B : list of integers
    # @return an integer
    def coverPoints(self, A, B):
        result = 0
        if len(A) < 2 and len(B) < 2:
            return result
        for i in range(1, len(A)):
            a_diff = abs(A[i] - A[i - 1])
            b_diff = abs(B[i] - B[i - 1])
            if a_diff > b_diff:
                result += a_diff
            else:
                result += b_diff
        return result
