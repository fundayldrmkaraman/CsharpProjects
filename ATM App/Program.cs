using System;

namespace ATM_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
 
            Console.WriteLine("Bakiyeniz = " + bakiye);
            Console.WriteLine("\n****İSLEMLER****\n");
            Console.WriteLine("1. Para Çekme");
            Console.WriteLine("2. Para Yatırma");
            Console.WriteLine("3. Bakiye sorgulama");
            Console.WriteLine("4. Çıkış Yap");
 
            Console.Write("\nİsleminizi Seciniz: ");
            int islem = Convert.ToInt32(Console.ReadLine());
 
            switch (islem)
            {
                case 1:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar > bakiye)
                    {
                        Console.Write("Yetersiz bakiye. Tekrar giriniz: ");
                        tutar = Convert.ToInt32(Console.ReadLine());
                    }
                    bakiye -= tutar;
                    Console.WriteLine("Yeni bakiyeniz = " + bakiye);
                    break;
                case 2:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += tutar;
                    Console.WriteLine("Yeni bakiyeniz = " + bakiye);
                    break;
                case 3:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    break;
                case 4:
                    Console.WriteLine("İyi günler dileriz.!!");
                    break;
                default:
                    Console.WriteLine("Yanlıs islem secitiniz. Tekrar giriniz.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
