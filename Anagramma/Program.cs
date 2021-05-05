using System;

namespace Anagramma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Anagram.Reverse(" ");
                Anagram.Reverse("  a12bc+d    efg!h");
                Anagram.Reverse("a1bcd efg!h");
                Anagram.Reverse("oneWord");
                Anagram.Reverse(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
