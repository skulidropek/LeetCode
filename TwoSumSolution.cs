using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for(int x = 0; x < nums.Length; x++)
            {
                for(int y = x + 1; y < nums.Length; y++) 
                {
                    if (nums[x] + nums[y] == target)
                    {
                        return [x, y];
                    }
                }
            }
            return [];
        }
    }
}
