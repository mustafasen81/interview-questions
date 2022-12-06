
namespace Fibonacci {
class Solution {
   public:
    static int Run(int n) {
        if (n < 3) {
            return 1;
        }
        return Run(n - 1) + Run(n - 2);
    }
};
}  // namespace Fibonacci