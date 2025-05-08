using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    internal class ClimbingStairsSolution
    {
        //Bạn đang ở chân cầu thang có n bậc.Mỗi lần bạn có thể bước 1 hoặc 2 bậc.Hỏi có bao nhiêu cách để lên tới bậc thứ n?
        //Input: n = 5
        //Output: 8
        //(Vì có 8 cách để đi từ 0 lên 5)
        //Time Complexity: O(2^n)
        public int ClimbingStairs(int n)
        {
            int result = 0;
            if (n <= 2) return n;

            //ClimbingStairs(n) = ClimbingStairs(n - 1) + ClimbingStairs(n - 2);
            return ClimbingStairs(n - 1) + ClimbingStairs(n - 2);
        }
    }
}
