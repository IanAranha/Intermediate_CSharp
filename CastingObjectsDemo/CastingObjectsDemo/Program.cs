using System;

namespace CastingObjectsDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var text = new Text();
            var shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

        }
    }
}
