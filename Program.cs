using LeetCode;
using Newtonsoft.Json;
using System.Numerics;
using System.Text.Json.Serialization;

DailyTemperaturesSolution solution = new DailyTemperaturesSolution();

Console.WriteLine(JsonConvert.SerializeObject(solution.DailyTemperatures([10, 10, 10, 10, 11])));