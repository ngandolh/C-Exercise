using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _790_DominoandTrominoTiling
{
    internal class NumTilingsSolution
    {
        public int NumTilings(int n)
        {
            const int MOD = 1000000007;

            if (n == 0) return 1;
            if (n == 1) return 1;
            if (n == 2) return 2;

            long[] dp = new long[n + 1];
            long[] g = new long[n + 1];

            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;

            g[0] = 0;
            g[1] = 0;
            g[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2] + 2 * g[i - 1]) % MOD;
                g[i] = (g[i - 1] + dp[i - 2]) % MOD;
            }

            return (int)dp[n];



        }
    }
}
