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

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (CanAssignKTasks(mid, tasks, workers, pills, strength))
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        private bool CanAssignKTasks(int k, int[] tasks, int[] workers, int pills, int strength)
        {
            var selectedTasks = tasks.Take(k).ToList();
            var selectedWorkers = workers.Skip(workers.Length - k).ToList(); // cần phải xóa động

            int pillsUsed = 0;

            for (int i = k - 1; i >= 0; i--)
            {
                int task = selectedTasks[i];

                if (selectedWorkers[selectedWorkers.Count - 1] >= task)
                {
                    // công nhân khỏe nhất làm được → pop khỏi danh sách
                    selectedWorkers.RemoveAt(selectedWorkers.Count - 1);
                }
                else
                {
                    // Tìm công nhân yếu nhất mà + strength >= task
                    if (pillsUsed >= pills)
                        return false;

                    int foundIdx = -1;
                    for (int j = 0; j < selectedWorkers.Count; j++)
                    {
                        if (selectedWorkers[j] + strength >= task)
                        {
                            foundIdx = j;
                            break;
                        }
                    }

                    if (foundIdx == -1)
                        return false;

                    // dùng thuốc cho người này
                    selectedWorkers.RemoveAt(foundIdx);
                    pillsUsed++;
                }
            }

            return true;
        }
    }
}
