using System;

namespace Anagramma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a sentence \n>>> ");
                string sentence = Console.ReadLine();
                Console.WriteLine(Anagram.Reverse(sentence));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
