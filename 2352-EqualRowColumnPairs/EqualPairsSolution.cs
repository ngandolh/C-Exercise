using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2352_EqualRowColumnPairs
{
    internal class EqualPairsSolution
    {
        //Time Complexity: O(n2)
        public int EqualPairs(int[][] grid)
        {
            Dictionary<string, int> rowCount = new Dictionary<string, int>();
            Dictionary<string, int> columnCount = new Dictionary<string, int>();
            int n = grid.Length;
            int result = 0;

            //Adding rows to the dictionary O(n2)
            foreach (var row in grid)
            {
                string rowKey = string.Join(",", row); //O(n)

                if (rowCount.ContainsKey(rowKey))
                {
                    rowCount[rowKey]++;
                }
                else
                {
                    rowCount[rowKey] = 1;
                }
            }

            //Print rowCount
            foreach(var row in rowCount.Keys)
            {
                Console.WriteLine("rowKey: " + row);
            }

            //Adding columns to the dictionary O(n2)
            for (int j = 0; j < n; j++)
            {
                List<int> column = new List<int>();
                for (int k = 0; k < n; k++)
                {
                    column.Add(grid[k][j]);
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

            //Print columnCount
            foreach (var column in columnCount)
            {
                Console.WriteLine("columnCount.Key - column.Value: " + 
                    column.Key + " - " + column.Value);
            }

            //Comparing rows and columns
            foreach (var row in rowCount)
            {
                Console.WriteLine("columnCount.Key - row.Key: " + row.Key);
                if (columnCount.ContainsKey(row.Key))                       //O(n)
                {
                    result += row.Value * columnCount[row.Key]; 
                }
            }

            return result;
        }
    }
}
