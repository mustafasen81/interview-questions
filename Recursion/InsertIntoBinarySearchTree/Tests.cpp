#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

TEST_CASE("InsertIntoBinarySearchTree tests - Base cases") {
    auto head = InsertIntoBinarySearchTree::Solution::Run(nullptr, 5);

    REQUIRE(head);
    REQUIRE(head->data == 5);
    REQUIRE_FALSE(head->left);
    REQUIRE_FALSE(head->right);
}

TEST_CASE("LinkedList Reversal tests - Insert to left") {
    auto head = InsertIntoBinarySearchTree::Solution::Run(nullptr, 5);

    head = InsertIntoBinarySearchTree::Solution::Run(head, 2);
    REQUIRE(head);
    REQUIRE(head->data == 5);
    REQUIRE(head->left);
    REQUIRE(head->left->data == 2);
    REQUIRE_FALSE(head->left->left);
    REQUIRE_FALSE(head->left->right);
    REQUIRE_FALSE(head->right);
}

TEST_CASE("LinkedList Reversal tests - Insert to right") {
    auto head = InsertIntoBinarySearchTree::Solution::Run(nullptr, 5);

    head = InsertIntoBinarySearchTree::Solution::Run(head, 7);
    REQUIRE(head);
    REQUIRE(head->data == 5);
    REQUIRE_FALSE(head->left);
    REQUIRE(head->right);
    REQUIRE(head->right->data == 7);
    REQUIRE_FALSE(head->right->left);
    REQUIRE_FALSE(head->right->right);
}