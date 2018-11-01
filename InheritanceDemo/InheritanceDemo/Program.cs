namespace InheritanceDemo
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var circle = new PresentationObject();
            circle.Height = 100;
            circle.Width = 100;
            System.Console.WriteLine("Height: {0}", circle.Height);

            var text = new Text();
            text.Height = 10;
            System.Console.WriteLine("Height: {0}", text.Height);
            text.Copy();
        }
    }
}
