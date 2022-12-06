#include <string>

namespace Palindrome {
class Solution {
   public:
    static bool Run(const std::string& str) {
        if (str.size() < 2) {
            return true;
        }
        if (str.front() == str.back()) {
            return Run(str.substr(1, str.size() - 2));
        }
        return false;
    }
};
}  // namespace Palindrome