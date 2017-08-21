using System;

namespace generics_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Stacks<int>();
            {
                numbers.Stackable(2);
                numbers.Stackable(3);
                Console.WriteLine(numbers);
            }
        }
    }
}
