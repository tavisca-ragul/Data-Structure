using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedListOperations
    {
        private LinkedList _List;
        private int _Data, _Position;
        public LinkedListOperations()
        {
            _List = new LinkedList();
            _Data = 0;
            _Position = 0;
        }
        public void InvokeMethods()
        {
            int choice = 0;
            Console.WriteLine("\t\tLinkedList Operations\n1.Add\n2.Remove\n3.Display\n4.Sort\n5.Insert at the Specific Location\n6.Remove from the specific Location\n7.Exit\nEnter your Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Data : ");
                    _Data = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(_List.Add(_Data));
                    InvokeMethods();
                    break;
                case 2:
                    Console.WriteLine(_List.Remove());
                    InvokeMethods();
                    break;
                case 3:
                    Console.WriteLine(_List.Display());
                    InvokeMethods();
                    break;
                case 4:
                    Console.WriteLine(_List.Sort());
                    InvokeMethods();
                    break;
                case 5:
                    Console.WriteLine("Enter Data : ");
                    _Data = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Position (index starts from 0): ");
                    _Position = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(_List.AddAtPosition(_Data, _Position));
                    InvokeMethods();
                    break;
                case 6:
                    Console.WriteLine("Enter Position (index starts from 0) : ");
                    _Position = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(_List.RemoveFromPosition(_Position));
                    InvokeMethods();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    break;
            }
        }
    }
}