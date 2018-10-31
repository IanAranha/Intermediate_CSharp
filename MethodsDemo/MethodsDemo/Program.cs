using System;

namespace MethodsDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UsePoints();
            UseParam();
            UseOut();

            //System did not crash when we caught the errors.

        }

        /* ===========================================================*/

        //Demo 3: Use of "out" keyword to prevent system crashing.

        static void UseOut()
        {
            //var number = int.Parse("abc");
            //If i try to run the above code, the system will crash:
            //System.FormatException has been thrown
            //Input string was not in a correct format.
            //
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            var result2 = int.TryParse("123", out number);
            if (result2)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

        }


        /*+++++++++++++++++++++++++++++++++++++++++++++++++++++++
         * 
         * Demo 2 : Use of "param" keyword to prevent system crashing */

        static void UseParam()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6));
            Console.WriteLine(calculator.Add(1, 2));
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /* Use of 'Try' and 'Catch' method to avoid system crashing. */

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);                                      //Instantiating a new point object
                Console.WriteLine("Point is at ({0} ,{1}).", point.X, point.Y);
                point.Move(new Point(40, 60));                                      //Using method overload to move object to new location
                Console.WriteLine("Point is at ({0} ,{1}).", point.X, point.Y);
                point.Move(null);                                                   //Normally we would get a system crash if we try to pass
                                                                                    //a null object to the move method. This {try and catch} avoids system crashes.
            }
            catch (Exception)
            {
                Console.WriteLine("A general error has occured");
            }


            //This code below was written first before the above Global Exception Handling code was written


            //Console.WriteLine("Hello World!");
            //var point = new Point(10, 20);
            //Console.WriteLine("Point is at ({0} ,{1}).", point.X, point.Y);
            //point.Move(new Point(40, 60));
            //Console.WriteLine("Point is at ({0} ,{1}).", point.X, point.Y);


            //Suppose we pass a null object to the Move method like below:
            //point.Move(null);
            //If you try to run the above code, this will result
            //System.NullReferenceException: Object reference not set to an instance of an object
            //point.Move(null);
        }
    }
}
