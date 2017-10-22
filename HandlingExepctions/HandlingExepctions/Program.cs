using System;
using System.IO;

namespace HandlingExepctions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"/Users/henrybarefoot/Desktop/text.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make the name of the file is correctly");
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make sure the path to this file exist");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                // Closing database copnactions
                Console.WriteLine("Closing app")
            }
            Console.ReadLine();
        }
    }
}
