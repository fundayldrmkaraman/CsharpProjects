using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime ve çıkarmak istenilen karakter indeksi giriniz (Arada virgül olmalıdır):");
            string k = Console.ReadLine();

            string[] input = k.Split(",");
            string word = input[0];
            int number = Convert.ToInt32(input[1]);
            string newWord = word.Remove(number, 1);

            Console.WriteLine(newWord);
        }
    }
}
