using System;

namespace MethodsDemo
{
    public class Point
    {
        public int X;
        public int Y;


        //Constructor
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //Move method 1
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //Move method 2
        public void Move(Point newLocation)
        {
            if (newLocation == null)
                 throw new ArgumentNullException("newLocation cannot be null");
            Move(newLocation.X, newLocation.Y);
        }
    }
}
