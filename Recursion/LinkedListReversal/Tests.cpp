#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("LinkedList Reversal tests - Base cases") {
    REQUIRE(LinkedListReversal::Solution::Run(nullptr) == nullptr);

    LinkedListReversal::ListNode single{1, nullptr};
    auto reverse = LinkedListReversal::Solution::Run(&single);
    REQUIRE(reverse == &single);
    REQUIRE(reverse->next == nullptr);
    REQUIRE(reverse->data == 1);
}

TEST_CASE("LinkedList Reversal tests - Two nodes") {
    LinkedListReversal::ListNode* head = new LinkedListReversal::ListNode{
        1, new LinkedListReversal::ListNode{2, nullptr}};

    auto reverse = LinkedListReversal::Solution::Run(head);

    REQUIRE(reverse);
    REQUIRE(reverse->data == 2);
    REQUIRE(reverse->next);
    REQUIRE(reverse->next->data == 1);
    REQUIRE_FALSE(reverse->next->next);
}

TEST_CASE("LinkedList Reversal tests - Multiple nodes") {
    LinkedListReversal::ListNode* head = new LinkedListReversal::ListNode{
        1, new LinkedListReversal::ListNode{
               2, new LinkedListReversal::ListNode{3, nullptr}}};

    auto reverse = LinkedListReversal::Solution::Run(head);

    REQUIRE(reverse);
    REQUIRE(reverse->data == 3);
    REQUIRE(reverse->next);
    REQUIRE(reverse->next->data == 2);
    REQUIRE(reverse->next->next);
    REQUIRE(reverse->next->next->data == 1);
    REQUIRE_FALSE(reverse->next->next->next);
}