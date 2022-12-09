#include <iostream>

#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

using namespace DepthFirstSearch;

TEST_CASE("DepthFirstSearch tests - Base cases") {
    auto result = Solution::Run(nullptr, 5);
    REQUIRE_FALSE(result);

    auto head = new Node{5};
    result = Solution::Run(head, 5);
    REQUIRE(result);
}

TEST_CASE("DepthFirstSearch tests - Two layers") {
    auto head = new Node{5, {new Node{3}, new Node{4}, new Node{7}}};
    auto result = Solution::Run(head, 7);
    REQUIRE(result);

    result = Solution::Run(head, 1);
    REQUIRE_FALSE(result);
}

TEST_CASE("DepthFirstSearch tests - Multiple layers") {
    auto head = new Node{
        5,
        {new Node{3}, new Node{4, {new Node{11}, new Node{12}, new Node{15}}},
         new Node{7}}};
    auto result = Solution::Run(head, 7);
    REQUIRE(result);

    result = Solution::Run(head, 1);
    REQUIRE_FALSE(result);
}

TEST_CASE("DepthFirstSearch tests - Multiple layers, cyclic") {
    auto head = new Node{
        5,
        {new Node{3}, new Node{4, {new Node{11}, new Node{12}, new Node{15}}},
         new Node{7}}};

    head->neighbors[0]->neighbors.push_back(head);
    auto result = Solution::Run(head, 7);
    REQUIRE(result);

    result = Solution::Run(head, 1);
    REQUIRE_FALSE(result);
}