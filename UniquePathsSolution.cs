using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class UniquePathsSolution
    {
        public int UniquePaths(int m, int n)
        {
            if (m <= 1) return 1;

            int totalSteps = m + n - 2;
            int downSteps = m - 1;
            long result = 1;

            for (int i = 1; i <= downSteps; i++)
            {
                result = result * (totalSteps - downSteps + i) / i;
            }

            return (int)result;
        }
    }
}
