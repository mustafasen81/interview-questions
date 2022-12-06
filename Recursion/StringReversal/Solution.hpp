#include <string>

namespace StringReversal {
class Solution {
   public:
    static std::string Run(const std::string& str) {
        if (str.size() < 2) {
            return str;
        }
        return Run(str.substr(1)) + str[0];
    }
};
}  // namespace StringReversal