#include <vector>

namespace MergeSort {
class Solution {
    static void Merge(std::vector<int>& arr, int start, int mid, int end) {
        std::vector<int> temp;
        temp.reserve(end - start + 1);

        int i = start, j = mid + 1;
        while (i <= mid && j <= end) {
            if (arr[i] <= arr[j]) {
                temp.push_back(arr[i++]);
            } else {
                temp.push_back(arr[j++]);
            }
        }

        while (i <= mid) {
            temp.push_back(arr[i++]);
        }
        while (j <= end) {
            temp.push_back(arr[j++]);
        }
        std::copy(temp.begin(), temp.end(), arr.begin() + start);
    }

    static void Sort(std::vector<int>& arr, int start, int end) {
        if (start < end) {
            int mid = (start + end) / 2;
            Sort(arr, start, mid);
            Sort(arr, mid + 1, end);
            Merge(arr, start, mid, end);
        }
    }

   public:
    static void Run(std::vector<int>& arr) { Sort(arr, 0, arr.size() - 1); }
};
}  // namespace MergeSort