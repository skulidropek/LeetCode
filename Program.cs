using LeetCode;
using Newtonsoft.Json;
using System.Linq;
using System.Numerics;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

SearchMatrixSolution solution = new SearchMatrixSolution();

var array = new int[][] { [1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30] };
int target = 11;

Console.WriteLine(solution.SearchMatrix(array, target) + " == " + Regex.IsMatch(JsonConvert.SerializeObject(array), $"(?<!\\d){target}(?!\\d)"));