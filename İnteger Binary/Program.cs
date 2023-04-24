using System;

namespace İnteger_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İstediğiniz kadar sayı giriniz:     ");

            var input = Console.ReadLine();
            var strings = input.Split(' ');
            String str = String.Empty;
            for (int i = 0; i < strings.Length; i += 2)
            {

                if (strings[i] == strings[i + 1]) 
                {
                    str += Math.Pow((Convert.ToInt32(strings[i]) + Convert.ToInt32(strings[i + 1])), 2) + " ";
                }
                else
                {
                    str += Convert.ToInt32(strings[i]) + Convert.ToInt32(strings[i + 1]) + " ";
                }
            }
            Console.WriteLine(str);

        }
    }
}
