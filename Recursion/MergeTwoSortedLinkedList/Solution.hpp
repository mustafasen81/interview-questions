#include <vector>

namespace MergeTwoSortedLinkedList {

struct ListNode {
    int data;
    ListNode* next;
};

class Solution {
   public:
    static ListNode* Run(ListNode* A, ListNode* B) {
        if (A == nullptr) return B;
        if (B == nullptr) return A;

        if (A->data < B->data) {
            A->next = Run(A->next, B);
            return A;
        } else {
            B->next = Run(A, B->next);
            return B;
        }
    }
};
}  // namespace MergeTwoSortedLinkedList