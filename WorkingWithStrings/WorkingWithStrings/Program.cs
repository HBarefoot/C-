using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = String.Format("{0} = {1}", "First", "Second");
            //string myString = String.Format("{0:c}", 123.45);
            //string myString = String.Format("{0:N}", 1234567890);
            //string myString = String.Format("Percentage: {0:P}", .123);
            //string myString = String.Format("Phone number: {0:(###) ###-####}", 7864563322);

            string myString = " That summer we took threes across the board ";

            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            myString = String.Format("Lenght before: {0} -- Length after: {1}",
            myString.Length, 
            myString.Trim().Length);

            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}

            //StringBuilder myString = new StringBuilder();

            //for (int i = 0; i < 100; i++)
            //{
            //    myString.Append("--");
            //    myString.Append(i);
            //}

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
