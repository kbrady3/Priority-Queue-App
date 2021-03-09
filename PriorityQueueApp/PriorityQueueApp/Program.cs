using System;
using System.Collections.Generic;

namespace PriorityQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start with 100 customers in a List.
            List<Node> customerList = new List<Node>();

            //In a loop, generate 100 customers with priorities between 1 - 5, add each customer to the queue.
            for(int i = 0; i < 100; i++)
            {
                Random randomGenerator = new Random();
                int rand = randomGenerator.Next(1, 5);
                customerList.Add(new Node("Customer" + i, rand));
            }

            PriorityQueue pq = new PriorityQueue(100);

            foreach(Node n in customerList)
            {
                pq.Enqueue(n);
            }

            //In a second loop, print the custumers in order of priority(highest priority first).
            Console.WriteLine(pq.Print());
        }
    }
}
