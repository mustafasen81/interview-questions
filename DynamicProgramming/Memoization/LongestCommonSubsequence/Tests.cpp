#include "../../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./MemoizationSolution.hpp"
#include "./RecursiveSolution.hpp"

TEST_CASE("Recursive LCS") {
    REQUIRE(LongestCommonSubsequence::Recursive::Solution::Run("", "") == "");
    REQUIRE(LongestCommonSubsequence::Recursive::Solution::Run("a", "") == "");
    REQUIRE(LongestCommonSubsequence::Recursive::Solution::Run("a", "b") == "");
    REQUIRE(LongestCommonSubsequence::Recursive::Solution::Run("a", "a") ==
            "a");

    REQUIRE(LongestCommonSubsequence::Recursive::Solution::Run("axxb", "ab") ==
            "ab");
    REQUIRE(LongestCommonSubsequence::Recursive::Solution::Run(
                "ABCDGH", "AEDFHR") == "ADH");
    REQUIRE(LongestCommonSubsequence::Recursive::Solution::Run(
                "xxxxxxxxxxAGGTAB", "yyyyyyyyyGXTXAYB") == "GTAB");
}

TEST_CASE("Memoization LCS") {
    REQUIRE(LongestCommonSubsequence::Memoization::Solution::Run("", "") == "");
    REQUIRE(LongestCommonSubsequence::Memoization::Solution::Run("a", "") ==
            "");
    REQUIRE(LongestCommonSubsequence::Memoization::Solution::Run("a", "b") ==
            "");
    REQUIRE(LongestCommonSubsequence::Memoization::Solution::Run("a", "a") ==
            "a");

    REQUIRE(LongestCommonSubsequence::Memoization::Solution::Run("axxb",
                                                                 "ab") == "ab");
    REQUIRE(LongestCommonSubsequence::Memoization::Solution::Run(
                "ABCDGH", "AEDFHR") == "ADH");
    REQUIRE(LongestCommonSubsequence::Memoization::Solution::Run(
                "xxxxxxxxxxAGGTAB", "yyyyyyyyyGXTXAYB") == "GTAB");
}