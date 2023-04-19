using System;

namespace Creating_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yarıcap;
            double incelik = 0.4;
            char sembol = '.';
            do
            {
                Console.Write("Yarıçapı Girin : ");
                if (!double.TryParse(Console.ReadLine(), out yarıcap) || yarıcap <= 0)
                {
                    Console.WriteLine("Yarıçap negatif olamaz!!");
                }
            }
            while (yarıcap <= 0);
            Console.WriteLine();
            double rIn = yarıcap -  incelik, rOut = yarıcap + incelik;
            for (double y = yarıcap; y >= -yarıcap; --y)
            {
                for (double x = -yarıcap; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(sembol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
