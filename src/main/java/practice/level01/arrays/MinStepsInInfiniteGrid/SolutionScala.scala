package practice.level01.MinStepsInInfiniteGrid

class Solution {
  def coverPoints(A: Array[Int], B: Array[Int]): Int = {
    var result = 0
    if (A.size < 2 && B.size < 2)
      result
    for (i <- 1 until A.size) {
      val diffFirstArray = Math.abs(A(i) - A(i - 1))
      val diffSecondArray = Math.abs(B(i) - B(i - 1))
      if (diffFirstArray > diffSecondArray) {
        result += diffFirstArray
      } else {
        result += diffSecondArray
      }
    }
    result
  }
}
