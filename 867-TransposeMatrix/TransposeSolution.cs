using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _867_TransposeMatrix
{
    internal class TransposeSolution
    {
        public int[][] Transpose(int[][] matrix)
        {
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;
            int[][] result = new int[colCount][];

            for (int i = 0; i < colCount; i++)
            {
                result[i] = new int[rowCount];
                for (int j = 0; j < rowCount; j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }

            return result;
        }
    }
}
