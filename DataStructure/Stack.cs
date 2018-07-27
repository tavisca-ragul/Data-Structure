using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure 
{
    class Stack : ICollections
    {
        private Node _Top;

        public Stack()
        {
            _Top = null;
        }

        public String Add(int element)
        {
            Node current = new Node();
            current.Data = element;
            current.Next = null;
            if (_Top == null)
            {
                _Top = current;
            }
            else
            {
                current.Next = _Top;
                _Top = current;
            }
            return "-----Element is added to Stack-----";
        }

        public String Remove()
        {
            if (_Top == null)
                return "------There is no element in Stack to remove, Stack is Empty------";
            _Top = _Top.Next;
            return "------Element is Removed from Stack------";
        }

        public String Display()
        {
            String stackElements = "";
            if (_Top == null)
                Console.WriteLine("----Stack is Empty-----");
            else
            {

                stackElements = "----- Stack Elements : " + _Top.Data;
                Node current = _Top.Next;
                while (current != null)
                {
                    stackElements += "," + current.Data;
                    current = current.Next;
                }
            }
            return stackElements;
        }

        public String Sort()
        {
            Node current1 = null, current2 = null;
            if (_Top == null)
                return "-----Stack is Empty-----";
            else
            {
                current1 = _Top;
                while (current1 != null)
                {
                    current2 = current1.Next;
                    while (current2 != null)
                    {
                        if (current1.Data > current2.Data)
                            current1.Data = (current1.Data + current2.Data) - (current2.Data = current1.Data);
                        current2 = current2.Next;
                    }
                    current1 = current1.Next;
                }
            }
            return "LinkedList is Sorted";
        }

        public void Top()
        {
            if (_Top == null)
                Console.WriteLine("-----Stack is Empty-----");
            else
                Console.WriteLine("Top : " + _Top.Data);
        }
    }
}
