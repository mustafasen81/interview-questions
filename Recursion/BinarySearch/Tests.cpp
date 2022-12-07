#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("BinarySearch tests - Base cases") {
    REQUIRE(BinarySearch::Solution::Run(std::vector<int>{1, 2, 5}, 2, 1, 4) ==
            -1);
    REQUIRE(BinarySearch::Solution::Run(std::vector<int>{2}, 0, 0, 5) == -1);
    REQUIRE(BinarySearch::Solution::Run(std::vector<int>{2}, 0, 0, 2) == 0);
}

TEST_CASE("BinarySearch tests - Basic cases") {
    REQUIRE(BinarySearch::Solution::Run(std::vector<int>{1, 2, 5, 8, 9}, 0, 4,
                                        4) == -1);
    REQUIRE(BinarySearch::Solution::Run(std::vector<int>{1, 2, 5, 8, 9}, 0, 4,
                                        5) == 2);
}