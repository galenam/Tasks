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
                                PrintList(SortedSquares.GetSortedSquares(array));
                            }
                        }
                        finally{}
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
    }
}