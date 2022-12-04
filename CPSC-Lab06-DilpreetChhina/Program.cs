using System;

namespace CPSC_Lab06_DilpreetChhina
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Purpose: Creating simple class with properties, constructor, and a instance-level method  
            //Input: int minutes, int km
            //Output: double fair
            //Written by: Dilpreet Chhina
            //Written for: Carlos Estoy
            //Section: E01
            //Last Modified Date: 2022-12-03
            int minutes = 0, km = 0;
            double fair = 0;
            do
            {
                try
                {
                    Console.WriteLine("Welcome to the Taxi Fare Calculator");
                    Console.WriteLine("Enter the time, in whole minutes. te trip took (min 10 minutes)");

                    while (!int.TryParse(Console.ReadLine(), out minutes))
                    {
                        Console.WriteLine("Wrong input, try again...");
                        Console.WriteLine("Enter the time, in whole minutes. te trip took (min 10 minutes)");
                    }

                    Console.WriteLine("Enter the distance, in whole kilometer, the trip was (min 2 km)");

                    while (!int.TryParse(Console.ReadLine(), out km))
                    {
                        Console.WriteLine("Wrong input, try again...");
                        Console.WriteLine("Enter the distance, in whole kilometer, the trip was (min 2 km)");
                    }

                    TaxiFare taxi = new TaxiFare(minutes, km);
                    fair = taxi.CalculateFair(minutes, km);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);    //Exiting the program if there is an exception
                }
            }

            while (minutes < 10 || km < 2);

            Console.WriteLine("The fare for the pssenger is {0:C}", fair);
        }
    }
}
