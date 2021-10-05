using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum, bank, company, XA1, XA2, XB1, XB2;
            double PA1, PA2, PB1, PB2;
            double MA, MB, VA, VB, sigmaA, sigmaB, CVA, CVB;

            try
            {
                Console.Write("Введіть вклад: ");
                sum = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть банківський відсоток(%): ");
                bank = Convert.ToDouble(Console.ReadLine());

                XA1 = sum * bank / 100;

                Console.Write("Введіть ймовірність успішної операції: ");
                PA1 = Convert.ToDouble(Console.ReadLine());

                if (PA1 < 0 || PA1 > 1)
                {
                    Console.WriteLine("Invalid value");
                    Environment.Exit(0);
                }
                

                Console.Write("Введіть прибуток: ");
                XA2 = Convert.ToDouble(Console.ReadLine());

                PA2 = 1 - PA1;

                Console.WriteLine($"Ймовірність: {PA2}");

                Console.WriteLine();

                Console.Write("Введіть відсоток АТ(%): ");
                company = Convert.ToDouble(Console.ReadLine());

                XB1 = sum * company / 100;

                Console.Write("Введіть ймовірність успішної операції: ");
                PB1 = Convert.ToDouble(Console.ReadLine());

                if (PB1 < 0 || PB1 > 1)
                {
                    Console.WriteLine("Invalid value");
                    Environment.Exit(0);
                }

                Console.Write("Введіть прибуток: ");
                XB2 = Convert.ToDouble(Console.ReadLine());

                PB2 = 1 - PB1;

                Console.WriteLine($"Ймовірність: {PB2}");

                Console.WriteLine();

                MA = PA1 * XA1 + PA2 * XA2;
                MB = PB1 * XB1 + PB2 * XB2;

                if (MA > MB)
                {
                    Console.WriteLine("Максимальний прибуток - у банка");
                }
                else
                {
                    Console.WriteLine("Максимальний прибуток - у АТ");
                }

                VA = PA1 * Math.Pow(XA1 - MA, 2) + PA2 * Math.Pow(XA2 - MA, 2);
                VB = PB1 * Math.Pow(XB1 - MB, 2) + PB2 * Math.Pow(XB2 - MB, 2);

                sigmaA = Math.Sqrt(VA);
                sigmaB = Math.Sqrt(VB);

                if (sigmaA < sigmaB)
                {
                    Console.WriteLine("Найменьше середньоквадратичне відхилення в банку");
                }
                else
                {
                    Console.WriteLine("Найменьше середньоквадратичне відхилення в АТ");
                }
                CVA = sigmaA / MA;
                CVB = sigmaB / MB;

                Console.WriteLine($"Коеф. варіації в банку: {CVA}");
                Console.WriteLine($"Коеф. варіації в АТ: {CVB}");

                if (CVA < CVB)
                {
                    Console.WriteLine("Найменьший коеф. варіації в банку. Краще обрати банк.");
                }
                else
                {
                    Console.WriteLine("Найменьший коеф. варіації в АТ. Краще обрати АТ.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid value");
            }

            Console.ReadKey();
        }
    }
}

