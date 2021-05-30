using System;
using System.Collections.Generic;

namespace TestCaseCreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("title >");
            var title = Console.ReadLine();

            Console.Write("Start ID Number from(n-m) >");
            var idTxt = Console.ReadLine().Split("-");
            var id = int.Parse(idTxt[0]);
            var subId = int.Parse(idTxt[1]);

            Console.Write("Number of Factor >");
            var numOfFactor = int.Parse(Console.ReadLine());

            var valueRanges = new Dictionary<string, List<string>>();
            for (var i = 0; i < numOfFactor; i++)
            {
                Console.Write($"Factor_{i + 1} Name >");
                var factorName = Console.ReadLine();

                Console.Write("Values(Separate \",\")");
                var values = Console.ReadLine();
                var valueList = new List<string>();
                valueList.AddRange(values.Split(","));

                valueRanges.Add(factorName, valueList);
            }


            Console.WriteLine("\n----------------------");
            var testCases = new TestCases(id, subId, title, valueRanges);
            Console.WriteLine(testCases.ToString());

            Console.WriteLine("done");
        }
    }
}
