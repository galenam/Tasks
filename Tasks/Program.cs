using Tasks.AppCode;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            var source = Console.ReadLine();
            Console.WriteLine(DNACoding.Coding(source));
            Console.ReadLine();
        }
    }
}