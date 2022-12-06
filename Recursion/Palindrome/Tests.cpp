#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("Palindrome tests - Base cases") {
    REQUIRE(Palindrome::Solution::Run(""));
    REQUIRE(Palindrome::Solution::Run("x"));
}

TEST_CASE("Palindrome tests - Positive cases") {
    REQUIRE(Palindrome::Solution::Run("asa"));
    REQUIRE(Palindrome::Solution::Run("axsxa"));
}

TEST_CASE("Palindrome tests - Negative cases") {
    REQUIRE_FALSE(Palindrome::Solution::Run("as"));
    REQUIRE_FALSE(Palindrome::Solution::Run("axsa"));
}