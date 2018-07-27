using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Queue : ICollections
    {
        private Node _Front;
        private int _Rear;

        public Queue()
        {
            _Front = null;
            _Rear = -1;
            _Size = 10;
        }

        public int _Size { get; set; }

        public String Add(int element)
        {
            if (IsFull() == 1)
                return "------Queue is Full, so can't add element-------";
            Node current = new Node();
            Node temp;
            current.Data = element;
            current.Next = null;
            if (_Front == null)
            {
                _Front = current;
            }
            else
            {
                temp = _Front;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = current;
            }
            _Rear++;
            return "-----Element is added to Queue-----";
        }

        public String Remove()
        {
            if (IsEmpty() == 1)
                return "------There is no element in Queue to remove, Queue is Empty------";
            _Front = _Front.Next;
            _Rear--;
            return "------Element is Removed from Queue------";
        }

        public String Display()
        {
            String queueElements = "";
            if (IsEmpty() == 1)
                Console.WriteLine("----Queue is Empty-----");
            else
            {

                queueElements = "----- Queue Elements : " + _Front.Data;
                Node current = _Front.Next;
                while (current != null)
                {
                    queueElements += "," + current.Data;
                    current = current.Next;
                }
            }
            return queueElements;
        }

        public String Sort()
        {
            Node current1 = null, current2 = null;
            if (IsEmpty() == 1)
                return "-----Queue is Empty-----";
            else
            {
                current1 = _Front;
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
            return "-----Queue is Sorted-----";
        }

        public void Peek()
        {
            if (IsEmpty() == 0)
                Console.WriteLine("-----Peek : " + _Front.Data);
            else
                Console.WriteLine("-----Queue is Empty-----");
        }

        public int IsFull()
        {
            if (_Rear == _Size - 1)
                return 1;
            return 0;
        }

        public int IsEmpty()
        {
            if (_Front == null)
                return 1;
            return 0;
        }
    }
}