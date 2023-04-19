using System;

namespace OrtalamaHesaplama
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3=0, i, number;
            Console.Write("Fibonacci Derinliğini Giriniz: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");    
            for (i = 2; i < number; ++i)    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            double average = (n1 + n2 + n3) / number;
            Console.WriteLine("Fibonacci serisi ortalaması: " + average);
        }
    }
}
