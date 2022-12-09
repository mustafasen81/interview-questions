#include <memory>
#include <set>
#include <vector>

namespace DepthFirstSearch {

struct Node {
    int data;
    std::vector<Node*> neighbors;
};

class Solution {
    static bool Run(Node* head, int data, std::set<Node*>& visitedNodes) {
        if (head == nullptr) {
            return false;
        }
        if (head->data == data) {
            return true;
        }

        for (auto n : head->neighbors) {
            if (visitedNodes.find(n) != visitedNodes.end()) {
                continue;
            }
            visitedNodes.insert(n);

            if (Run(n, data, visitedNodes)) {
                return true;
            }
        }
        return false;
    }

   public:
    static bool Run(Node* head, int data) {
        std::set<Node*> visitedNodes;
        return Run(head, data, visitedNodes);
    }
};
}  // namespace DepthFirstSearch