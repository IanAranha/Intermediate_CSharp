using System;

namespace MethodsDemo
{


    class MainClass
    {
        public static void Main(string[] args)
        {
            //UsePoints();
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2,3,4,5,6,7,8,9,10));
            Console.WriteLine(calculator.Add(new int[]{1,2,3}));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(0, 0);
                Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);

                point.Move(10, 30);
                Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);

                point.Move(new Point(100, 200));
                Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);

                point.Move(null);
                Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured.");
            }
        }
    }
}
