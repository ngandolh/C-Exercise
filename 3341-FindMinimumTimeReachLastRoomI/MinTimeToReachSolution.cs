using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3341_FindMinimumTimeReachLastRoomI
{
    internal class MinTimeToReachSolution
    {
        public int MinTimeToReach(int[][] moveTime)
        {
            int n = moveTime.Length, m = moveTime[0].Length;
            var time = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    time[i, j] = int.MaxValue;

            var pq = new PriorityQueue<(int x, int y), int>();
            time[0, 0] = 0;
            pq.Enqueue((0, 0), 0);

            int[] dx = { 0, 0, 1, -1 };
            int[] dy = { 1, -1, 0, 0 };

            while (pq.Count > 0)
            {
                var (x, y) = pq.Dequeue();
                int t = time[x, y];
                if (x == n - 1 && y == m - 1)
                    return t;

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i], ny = y + dy[i];
                    if (nx >= 0 && nx < n && ny >= 0 && ny < m)
                    {
                        int nt = Math.Max(t + 1, moveTime[nx][ny]);
                        if (nt == moveTime[nx][ny])
                            nt++;  // ⬅️ xử lý đặc biệt: cửa mở đúng lúc thì phải đợi 1 giây

                        if (nt < time[nx, ny])
                        {
                            time[nx, ny] = nt;
                            pq.Enqueue((nx, ny), nt);
                        }
                    }
                }
            }

            return -1;
        }
    }
}
