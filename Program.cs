using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is it that you wish to do?");
            string unimportantAnswer = Console.ReadLine();
            Console.WriteLine("Hmm, I suggest that you...");
            Random rnd = new Random();
            int answer = rnd.Next(1, 3);
            if (answer == 1)
            {
                Console.WriteLine("don't do that.");
            } else
            {
                Console.WriteLine("go ahead and do that!");
            }
        }
    }
}
