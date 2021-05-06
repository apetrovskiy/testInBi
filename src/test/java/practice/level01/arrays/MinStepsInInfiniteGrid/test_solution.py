import pytest
from src.main.java.practice.level01.arrays.MinStepsInInfiniteGrid.solution \
    import Solution


test_data = [
        ([-2], [7], 0), ([-7, -13], [1, -5], 6),
        ([4, 8, -7, -5, -13, 9, -7, 8],
         [4, -15, -10, -3, -13, 12, 8, -8], 108)
]


@pytest.mark.parametrize("input_x,input_y,expected_result", test_data)
def test_solution_min_steps_in_grid(
        input_x: int, input_y: int, expected_result: int):
    assert expected_result == Solution().coverPoints(input_x, input_y)
