using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList : ICollections
    {
        private Node _Head;

        public LinkedList()
        {
            _Head = null;
        }

        public String Add(int data)
        {
            Node current = new Node();
            Node temp;
            current.Data = data;
            current.Next = null;
            if (_Head == null)
            {
                _Head = current;
            }
            else
            {
                temp = _Head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = current;
            }
            return "-----Data is added to List-----";
        }

        public String Remove()
        {
            if (_Head.Next == null)
                _Head = null;
            else
            {
                Node current = _Head;
                while (current.Next.Next != null)
                    current = current.Next;
                current.Next = null;
            }
            return "----Node is removed from List----";
        } 

        public String Display()
        {
            String list = "";
            if (_Head == null)
                Console.WriteLine("----List is Empty-----");
            else
            {

                list = "----- List : "+ _Head.Data;
                Node current = _Head.Next;
                while (current != null)
                {
                    list += "," + current.Data;
                    current = current.Next;
                }
            }
            return list;
        }

        public String Sort()
        {
            Node current1 = null, current2 = null;
            if (_Head == null)
                return "-----List is Empty-----";
            else
            {
                current1 = _Head;
                while(current1 != null)
                {
                    current2 = current1.Next;
                    while(current2 != null)
                    {
                        if(current1.Data > current2.Data)
                            current1.Data = (current1.Data + current2.Data) - (current2.Data = current1.Data);
                        current2 = current2.Next;
                    }
                    current1 = current1.Next;
                }
            }
            return "LinkedList is Sorted";
        }

        public String AddAtPosition(int data, int position)
        {
            Node current = new Node();
            Node temp;
            current.Data = data;
            current.Next = null;
            if (position == 0)
            {
                current.Next = _Head;
                _Head = current;
            }
            else
            {
                temp = _Head;
                for (int itr = 1; itr < position; itr++)
                    temp = temp.Next;  
                current.Next = temp.Next;
                temp.Next = current;
            }
            return "-----List is Added at Specified Location-----";
        }

        public String RemoveFromPosition(int position)
        {
            if (position == 0)
                _Head = _Head.Next;
            else
            {
                Node current = _Head;
                for (int itr = 1; itr < position; itr++)
                    current = current.Next;
                current.Next = current.Next.Next;
            }
            return "-----List is Removed from Specified Location------";
        }
    }
}