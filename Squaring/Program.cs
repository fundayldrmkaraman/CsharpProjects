using System;

namespace Squaring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayıların girişini yapınız: ");
            string num = Console.ReadLine();
            KareAlma(num);
            Console.ReadKey();
        }
        public static void KareAlma(string num)
        {
            string[] Dizi = num.Split(' ');
            int top = 0, sayi = 0, top1 = 0;
            for (int i = 0; i < Dizi.Length; i++)
            {
                sayi = Convert.ToInt32(Dizi[i]);
                if (sayi < 67)
                {
                    top1 = (67 - sayi) + top1;
                }
                else
                {
                    top = (int)Math.Pow(Math.Abs(sayi - 67), 2);
                }
            }
            Console.WriteLine($" {top1}  {top} ");

        }
    }
}
