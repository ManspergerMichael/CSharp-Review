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
            /* System.Console.WriteLine("Math.Abs " + (Math.Abs(number1))); //abolute value (neg to pos)
            System.Console.WriteLine(Math.Ceiling(number1)+ " Round Up"); //round up
            System.Console.WriteLine(Math.Floor(number1)+ " Round Down"); */

            //random numbers
            Random rand = new Random();
            System.Console.WriteLine("Random number between 1 and 10 " + rand.Next(1,11));

            //if-else

            int age = 17;
            if((age >= 5)&&(age <7))
            {
                System.Console.WriteLine("To the coal mines with you!");
            }
            else if((age > 7)&&(age < 13))
            {
                System.Console.WriteLine("To the Factory with you!");
            }
            else
            {
                System.Console.WriteLine("To the front lines with you!");
            }

            if((age > 50))
            {
                System.Console.WriteLine("Take them out back for exicution!");
            }

            //Trinary operateor
            
            //if age >= 16 assign true to canDrive. Else assign false
            bool canDrive = age >= 16 ? true : false;

            int canDrive2 = age >= 16 ? 1 : 0;

            //loops
            
            int i = 0;
            while(i < 10)
            {
                if(i == 7)
                {
                    i++;
                    continue; //skips the rest of the loop for one iteration
                }
                if(i == 9){
                    break; //ends the loop
                }
                if((i%2)>0)
                {
                    System.Console.WriteLine(i);
                }
                i++;
            }

            //do while
            string guess;
            do
            {
                System.Console.WriteLine("Guess a number");
                guess = Console.ReadLine();

            }
            while(! guess.Equals("42"));

            //for loop
            for (int j = 0; j < 10; j++)
            {
                if(j % 2 > 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            

        }
    }
}
