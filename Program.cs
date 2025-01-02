using LeetCode;
using Newtonsoft.Json;
using System.Numerics;
using System.Text.Json.Serialization;

TwoSumSolution twoSumSolution = new TwoSumSolution();

Console.WriteLine(JsonConvert.SerializeObject(twoSumSolution.TwoSum([-3, 4, 3, 90], 0)) + " == [0,2]");