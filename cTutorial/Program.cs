using System;

namespace cTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");

            //console input
            /* Console.Write("What is your name?");
            string name = Console.ReadLine();
            System.Console.WriteLine("Hello "+name); */

            //data Types

            bool canVote = true;
            char grade = 'A';

            //interger with max number of 2,147,483,647
            int maxInt = int.MaxValue;
            //large numbers
            long maxLong;
            decimal Dec;

            //32 bit, 7 levels of presicion
            float floatInt;
            //32 bit number with 15 decimals of presicion
            double Dubs;

            //C# can use var data types but is restricted to the data type it is initalized to
            var name = "Billy Everyteen";
            //produces an error
            //name = 2;

            //string formating
            System.Console.WriteLine("Another name is {0}", name);

            //casting
            //if no presiscion is lost casting will happen automaticly
            double pi = 3.14159;
            int intPi = (int)pi;

            //some math functions
            double number1 = 10.5;
            double number2 = 15;
            System.Console.WriteLine("Math.Abs " + (Math.Abs(number1))); //abolute value (neg to pos)
            System.Console.WriteLine(Math.Ceiling(number1)+ " Round Up"); //round up
            System.Console.WriteLine(Math.Floor(number1)+ " Round Down");


        }
    }
}
