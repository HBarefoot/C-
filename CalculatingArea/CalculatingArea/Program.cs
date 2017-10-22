using System;

namespace CalculatingArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets create a rectangle!!");
            Console.WriteLine("Enter a integer to represent the width:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer to reoresent the height:");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int area = Area(input, input2);

            Console.WriteLine("(width){0} * (heigth){1} = {2}", input, input2, area);


            Console.ReadLine();
        }

        // Calculationg area of a rectangle 
        public static int Area(int widht, int height)
        {
            return widht * height;
        }
    }
}
