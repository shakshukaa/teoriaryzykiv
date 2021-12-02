using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ryzyky
{
    class Program
    {
        static double[,] A = { { 5, -5, -5 }, { -5, -5, 5 }, { 1.5, 1.5, 0 }, { 0, 0, 0 } };
        static double[] detA = new double[4];

        static double M(int i)
        {
            return A[i, 0] * 0.5 + A[i, 1] * 0.1 + A[i, 2] * 0.4;
        }

        static void Utility(int i)
        {
            A[i, 0] = Math.Sqrt(A[i, 0] + 5) / 15;
            A[i, 1] = Math.Sqrt(A[i, 1] + 5) / 15;
            A[i, 2] = Math.Sqrt(A[i, 2] + 5) / 15;
        }

        static double InvertedUtility(double M)
        {
            return 225 * M * M - 5;
        }
        static void Main(string[] args)
        {
            double[] oriented_win = new double[4];

            for (int i = 0; i < 4; i++)
            {
                oriented_win[i] = M(i);
            }

            for (int i = 0; i < 4; i++)
            {
                Utility(i);

                detA[i] = InvertedUtility(M(i));
            }

            double[] Prize = new double[4];

            for (int i = 0; i < 4; i++)
            {
                Prize[i] = oriented_win[i] - detA[i];
            }

            Console.WriteLine($"{Prize[0]} {Prize[1]} {Prize[2]} {Prize[3]} \n");

            double max = Prize.Max();

            if (Prize[0] == max)
            {
                Console.WriteLine($"Рiшення 1 є найкращим");
            }
            else if (Prize[1] == max)
            {
                Console.WriteLine($"Рiшення 2 є найкращим");
            }
            else if (Prize[2] == max)
            {
                Console.WriteLine($"Рiшення 3 є найкращим");
            }
            else
            {
                Console.WriteLine($"Рiшення 4 є найкращим");
            }

            Console.ReadKey();
        }
    }
}
