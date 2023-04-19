using System;

namespace Reverse_String
{
    internal class Program
    {
        public static string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            string reverse=String.Empty;
            for(int i=chars.Length-1; i>-1; i--)
            {
                reverse += chars[i];
            }
            return reverse;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("I Love You"));
        }
    }
}
