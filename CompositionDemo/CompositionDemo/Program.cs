using System;

namespace CompositionDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);


            dbMigrator.Migrate();
            installer.Install();
        
        }
    }
}

//EXPLANATION IN MY OWN WORDS:
/*
 * Compostion is a way to link classes.
 * In this example, we have two different classes DbMigrator...which does some work like opening a file, writing to it and stuff.
 * The intaller does something else like installing a file in a specific place on the computer.
 * BOTH these classed have to record their actions in the logger.
 * Therefore they have to be linked to the Logger class.
 * 
 * Started by first creating simple logger class. It will display a message showing what it is doing - logging activity.
 * 
 * Then we create DbMigrator class and in the constructor, we pass the logger class.
 * Same with Installer class. 
 * Using the Refresher (right click...Quick Fix) feature of VSC, the constructor is added automatically and so too are the intializes.
 * 

*/