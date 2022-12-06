#include <string>

namespace DecimalToBinary {
class Solution {
   public:
    static std::string Run(int decimal) {
        if (decimal == 0) {
            return "0";
        }
        if (decimal == 1) {
            return "1";
        }

        std::string bin = "0";
        if (decimal % 2 == 1) {
            bin = "1";
        }

        return Run(decimal / 2) + bin;
    }
};
}  // namespace DecimalToBinary