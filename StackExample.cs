using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleStack
{
    public class StackExample
    {
        Position first;

        public Position StackUp(Object item)
        {
            first = new Position(first, item);
            return first;
        }

        public object Unstack()
        {
            object? result = null;
            if (first is null)
            {
                Console.WriteLine("Pilha Vazia!!!");
            }
            else
            {
                result = first.item;
                first = first.next;
            }

            return result;
        }

        public class Position
        {
            public Position next;
            public object item;

            public Position(Position next, object item)
            {
                this.next = next;
                this.item = item;
            }
        }
    }
}