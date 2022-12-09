#include <string>

namespace PrintAllLeafNodes {

struct TreeNode {
    int data;
    TreeNode* left;
    TreeNode* right;
};

class Solution {
   public:
    static std::string Run(TreeNode* head) {
        if (head == nullptr) {
            return "";
        }
        if (head->left == nullptr && head->right == nullptr) {
            return std::to_string(head->data);
        }
        auto left = Run(head->left);
        auto right = Run(head->right);
        if (!left.empty() && !right.empty()) {
            left += ",";
        }
        return left + right;
    }
};
}  // namespace PrintAllLeafNodes