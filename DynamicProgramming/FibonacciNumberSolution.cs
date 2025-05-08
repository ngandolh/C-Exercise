using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    internal class FibonacciNumberSolution
    {
        public int FibonacciNumber(int n)
        {
            if (n <= 1) return n;

            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }
    }
}
