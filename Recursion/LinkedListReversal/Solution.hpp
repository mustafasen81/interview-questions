#include <list>

namespace LinkedListReversal {

struct ListNode {
    int data;
    ListNode* next;
};

class Solution {
   public:
    static ListNode* Run(ListNode* head) {
        if (head == nullptr || head->next == nullptr) {
            return head;
        }
        ListNode* reverseHead = Run(head->next);
        head->next->next = head;
        head->next = nullptr;
        return reverseHead;
    }
};
}  // namespace LinkedListReversal