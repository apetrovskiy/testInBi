import Foundation

class Solution {
    func coverPoints(_ A: inout [Int], _ B: inout [Int]) -> Int {
        var result = 0
        if (A.count < 2 && B.count < 2) {
            return result
        }
        for i in 1...A.count - 1 {
            var diffFirstArray = abs(A[i] - A[i - 1])
            var diffSecondArray = abs(B[i] - B[i])
            result += diffFirstArray > diffSecondArray ? diffFirstArray : diffSecondArray
        }
        return result
    }
}
