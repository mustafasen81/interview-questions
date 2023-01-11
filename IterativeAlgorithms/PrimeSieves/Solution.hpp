#include <vector>

namespace PrimeSives {
class Solution {
   public:
    static std::vector<int> Run(int n) {
        std::vector<bool> isPrime;
        isPrime.resize(n + 1, true);
        for (int p = 2; p * p <= n; p++) {
            if (isPrime[p]) {
                for (int i = p * p; i <= n; i += p) {
                    isPrime[i] = false;
                }
            }
        }
        std::vector<int> primes;
        for (int i = 2; i <= n; i++) {
            if (isPrime[i]) {
                primes.push_back(i);
            }
        }
        return primes;
    }
};
}  // namespace PrimeSives