using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;


            Console.WriteLine("Value: " + numbers[9] + ".");
            Console.WriteLine("Length of my array: " + numbers.Length + ".");
            Console.ReadLine();


            //array declarations
            //int[] numbers = new int[] { 4, 8, 12, 454, 66, 7, 77 };

            string[] names = new string[] { "henry", "pepe", "marcos", "fernan", "lester" };

            // for loop
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("For loop method: " + names[i] + ".");
            }

            // foreach loop
            foreach (string name  in names)
            {
                Console.WriteLine("For each method " + name + ".");
            }


            string zig = "You can get what you want out of life" + 
                " if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();

            Array.Reverse(charArray);


            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }


            Console.ReadLine();
        }
    }
}
