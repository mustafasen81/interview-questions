#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("Fibonacci tests - Base cases") {
    REQUIRE(Fibonacci::Solution::Run(1) == 1);
    REQUIRE(Fibonacci::Solution::Run(2) == 1);
}

TEST_CASE("Fibonacci tests - Basic cases") {
    REQUIRE(Fibonacci::Solution::Run(5) == 5);
    REQUIRE(Fibonacci::Solution::Run(10) == 55);
}