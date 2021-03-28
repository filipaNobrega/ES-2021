using System;
using System.Text.RegularExpressions;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            do
            {
                Console.WriteLine("Enter a word or a sentence, and then press Enter:");
                text = Console.ReadLine();
            } while (string.IsNullOrEmpty(text));

            var textWoWhitespaces = Regex.Replace(text, @"\s+", "");
            var charArray = textWoWhitespaces.ToCharArray();
            Array.Reverse(charArray);
            var reverseText = new string(charArray);

            if (textWoWhitespaces.Equals(reverseText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("'{0}' is a palindrome!", text);
            }
            else
            {
                Console.WriteLine("'{0}' is not a palindrome!", text);
            }
        }
    }
}