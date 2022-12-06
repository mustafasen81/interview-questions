#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("String Reversal tests - Base cases") {
    REQUIRE(DecimalToBinary::Solution::Run(0) == "0");
    REQUIRE(DecimalToBinary::Solution::Run(1) == "1");
}

TEST_CASE("String Reversal tests - Basic cases") {
    REQUIRE(DecimalToBinary::Solution::Run(2) == "10");
    REQUIRE(DecimalToBinary::Solution::Run(3) == "11");
    REQUIRE(DecimalToBinary::Solution::Run(8) == "1000");
    REQUIRE(DecimalToBinary::Solution::Run(233) == "11101001");
}