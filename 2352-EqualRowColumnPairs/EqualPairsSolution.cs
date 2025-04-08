using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2352_EqualRowColumnPairs
{
    internal class EqualPairsSolution
    {
        public int EqualPairs(int[][] grid)
        {
            Dictionary<string, int> rowCount = new Dictionary<string, int>();
            Dictionary<string, int> columnCount = new Dictionary<string, int>();
            int n = grid.Length;
            int m = grid[0].Length;
            int result = 0;

            //Adding rows to the dictionary 
            foreach (var row in grid)
            {
                string rowKey = string.Join(",", row);
                if (rowCount.ContainsKey(rowKey))
                {
                    rowCount[rowKey]++;
                }
                else
                {
                    rowCount[rowKey] = 1;
                }
                Console.WriteLine(rowKey);
            }

            //Adding columns to the dictionary
            for (int j = 0; j < m; j++)
            {
                List<int> column = new List<int>();
                for (int k = 0; k < m; k++)
                {
                    column.Add(grid[m][j]);
                }
                string columnKey = string.Join(",", column);
                if (columnCount.ContainsKey(columnKey))
                {
                    columnCount[columnKey]++;
                }
                else
                {
                    columnCount[columnKey] = 1;
                }
            }

            //Comparing rows and columns
            foreach (var row in rowCount)
            {
                if (columnCount.ContainsKey(row.Key))
                {
                    result += row.Value * columnCount[row.Key];
                }
            }

            return result;
        }
    }
}
