using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _96_UniqueBST
{
    public class UniqueBSTSolution
    {
        public int NumTrees(int n)
        {
            int result = (int)(BinomialCoeff(2 * n, n)/ (n + 1));
            return result;
        }

        //Formula for Binomial Coefficient
        public long BinomialCoeff(int n, int k)
        {
            long res = 1;
            for (int i = 1; i <= k; i++)
            {
                res = res * (n - i + 1)/i ;
            }
            return res;
        }
    }
}
