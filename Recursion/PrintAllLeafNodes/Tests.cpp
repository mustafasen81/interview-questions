#include "../../3rdParty/Catch2/src/catch2/catch_all.hpp"
#include "./Solution.hpp"

using namespace PrintAllLeafNodes;

TEST_CASE("PrintAllLeafNodes tests - Base cases") {
    auto str = Solution::Run(nullptr);
    REQUIRE(str == "");

    auto head = new TreeNode{5, nullptr, nullptr};
    str = Solution::Run(head);

    REQUIRE(str == "5");
}

TEST_CASE("PrintAllLeafNodes tests - Print left leaf") {
    auto head = new TreeNode{5, new TreeNode{2, nullptr, nullptr}, nullptr};
    auto str = Solution::Run(head);

    REQUIRE(str == "2");
}

TEST_CASE("PrintAllLeafNodes tests - Print righ leaf") {
    auto head = new TreeNode{5, nullptr, new TreeNode{7, nullptr, nullptr}};
    auto str = Solution::Run(head);

    REQUIRE(str == "7");
}

TEST_CASE("PrintAllLeafNodes tests - Print both leaves") {
    auto head = new TreeNode{5, new TreeNode{2, nullptr, nullptr},
                             new TreeNode{7, nullptr, nullptr}};
    auto str = Solution::Run(head);

    REQUIRE(str == "2,7");

    head = new TreeNode{
        5, new TreeNode{2, nullptr, new TreeNode{3, nullptr, nullptr}},
        new TreeNode{7, new TreeNode{6, nullptr, nullptr}, nullptr}};
    str = Solution::Run(head);

    REQUIRE(str == "3,6");
}

TEST_CASE("PrintAllLeafNodes tests - Print multiple leaves") {
    auto head = new TreeNode{5,
                             new TreeNode{2, new TreeNode{1, nullptr, nullptr},
                                          new TreeNode{3, nullptr, nullptr}},
                             new TreeNode{7, new TreeNode{6, nullptr, nullptr},
                                          new TreeNode{8, nullptr, nullptr}}};

    auto str = Solution::Run(head);

    REQUIRE(str == "1,3,6,8");
}