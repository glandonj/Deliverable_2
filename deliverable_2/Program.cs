// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Good day to you.  Welcome to our Buffet!");
        Console.WriteLine("We serve all appetites here.  All you can eat for $9.99!");
        Console.WriteLine("Only additional charge is for coffee, which is $2.00.");
        Console.WriteLine("Please note: we only serve parties of 6 or fewer.");
        Console.WriteLine();
        Console.Write("How many people are in your group?");
        Console.WriteLine();
        int people = int.Parse(Console.ReadLine());
        if (people > 6)
        {
            Console.WriteLine("Oh sorry! We can only seat parties up to 6.  Have a great day!");
            Console.ReadLine();
        }
        else if (people < 1)
        {
            Console.WriteLine("No jokes here.  We can seat parties up to 6.  Have a nice day!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Great!  Table for " + people + "." + " Pleasure to serve you.  Please follow me to your seat.");
            Console.WriteLine();
            Console.WriteLine("Let's get everyone started with drinks.  We've got water or coffee.");
            Console.WriteLine();
            int drinks = 1;
            int coffee = 0;
            int water = 0;
            while (drinks <= people)
            {
                Console.WriteLine("Customer " + drinks + ", what drink would you like?");
                string drink = Console.ReadLine().ToLower();
                if (drink == "coffee")
                {
                    Console.WriteLine("Coffee. Nice choice.");
                    Console.WriteLine();
                    coffee++;
                }
                else if (drink == "water")
                {
                    Console.WriteLine("Water.  Excellent.");
                    Console.WriteLine();
                    water++;
                }
                else
                {
                    Console.WriteLine("Sorry.  We only serve water or coffee.  No drink for you.");
                    Console.WriteLine();
                }
                drinks++;
            }
            Console.WriteLine();
            Console.WriteLine("Ok, thank you for dining with us.");
            Console.WriteLine();
            if (coffee == 1 || coffee == 0) { Console.Write("You had " + people + " in your group and ordered " + coffee + " coffee "); }
            else { Console.Write("You had " + people + " in your group and ordered " + coffee + " coffees "); }
            if (water == 1 || water == 0) { Console.WriteLine("and " + water + " water."); }
            else { Console.WriteLine("and " + water + " waters."); }
            Console.WriteLine("The total for your bill is $" + (people * 9.99 + coffee * 2.00) + ".");
            Console.WriteLine("We take cash or credit.  You can pay at the front on your way out.");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}

