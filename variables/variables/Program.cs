using System;

namespace variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name ?");
            Console.WriteLine("type ypur first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("type your last name: ");
            myLastName = Console.ReadLine();


            Console.WriteLine("Hello " + myFirstName + " " + myLastName);
        }
    }
}
