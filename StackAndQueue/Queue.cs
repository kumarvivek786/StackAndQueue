using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        public LinkedList linkedlist;

        public Queue()
        {
            this.linkedlist = new LinkedList();
        }
        public void Enqueue(int data)
        {
            linkedlist.append(data);
            Console.WriteLine("{0} pushed to Queue ", data);
        }

        public void print()
        {
            linkedlist.display();
        }

    }
}
