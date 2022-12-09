#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

using namespace MergeTwoSortedLinkedList;

TEST_CASE("MergeTwoSortedLinkedList tests - Base cases") {
    ListNode A{1, nullptr};

    auto result = Solution::Run(&A, nullptr);
    REQUIRE(result == &A);

    result = Solution::Run(nullptr, &A);
    REQUIRE(result == &A);
}

TEST_CASE("MergeTwoSortedLinkedList tests - Basic cases") {
    auto A = new ListNode{1, new ListNode{10, new ListNode{100, nullptr}}};
    auto B = new ListNode{2, new ListNode{20, new ListNode{200, nullptr}}};
    auto result = Solution::Run(A, B);

    REQUIRE(result);
    REQUIRE(result->data == 1);
    REQUIRE(result->next);
    REQUIRE(result->next->data == 2);
    REQUIRE(result->next->next);
    REQUIRE(result->next->next->data == 10);
    REQUIRE(result->next->next->next);
    REQUIRE(result->next->next->next->data == 20);
    REQUIRE(result->next->next->next->next);
    REQUIRE(result->next->next->next->next->data == 100);
    REQUIRE(result->next->next->next->next->next);
    REQUIRE(result->next->next->next->next->next->data == 200);
    REQUIRE_FALSE(result->next->next->next->next->next->next);
}