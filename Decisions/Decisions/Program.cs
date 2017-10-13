using System;

namespace Decisions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
                message = "you won a new car!";

            else if (userValue == "2")
                message = "You won a new boat!";

            else if (userValue == "3")
                message = "You won a new cat!";
            else
            {
                message = "Sorry, we didn't understand. ";
                //message = "You Lose";
                message += "You lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
