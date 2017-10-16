using System;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car.myMethod();
            //Car myCar = new Car(
            //        "Nissan",
            //       "Sentra",
            //        2011,
            //        "Red");

            ////myCar.Make = "Lada";
            ////myCar.Model = "2107";
            ////myCar.Year = 1995;
            ////myCar.Color = "Silver";

            ////Car myOther;
            ////myOther = myCar;

            ////Console.WriteLine("{0} {1} {2} {3}", 
            //                  //myOther.Make, 
            //                  //myOther.Model = "1600", 
            //                  //myOther.Year, 
            //                  //myOther.Color = "Blue");

            //Console.WriteLine("{0} {1} {2} {3}",
            //myCar.Make,
            //myCar.Model,
            //myCar.Year,
            //myCar.Color);
            //myCar = null; // .Net will removed this class
            ////myOther = null; // .Net will removed this class 
            
            Console.ReadLine();
        }
    }

    // Car class constructor
    class Car
    {
        public string Make
        {
            get;
            set;
        }
        public string Model
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }

        public Car()
        {
            // you could load from a configuration file,
            // a database, etc
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        public static void myMethod()
        {
            Console.WriteLine("Called the static method");  
        }
    }
}
