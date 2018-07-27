using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            userInput:
            Console.WriteLine("1.LinkedList\n2.Stack\n3.Queue\n4.Exit\nEnter your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    LinkedListOperations listOperations = new LinkedListOperations();
                    listOperations.InvokeMethods();
                    goto userInput;
                case 2:
                    StackOperations stackOperations = new StackOperations();
                    stackOperations.InvokeMethods();
                    goto userInput;
                case 3:
                    QueueOperations queueOperations = new QueueOperations();
                    queueOperations.InvokeMethods();
                    goto userInput;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong choice, please try again");
                    goto userInput;
            }
        }
    }
}