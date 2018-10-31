using System;
namespace MethodsDemo
{
    public class Point
    {
        public int X;
        public int Y;


        //Constructor for point object
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        //Method for the Point object with two signature parameters
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //Overloading the class by using the same method name but different parameter.
        public void Move(Point newLocation)
        {
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
            //
            //while the above code is correct for the object, there are too many this.X/this.Y used. 
            //Remember DRY : DO NOT REPEAT YOURSELF.
            //A simple remedy
            //Move(newLocation.X, newLocation.Y);

            // Prevent a system crash when a null object is passed to the move function:
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            //So this is called defensive programming. IF a null object is passed, we will not hit the next line of code.
            Move(newLocation.X, newLocation.Y);
        }
    }
}
