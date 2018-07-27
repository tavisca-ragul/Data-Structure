using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class QueueOperations
    {
        private Queue _Queue;
        private int _Element, _Size;

        public QueueOperations()
        {
            _Queue = new Queue();
            _Element = 0;
            _Size = 0;
        }

        public void InvokeMethods()
        {
            int choice = 0;
            Console.WriteLine("\t\tQueue Operations\n\tDefault Size for Queue is 10, you can update the size\n1.Add\n2.Remove\n3.Display\n4.Sort\n5.Peek\n6.IsFull\n7.IsEmpty\n8.Update Size\n9.Exit\nEnter your Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Data : ");
                    _Element = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(_Queue.Add(_Element));
                    InvokeMethods();
                    break;
                case 2:
                    Console.WriteLine(_Queue.Remove());
                    InvokeMethods();
                    break;
                case 3:
                    Console.WriteLine(_Queue.Display());
                    InvokeMethods();
                    break;
                case 4:
                    Console.WriteLine(_Queue.Sort());
                    InvokeMethods();
                    break;
                case 5:
                    _Queue.Peek();
                    InvokeMethods();
                    break;
                case 6:
                    if (_Queue.IsFull() == 1)
                        Console.WriteLine("------Queue is Full------");
                    else
                        Console.WriteLine("------Queue is Not full------");
                    InvokeMethods();
                    break;
                case 7:
                    if (_Queue.IsEmpty() == 1)
                        Console.WriteLine("------Queue is Empty------");
                    else
                        Console.WriteLine("------ is Not empty------");
                    InvokeMethods();
                    break;
                case 8:
                    Console.WriteLine("Enter Size : ");
                    _Size = Convert.ToInt32(Console.ReadLine());
                    _Queue._Size = _Size;
                    Console.WriteLine("-----Queue Size is Updated-----");
                    InvokeMethods();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    break;
            }
        }
    }
}
