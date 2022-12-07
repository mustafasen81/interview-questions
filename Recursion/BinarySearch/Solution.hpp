
#include <vector>

namespace BinarySearch {
class Solution {
   public:
    static int Run(const std::vector<int>& A, int left, int right, int n) {
        if (left > right) {
            return -1;
        }

        int mid = (left + right) / 2;
        if (A[mid] == n) {
            return mid;
        }

        if (n < A[mid]) {
            return Run(A, left, mid - 1, n);
        }
        return Run(A, mid + 1, right, n);
    }
};
}  // namespace BinarySearch