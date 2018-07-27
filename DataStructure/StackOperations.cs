using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class StackOperations
    {
        private Stack _Stack;
        private int _Element;

        public StackOperations()
        {
            _Stack = new Stack();
            _Element = 0;
        }

        public void InvokeMethods()
        {
            int choice = 0;
            Console.WriteLine("\t\tStack Operations\n1.Add\n2.Remove\n3.Display\n4.Sort\n5.Top\n6.Exit\nEnter your Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Data : ");
                    _Element = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(_Stack.Add(_Element));
                    InvokeMethods();
                    break;
                case 2:
                    Console.WriteLine(_Stack.Remove());
                    InvokeMethods();
                    break;
                case 3:
                    Console.WriteLine(_Stack.Display());
                    InvokeMethods();
                    break;
                case 4:
                    Console.WriteLine(_Stack.Sort());
                    InvokeMethods();
                    break;
                case 5:
                    _Stack.Top();
                    InvokeMethods();
                    break;
                case 6: 
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    break;
            }
        }
    }
}
