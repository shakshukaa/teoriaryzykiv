using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryzyky_lab1
{
    class Program
    {
        static double chance;
        static void Main(string[] args)
        {
            double homeben, forben;
            Console.WriteLine("Enter the chance of rain: ");
      
            chance = Convert.ToDouble(Console.ReadLine());
           
            if(chance < 0 || chance > 1)
            {
                Console.WriteLine("Invalid value");
                Environment.Exit(0);
            }

            homeben = chance * 2 + (1 - chance) * 5;
            forben = chance * 0 + (1 - chance) * 8;

            if(homeben > forben)
            {
                Console.WriteLine("Sit at home");
            }
            else
            {
                Console.WriteLine("Go to forest");
            }
            Console.ReadKey();
        }
    }
}
