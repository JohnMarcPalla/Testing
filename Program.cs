using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Name: ");
            //new Class1().simpleFunc(Console.ReadLine());
            //Console.ReadLine();
            Stack stack1 = new Stack();
            Stack stack2 = new Stack();
            while (true)
            {
                Console.Write("[1]Push \n[2]Pop\n[3]Display stacks\nChoice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                if (choice == 1)
                {
                    
                    Console.Write("Enter Value to be stored in the Stack: ");
                    object objects = Console.ReadLine();
                    Console.Write("Choose which stack to store: ");
                    int choice1 = int.Parse(Console.ReadLine());
                    if (choice1 == 1)
                    {
                        new Class1().stackIn(objects, stack1);
                        Console.ReadLine();
                    }
                    else if (choice1 == 2)
                    {
                        new Class1().stackIn(objects, stack2);
                        Console.ReadLine();
                    }
                    Console.Clear();                  
                }
                else if (choice == 2)
                {
                    Console.Write("Which stack to be removed?:  ");
                    int choices = int.Parse(Console.ReadLine());
                    if (choices == 1)
                    {
                        new Class1().stackOut(stack1);
                    }
                    else if (choices == 2)
                    {
                        new Class1().stackOut(stack2);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == 3)
                {
                    new Class1().displayStacks(stack1, stack2);
                    Console.ReadLine();
                    Console.Clear();
                }


                Console.Clear();
            }
            
        }
    }
}
