using System;

namespace Creating_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=sayi;i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
