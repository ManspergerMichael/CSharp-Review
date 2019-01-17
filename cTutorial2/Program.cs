using System;


namespace cTutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exception handeling
            try
            {
                System.Console.Write("Devide 10 by ");
                int num = int.Parse(Console.ReadLine());
                System.Console.WriteLine("10 / {0} = {1}", num, (10/num));
            }
            //catch a specific exception 
            catch(DivideByZeroException ex)
            {
                System.Console.WriteLine("Cant Devide by 0");
                System.Console.WriteLine(ex.GetType().Name);
                System.Console.WriteLine(ex.Message);
                throw new InvalidOperationException("Operation Failed",ex);
            }
            //general exception catch
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.GetType().Name);
                System.Console.WriteLine(ex.Message);
            }
            Animal spot = new Animal(15,10,"Spot", "Woof");

            System.Console.WriteLine("{0} says {1}", spot.name,spot.sound);
            System.Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());
        }
    }
}
