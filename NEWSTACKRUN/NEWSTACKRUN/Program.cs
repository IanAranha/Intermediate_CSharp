using System;
using System.Collections;
using System.Collections.Generic;

namespace NEWSTACKRUN
{
    public class Stack
    {
        private ArrayList _stack = new ArrayList();

        public void Push(Object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("Cannot push null into list.");
            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            var lastElement = _stack[_stack.Count - 1];
            _stack.Remove(lastElement);
            return lastElement;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var stack = new Stack();
            stack.Push(1);
            stack.Push("Foo");
            stack.Push("Bar");
            stack.Push("Hello World");
            stack.Push(DateTime.Now);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
            //stack.Push(null);

        }
    }
}
