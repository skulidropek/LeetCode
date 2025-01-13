using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SearchMatrixSolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int row = 0, col = matrix[0].Length - 1;

            while (row < matrix.Length && col >= 0)
            {
                if (matrix[row][col] == target)
                    return true;

                if (matrix[row][col] > target)
                    col--; 
                else
                    row++;
            }

            return false;
        }
    }
}
