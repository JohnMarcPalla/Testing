using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Testing
{
    class Class1
    {
        public void simpleFunc(string name)
        {
            Console.WriteLine("Hello, " + name); 
        }
        public void stackIn(object obj, Stack stack)
        {
            stack.Push(obj);
            Console.WriteLine("Successfully pushed object into stack");
        }
        public void stackOut(Stack stack)
        {
            object x = stack.Pop();
            Console.WriteLine("Successfully removed {0} from the stack",x );
        }
        public void stackMove(Stack stackIn, Stack stackOut)
        {
            stackIn.Push(stackOut.Pop());
        }
        public void displayStacks(Stack s1, Stack s2)
        {
            int x = 0;
            Console.WriteLine("Stack 1");
            foreach (var item in s1)
            {
                Console.WriteLine("[{0}] " + item, s1.Count-x);
                x = x+1;
            }
            x = 0;
            Console.WriteLine("\n\nStack 2");
            foreach (var items in s2)
            {
                Console.WriteLine("[{0}] " + items, s2.Count - x);
                x = x + 1;
            }
        }
    }
}
