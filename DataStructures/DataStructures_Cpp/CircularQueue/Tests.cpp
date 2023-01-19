#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("Prime Sieves Test") {
    REQUIRE(PrimeSives::Solution::Run(2) == std::vector<int>{2});
    REQUIRE(PrimeSives::Solution::Run(3) == std::vector<int>{2, 3});
    REQUIRE(PrimeSives::Solution::Run(30) ==
            std::vector<int>{2, 3, 5, 7, 11, 13, 17, 19, 23, 29});
    REQUIRE(PrimeSives::Solution::Run(100) ==
            std::vector<int>{2,  3,  5,  7,  11, 13, 17, 19, 23, 29, 31, 37, 41,
                             43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97});
}
