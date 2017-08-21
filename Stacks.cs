using System;
using System.Collections.Generic;

namespace generics_dotnet
{
    public class Stacks <T>
    {
        private IList<T> StackList = new List<T>();

        public void Stackable(T item)
        {
            this.StackList.Add(item);
        }
    }
}