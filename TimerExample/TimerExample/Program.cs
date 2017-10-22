﻿using System;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the blue event");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();
        }


        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
