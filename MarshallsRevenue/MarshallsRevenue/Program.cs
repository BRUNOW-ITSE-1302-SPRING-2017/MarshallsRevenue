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
            const double INTERIOR_MURAL_COST = 500;
            const double EXTERIOR_MURAL_COST = 750;

            int numberOfInteriorMurals = 0;
            int numberOfExteriorMurals = 0;

            Write("Enter the number of interior murals estimated for next month: ");
            numberOfInteriorMurals = int.Parse(ReadLine());

            Write("Enter the number of exterior murals estimated for next month: ");
            numberOfExteriorMurals = int.Parse(ReadLine());

            WriteLine("\nThanks!\n\nHere are your results: ");

            double interiorMuralRevenue = numberOfInteriorMurals * INTERIOR_MURAL_COST;
            double exteriorMuralRevenue = numberOfExteriorMurals * EXTERIOR_MURAL_COST;

            WriteLine("Revenue for {0} interior murals: {1}", numberOfInteriorMurals, interiorMuralRevenue);
            WriteLine("Revenue for {0} exterior murals: {1}", numberOfExteriorMurals, exteriorMuralRevenue);
            WriteLine("Total Estimated Revenue: {0}", interiorMuralRevenue + exteriorMuralRevenue);

            WriteLine("More exterior murals are scheduled than interior: {0}", numberOfExteriorMurals > numberOfInteriorMurals);
        }
    }
}
