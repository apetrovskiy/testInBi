from src.main.java.practice.level01.arrays.MinStepsInInfiniteGrid.solution \
    import Solution
import pytest

# from nose.tools import assert_equal

# import unittest
# from unittest import TestCase
# from parameterized import parameterized
# import parameterized
# from parameterized import parameterized, parameterized_class


# unittest
# class SolutionTest(TestCase):
# @parameterized.expand(
#     [[-2], [7], 0], [[-7, -13], [1, -5], 6]
# )

# nose
# @parameterized([
#     ([-2], [7], 0), ([-7, -13], [1, -5], 6)
# ])

@pytest.mark.parametrize(
    "input_x,input_y,expected_result",
    [
        ([-2], [7], 0), ([-7, -13], [1, -5], 6),
        ([4, 8, -7, -5, -13, 9, -7, 8],
         [4, -15, -10, -3, -13, 12, 8, -8], 108),
    ],
)
def test_solution_min_steps_in_grid(
        input_x: int, input_y: int, expected_result: int):
    # TODO: make it really working
    # self.assertEqual(expected_result,
    # Solution().coverPoints(input_x, input_y))
    # assert_equal(expected_result,
    # Solution().coverPoints(input_x, input_y))
    assert expected_result == Solution().coverPoints(input_x, input_y)


# if __name__ == '__main__':
#     unittest.main()
