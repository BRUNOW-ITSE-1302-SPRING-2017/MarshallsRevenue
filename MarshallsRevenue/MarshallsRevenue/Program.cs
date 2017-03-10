using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarshallsRevenue
{
    class Program
    {
        static void Main()
        {
            int numberOfInteriorMurals = -1;
            int numberOfExteriorMurals = -1;
            int month = 0;

            numberOfInteriorMurals = GetNumberOfMurals("Enter the number of interior murals estimated for next month: ");
            numberOfExteriorMurals = GetNumberOfMurals("Enter the number of exterior murals estimated for next month: ");

            month = GetMonth();

            double totalRevenue = DisplayPricesAndReturnRevenue(numberOfInteriorMurals, numberOfExteriorMurals, month);

            string[] interiorMuralCustomers = new string[numberOfInteriorMurals];
            string[] exteriorMuralCustomers = new string[numberOfExteriorMurals];

            GetCustomerNames("Enter the {0} interior customer's name: ", interiorMuralCustomers);
            GetCustomerNames("Enter the {0} exterior customer's name: ", exteriorMuralCustomers);

            DisplayCustomerNames("Here are the interior customers:", interiorMuralCustomers);
            DisplayCustomerNames("Here are the exterior customers:", exteriorMuralCustomers);
        }

        static int GetMonth()
        {
            int month = 0;

            while (month < 1 || month > 12)
            {
                Write("Enter a number for the month (January = 1, etc): ");

                month = int.Parse(ReadLine());
            }

            return month;
        }

        static int GetNumberOfMurals(string prompt)
        {
            int numberOfMurals = -1;

            while (numberOfMurals < 0 || numberOfMurals > 30)
            {
                Write(prompt);
                numberOfMurals = int.Parse(ReadLine());
            }

            return numberOfMurals;
        }

        static double DisplayPricesAndReturnRevenue(int numberOfInteriorMurals, int numberOfExteriorMurals, int month)
        {
            const double INTERIOR_MURAL_COST = 500;
            const double INTERIOR_DISCOUNT_AMOUNT = 50;
            const double EXTERIOR_MURAL_COST = 750;
            const double EXTERIOR_DISCOUNT_AMOUNT = 51;
            double totalRevenue = 0;
            double interiorMuralCost = INTERIOR_MURAL_COST;
            double exteriorMuralCost = EXTERIOR_MURAL_COST;

            if (month == 12 || month == 1 || month == 2)
            {
                numberOfExteriorMurals = 0;
                WriteLine("Sorry, we don't do exterior murals in that month");
            }

            if (month == 4 || month == 5 || month == 9 || month == 10)
            {
                exteriorMuralCost -= EXTERIOR_DISCOUNT_AMOUNT;
            }

            if (month == 7 || month == 8)
            {
                interiorMuralCost -= INTERIOR_DISCOUNT_AMOUNT;
            }

            WriteLine("\nThanks!\n\nHere are your results: ");

            double interiorMuralRevenue = numberOfInteriorMurals * interiorMuralCost;
            double exteriorMuralRevenue = numberOfExteriorMurals * exteriorMuralCost;

            WriteLine("Interior Revenue: {0}", interiorMuralRevenue);
            WriteLine("Exterior Revenue: {0}", exteriorMuralRevenue);

            totalRevenue = interiorMuralRevenue + exteriorMuralRevenue;

            return totalRevenue;
        }

        static void GetCustomerNames(string prompt, string[] customerNames)
        {
            for (int index = 0; index < customerNames.Length; index++)
            {
                Write(prompt, index + 1);
                customerNames[index] = ReadLine();
            }
        }

        static void DisplayCustomerNames(string prompt, string[] customerNames)
        {
            WriteLine(prompt);
            foreach (string name in customerNames)
            {
                WriteLine(name);
            }
        }
    }
}
