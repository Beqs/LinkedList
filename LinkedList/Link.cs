using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Link
    {

        private Node Head;
        private Node Current;
        public int count;

        public Link ()
        {

            Head = new Node();
            Current = Head;

        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            Current.Next = newNode;
            Current = newNode;
            count++;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            count++;
        }

        public void RemoveFromStart()
        {

            if (count > 0)
            {
                Head.Next = Head.Next.Next;
                Console.WriteLine("Element removed");
                count--;
            }
            else
            {
                Console.WriteLine("The list is empty");
            }
        }

        public void PrintAll()
        {

            Console.Write("Head -> ");
            Node curr = Head;
            while (curr.Next != null)
            {
                {
                    curr = curr.Next;
                    Console.Write(curr.Value);
                    Console.Write(" -> ");
                }
                          
            }
            Console.WriteLine("NULL");
        }
    }

}
