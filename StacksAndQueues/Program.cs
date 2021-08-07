using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack And Queue Problem!");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("Original stack is :");
            stack.Display();
            Console.WriteLine("\n"+"Stack after pop operation : ");
            stack.Pop();
            stack.Display();
            stack.Peek();
        }
    }
}
