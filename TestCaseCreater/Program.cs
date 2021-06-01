using System;
using System.Collections.Generic;

namespace TestCaseCreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mode(detail, simple) >");
            var mode = Console.ReadLine();

            while (true)
            {
                string title = "No titled(simple mode)";
                int id = 0;
                int subId = 0;

                if (mode == "detail")
                {
                    Console.Write("title >");
                    title = Console.ReadLine();


                    Console.Write("Start ID Number from(n-m) >");
                    var idTxt = Console.ReadLine().Split("-");
                    id = int.Parse(idTxt[0]);
                    subId = int.Parse(idTxt[1]);
                }

                Console.Write("Number of Factor >");
                var numOfFactor = int.Parse(Console.ReadLine());

                var valueRanges = new Dictionary<string, List<string>>();
                for (var i = 0; i < numOfFactor; i++)
                {
                    string factorName = $"factor_{i}";
                    if (mode == "detail")
                    {
                        Console.Write($"Factor_{i + 1} Name >");
                        factorName = Console.ReadLine();
                    }

                    Console.Write($"{factorName} Values(Separate by \",\") >");
                    var values = Console.ReadLine();
                    var valueList = new List<string>();
                    valueList.AddRange(values.Split(","));

                    valueRanges.Add(factorName, valueList);
                }


                Console.WriteLine($"- {title} ---------------------");
                var testCases = new TestCases(id, subId, title, valueRanges);
                Console.WriteLine(testCases.ToString());
                Console.WriteLine("----------------------------------\n");

                Console.Write("Exit? (\"Yes\" or else) > ");
                if (Console.ReadLine() == "Yes") break;

            }

            Console.WriteLine("Bye");
        }
    }
}
