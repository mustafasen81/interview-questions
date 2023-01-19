#include <string>
#include <unordered_map>

namespace LongestCommonSubsequence {
namespace Memoization {
class Solution {
    static std::string Run(std::string_view str1, std::string_view str2,
                           std::unordered_map<std::string, std::string>& memo) {
        std::string key =
            std::to_string(str1.size()) + "-" + std::to_string(str2.size());
        auto memoIt = memo.find(key);
        if (memoIt != memo.end()) {
            return memoIt->second;
        }
        if (str1.empty() || str2.empty()) {
            return "";
        }
        if (str1[0] == str2[0]) {
            auto lcs = Run(str1.substr(1), str2.substr(1), memo);
            lcs = str1[0] + lcs;
            memo.emplace(key, lcs);
            return lcs;
        }
        auto lcs1 = Run(str1.substr(1), str2, memo);
        auto lcs2 = Run(str1, str2.substr(1), memo);
        if (lcs2.size() > lcs1.size()) {
            memo.emplace(key, lcs2);
            return lcs2;
        }
        memo.emplace(key, lcs1);
        return lcs1;
    }

   public:
    static std::string Run(const char* str1, const char* str2) {
        std::unordered_map<std::string, std::string> memo;
        return Run(std::string_view(str1), std::string_view(str2), memo);
    }
};
}  // namespace Memoization
}  // namespace LongestCommonSubsequence