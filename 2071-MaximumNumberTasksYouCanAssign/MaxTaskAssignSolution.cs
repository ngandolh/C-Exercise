using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2071_MaximumNumberTasksYouCanAssign
{
    internal class MaxTaskAssignSolution
    {
        public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
        {
            int result = 0;
            int n = tasks.Length;
            int m = workers.Length;
            Array.Sort(tasks);
            Array.Sort(workers);
            int left = 0;
            int right = Math.Min(n, m);
            while( left < right)
            {
                int mid = left + (right - left) / 2;

            }
        }

        private int CanAssignKTasks(int[] tasks, int[] workers, int pills, int strength)
        {

            return 1;
        }
    }
}
