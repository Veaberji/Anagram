using System;

namespace Anagramma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Anagram.Reverse());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
