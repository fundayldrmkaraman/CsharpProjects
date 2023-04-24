using System;

namespace Area_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alan hesabı yapmak istediğiniz şekli seçin:  \n 1-Daire \n 2-Kare \n 3-Dikdörtgen \n 4-Üçgen");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1: Daire(); break;
                case 2: Kare(); break;
                case 3: Dikdortgen(); break;
                case 4: Ucgen(); break;

                default:
                    break;
            }
        }
        public static void Daire()
        {
            Console.WriteLine("Alanını hesaplamak istediğiniz çemberin yarı çapını girin");
            int yaricap = int.Parse(Console.ReadLine());
            int sonuc = yaricap * yaricap * 3;
            Console.WriteLine(sonuc);
        }
        public static void Kare()
        {
            Console.WriteLine("Karenin kenarı giriniz : ");
            int kenar = int.Parse(Console.ReadLine());
            int sonuc = kenar * kenar;
            Console.WriteLine(sonuc);
        }
        public static void Dikdortgen()
        {
            Console.WriteLine("Kısa kenarı giriniz : ");
            int kisa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz : ");
            int uzun = int.Parse(Console.ReadLine());
            int sonuc = kisa * uzun;
            Console.WriteLine(sonuc);
        }
        public static void Ucgen()
        {
            Console.WriteLine("Kısa kenarı giriniz : ");
            int kisa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz : ");
            int uzun = int.Parse(Console.ReadLine());
            int sonuc = (kisa * uzun) / 2;
            Console.WriteLine(sonuc);
        }
    }
}
