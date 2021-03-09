using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueueApp
{
    public class Node
    {
        public string customer;
        public int priority;

        public Node() { }

        public Node(string customer, int priority)
        {
            this.customer = customer;
            this.priority = priority;
        }
    }
}
