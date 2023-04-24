using Microsoft.VisualBasic;
using System;

namespace Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin giriniz : ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            string consonant = "bcdfghjklmnpqrstvwxyz";

            foreach (string word in words)
            {
                bool hasConsecutiveConsonants = false;
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (consonant.Contains(word[i]) && consonant.Contains(word[i + 1]))
                    {
                        hasConsecutiveConsonants = true;
                        break;
                    }
                }
                Console.Write(hasConsecutiveConsonants + " ");
            }
            Console.WriteLine();
        }
    }
}
