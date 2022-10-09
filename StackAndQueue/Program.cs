using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.push(70);
            //stack.push(30);
            //stack.push(56);
            //stack.print();
            //while (!stack.isEmpty())
            //{
            //    Console.WriteLine();
            //    stack.peek();
            //    stack.pop();
            //    stack.print();
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.print();
            Console.ReadLine();
        }
    }
}
