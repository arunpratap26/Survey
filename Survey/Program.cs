using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.White;
            var name = TryAnswer();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What is your age?");
            Console.ForegroundColor = ConsoleColor.White;
            var age = TryAnswer();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What month were you born in?");
            Console.ForegroundColor = ConsoleColor.White;
            var month = TryAnswer();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if (month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }
        }
        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("you haven't answered anything please answer it");
                Console.ForegroundColor = ConsoleColor.Green;
                return Console.ReadLine();
            }
            return question;
        }
    }
}
