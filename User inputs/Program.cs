using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_inputs
{
    internal class Program
    {
        static void GramsToOunces()
        {
            Console.WriteLine("Enter grams: ");
            string Input = Console.ReadLine();
            double G = Convert.ToInt32(Input);
            if (G <= 0)
            {
                Console.WriteLine("Invalid input.");
                Console.WriteLine("Enter grams: ");
                Input = Console.ReadLine();
            }
            double Oz = G * 0.035274;
            Console.WriteLine("{0}g = {1}Oz", G, Oz);
        }

        static void Main(string[] args)
        {
            GramsToOunces();
            Console.ReadLine();
        }

    }
}
