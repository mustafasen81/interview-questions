#include <string>

namespace LongestCommonSubsequence {
namespace Recursive {
class Solution {
    static std::string Run(std::string_view str1, std::string_view str2) {
        if (str1.empty() || str2.empty()) {
            return "";
        }
        if (str1[0] == str2[0]) {
            auto lcs = Run(str1.substr(1), str2.substr(1));
            return str1[0] + lcs;
        }
        auto lcs1 = Run(str1.substr(1), str2);
        auto lcs2 = Run(str1, str2.substr(1));
        if (lcs2.size() > lcs1.size()) {
            return lcs2;
        }
        return lcs1;
    }

   public:
    static std::string Run(const char* str1, const char* str2) {
        return Run(std::string_view(str1), std::string_view(str2));
    }
};
}  // namespace Recursive
}  // namespace LongestCommonSubsequence