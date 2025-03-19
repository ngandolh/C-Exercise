using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _374_GuessNumberHigherOrLower
{
    public class GuessNumberSolution
    {
        //guess(int num) is a function provided by the API
        public int GuessNumber(int n)
        {
            int left = 1, right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int result = guess(mid);

                if (result == 0) return mid;
                else if (result == -1) right = mid - 1;
                else if (result == 1) left = mid + 1;
            }
            return -1;
        }
    }
}
