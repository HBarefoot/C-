using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an int: ");
            int input = Convert.ToInt32(Console.ReadLine());

            MultiplicationTable(input);

            Console.ReadLine();
        }



        static void MultiplicationTable(int n)
        {
            int counter = 1;

            for (int i = 0; i < n; counter++, i++)
            {
                Multiplicator(counter, n);
            }
        }


        static void Multiplicator(int mult, int n)
        {
            string table = "";

            for (int i = 1; i < n; i++)
            {
                table += (mult * i).ToString() + " ";
            }

            Console.WriteLine(table);
        }
    }
}
