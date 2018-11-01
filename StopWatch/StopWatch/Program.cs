using System;
namespace StopWatch
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hit enter to start Stop Watch program.");

            try
            {
                var stopwatch = new StopWatch();

                while (true)
                {
                    var input = Console.ReadLine().ToLower().Trim();
                    if (string.IsNullOrWhiteSpace(input))
                        Console.WriteLine("Enter 's' to start timer, 'q' to stop timer or '1' to quit program");
                    else if (input == "s")
                    {
                        stopwatch.Start();
                        Console.WriteLine("The timer has started.");
                        Console.WriteLine("Enter 'q' to stop or '1' to quit program.");
                    }
                    else if (input == "q")
                    {
                        stopwatch.Stop();
                        Console.WriteLine("The timer has ended.");
                        Console.WriteLine(stopwatch.Result());
                        Console.WriteLine("Enter 's' to start or 1 to quit");
                    }
                    else if (input == "1")
                    {
                        break;
                    }

                }
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Error: {0}", exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.Message);
            }
        }
    }
}
