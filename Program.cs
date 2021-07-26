using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {


            // Practice Creating Variables

            //     Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day.
            var numberOfCupsOfCoffee = 4.2;

            //     Create a variable (use your best judgment for type) called fullName and set it equal to your full name.
            var fullName = "Gavin";

            //     Create a variable (use your best judgment for type) called today and set it equal to today's date.
            var today = DateTime.Now;

            //     Use Console.WriteLine and your variables, numberOfCupsOfCoffee, fullName, and today, to output all three on one line.
            Console.WriteLine($"{fullName} will drink {numberOfCupsOfCoffee} cups of ☕️ on {today}");



            var firstNumberAsString = Console.ReadLine();
        }
    }
}
