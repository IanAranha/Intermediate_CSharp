using System;

namespace StackExercise
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                var stack = new Stack();

                while(true)
                {
                    Console.Clear();
                    Console.WriteLine("Current stack count {0}.", stack.StackCounter());
                    Console.WriteLine("1. Push valid object into stack.");
                    Console.WriteLine("2. Remove top object from stack.");
                    Console.WriteLine("3. Clear the stack.");
                    Console.WriteLine("4. Push null object into stack.");
                    Console.WriteLine("\n Chose a menu option or any other key to quit.");
                    var input = Console.ReadKey();
                    var test = input.KeyChar;
                    Console.Clear();
                    switch(test)
                    {
                        case '1':
                            Console.WriteLine("Enter object to add to stack");
                            var inputobject = Console.ReadLine();
                            stack.Push(inputobject);
                            Console.WriteLine("Object {0} has been added to the stack.", inputobject);
                            break;

                        case '2':
                            Console.WriteLine(stack.Pop());
                            break; 

                        case '3':
                            stack.Clear();
                            Console.WriteLine("Stack cleared");
                            break; 
                        
                        case '4':
                            stack.Push(null);
                            break;

                        default:
                            return;
                    }

                    Console.WriteLine("Press enter to continue....");
                    Console.ReadLine();


                }

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid Operation");
            }
        }
    }
}
