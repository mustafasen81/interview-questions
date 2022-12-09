namespace InsertIntoBinarySearchTree {

struct TreeNode {
    int data;
    TreeNode* left;
    TreeNode* right;
};

class Solution {
   public:
    static TreeNode* Run(TreeNode* head, int data) {
        if (head == nullptr) {
            head = new TreeNode{data, nullptr, nullptr};
            return head;
        }
        if (data < head->data) {
            head->left = Run(head->left, data);
        } else {
            head->right = Run(head->right, data);
        }
        return head;
    }
};
}  // namespace InsertIntoBinarySearchTree