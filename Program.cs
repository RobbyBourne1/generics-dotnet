using System;

namespace generics_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Stacks<int>();
            {
                numbers.Push(2);
                numbers.Push(3);
                Console.WriteLine(numbers.Pop());
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
