using System;

namespace ternary_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway.");
            Console.Write("Choose a door: 1, 2, 3: ");
            string userValue = Console.ReadLine();

            // evaluation usiong ternary operator
            string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");


            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("Youe entered: {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();
        }
    }
}