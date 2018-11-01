namespace InheritanceDemo
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }


        public void AddHyperline(string url)
        {
            System.Console.WriteLine("Added hyperlink to "+url);
        }
    }
}
