package practice.level01.MinStepsInInfiniteGrid

import org.scalatest.FreeSpec
import org.scalatest._
import org.scalatest.prop.TableDrivenPropertyChecks

class SolutionScalaTest
    extends FreeSpec
    with TableDrivenPropertyChecks
    with Matchers {
  "Cover points" - {
    "should calculate path return true if" - {
      val inputData = Table(
        (Array[Int](-2), Array[Int](7), 0),
        (Array(-7, -13), Array(1, -5), 6),
        (
          Array(4, 8, -7, -5, -13, 9, -7, 8),
          Array(4, -15, -10, -3, -13, 12, 8, -8),
          108
        )
      )

      forAll(inputData) { (firstArray, secondArray, expectedResult) =>
        s"$statement" in {
          new Solution().coverPoints(
            firstArray,
            secondArray,
            expectedResult
          ) shouldBe expectedResult
        }
      }
    }
  }
}
