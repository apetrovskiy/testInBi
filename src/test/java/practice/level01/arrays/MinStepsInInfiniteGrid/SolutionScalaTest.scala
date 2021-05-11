package practice.level01.arrays.MinStepsInInfiniteGrid

import org.scalatest._
import matchers._
import prop._
import prop.TableDrivenPropertyChecks._
import prop.TableDrivenPropertyChecks.Table

class SolutionScalaTest
     extends propspec.AnyPropSpec
    with TableDrivenPropertyChecks
    with should.Matchers
with GivenWhenThen{
  val inputData = Table // [Array[Int],Array[Int],Int]
  (
    (Array[Int](-2), Array[Int](7), 0),
    (Array[Int](-7, -13), Array[Int](1, -5), 6),
    (
      Array[Int](4, 8, -7, -5, -13, 9, -7, 8),
      Array[Int](4, -15, -10, -3, -13, 12, 8, -8),
      108
    )
  )

   // property("data") {
    /*forAll(inputData)
    {  (firstArray:Array[Int], secondArray:Array[Int], expectedResult:Int) =>
      new SolutionScala().coverPoints(
         firstArray,
         secondArray
      ) should be === expectedResult
    }*/
   // }
}
