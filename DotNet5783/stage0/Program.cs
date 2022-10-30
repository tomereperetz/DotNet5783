using System;

namespace Targil0
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();
            Console.ReadKey();
        }

        private static void NewMethod()
        {
            Console.WriteLine("enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("{0}, welcome!", userName);

        }

    }
}
