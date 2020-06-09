using System;
using System.Threading;

namespace CSharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();

            
        }
    }
}
