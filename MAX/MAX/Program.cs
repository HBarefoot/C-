using System;

namespace MAX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 20, 9, 40, 30, 10, 100, 60, 50, 200 };

            Max(myArray);
        }

        static void Max(int[] myArray)
        {
            int tmp = 1;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > tmp)
                {
                    tmp = myArray[i];
                }
            }
            Console.WriteLine(tmp);
        }
    }
}
