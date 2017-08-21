using System;
using System.Collections.Generic;
using System.Linq;

namespace generics_dotnet
{
    public class Stacks <T>
    {
        private IList<T> StackList = new List<T>();

        public void Push(T item)
        {
            StackList.Add(item);
            Console.WriteLine(item);
        }

        public T Pop()
        {
            var item = StackList.Last();
            this.StackList.Remove(item);
            return item;
        }
    }
}