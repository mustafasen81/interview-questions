#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("Merge sort tests - Base cases") {
    std::vector<int> empty{};
    MergeSort::Solution::Run(empty);
    REQUIRE_THAT(empty, Catch::Matchers::Equals(std::vector<int>{}));

    std::vector<int> single{5};
    MergeSort::Solution::Run(single);
    REQUIRE_THAT(single, Catch::Matchers::Equals(std::vector<int>{5}));
}

TEST_CASE("Merge sort tests - Basic cases") {
    std::vector<int> smallArr{3, 2};
    MergeSort::Solution::Run(smallArr);
    REQUIRE_THAT(smallArr, Catch::Matchers::Equals(std::vector<int>{2, 3}));

    std::vector<int> sortedSmallArr{1, 2, 3};
    MergeSort::Solution::Run(sortedSmallArr);
    REQUIRE_THAT(sortedSmallArr,
                 Catch::Matchers::Equals(std::vector<int>{1, 2, 3}));

    std::vector<int> sortedArr{1, 2, 3, 4, 5};
    MergeSort::Solution::Run(sortedArr);
    REQUIRE_THAT(sortedArr,
                 Catch::Matchers::Equals(std::vector<int>{1, 2, 3, 4, 5}));

    std::vector<int> arr{5, 3, 6, 8, 1, 5, 8};
    MergeSort::Solution::Run(arr);
    REQUIRE_THAT(
        arr, Catch::Matchers::Equals(std::vector<int>{1, 3, 5, 5, 6, 8, 8}));
}