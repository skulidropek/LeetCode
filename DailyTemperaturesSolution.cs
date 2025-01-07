using Newtonsoft.Json.Linq;
using System.Numerics;

namespace LeetCode
{
    public class DailyTemperaturesSolution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] result = new int[temperatures.Length];
            Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();

            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek().Value <= temperatures[i])
                    stack.Pop();

                if (stack.Count > 0)
                    result[i] = stack.Peek().Key - i;

                stack.Push(new KeyValuePair<int, int>(i, temperatures[i]));
            }

            return result;
        }
    }
}