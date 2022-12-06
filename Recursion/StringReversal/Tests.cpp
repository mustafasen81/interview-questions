#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("String Reversal tests - Base cases") {
    REQUIRE(StringReversal::Solution::Run("") == "");
    REQUIRE(StringReversal::Solution::Run("x") == "x");
}

TEST_CASE("String Reversal tests - Basic cases") {
    REQUIRE(StringReversal::Solution::Run("hello") == "olleh");
}