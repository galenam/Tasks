using System.Collections.Immutable;
using Tasks.AppCode;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the task number:");
            var taskNumber = Console.ReadLine();
            if (int.TryParse(taskNumber, out var task))
            {
                switch (task)
                {
                    case 1:
                        var array = GetListFromConsole();
                        if (array.Count == 0)
                        {
                            return;
                        }

                        PrintList(SortedSquares.GetSortedSquares(array));
                        break;
                    case 2:
                        var arrayEquivalent = GetListFromConsole();
                        if (arrayEquivalent.Count == 0)
                        {
                            return;
                        }

                        Console.WriteLine($"index = {SumEquivalent.SumWithMinimumDifference(arrayEquivalent)}");
                        break;
                    default:
                        Console.WriteLine("Enter the DNA string");
                        var source = Console.ReadLine();
                        Console.WriteLine(DNACoding.Coding(source));
break;
                }
            }
            Console.ReadLine();
        }

        static void PrintList(IReadOnlyList<int> list)
        {
            foreach (var l in list)
            {
                Console.Write($"{l} ");
            }
            Console.WriteLine();
        }
        
        static IReadOnlyList<int> GetListFromConsole()
        {
            Console.WriteLine("Enter the array for squares. Blank is a delimiter");
            var arrayString = Console.ReadLine();
            try
            {
                var split = arrayString?.Split(' ');
                if (split != null)
                {
                    var array = split
                        .Select(int.Parse)
                        .ToList();
                    return array;
                }
            }
            finally{}

            return ImmutableList<int>.Empty;
        }
    }
}