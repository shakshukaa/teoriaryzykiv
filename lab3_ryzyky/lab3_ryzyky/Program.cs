using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ryzyky
{
    class Program
    {
        static double U(double x)
        {
            return Math.Pow((20 * x),3);
        }

        static double M(double p, double xmin = 10, double xmax = 20)
        {
            return xmin * p + xmax * (1 - p);
        }

        static double invU(double x)
        {
            return Math.Pow((x / 20), 35);
        }

        static void Main(string[] args)
        {
            double xc = M(3);
            double xhat = invU(M(3, U(10), U(20)));

            Console.WriteLine($"Spodivaniy vigrash: {xc}");
            Console.WriteLine($"Determinovaniy ekvivalent: {xhat}");
            Console.WriteLine($"Premiya za ryzyk: {xc-xhat}");

            if(U(M(3))>M(3, U(10), U(20)))
            {
                Console.WriteLine("Osoba nesxilna do riziku");
            }
            else if(U(M(3)) < M(3, U(10), U(20)))
            {
                Console.WriteLine("Osoba sxilna do riziku");
            }
            else
            {
                Console.WriteLine("Osoba neitralna do riziku");
            }

            Console.WriteLine($"Pri uchasti v loterei osoba mae rizik vtratiti {xc-xhat}");
            Console.ReadKey();
        }
    }
}
