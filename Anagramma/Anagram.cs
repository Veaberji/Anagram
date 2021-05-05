using System;
using System.Collections.Generic;

namespace Anagramma
{
    public class Anagram
    {
        public static string Reverse(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                throw new ArgumentNullException("'sentence' can`t be null or empty.");
            }

            var words = sentence.Split(" ");
            var reversedWords = new List<string>();

            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word))
                {
                    reversedWords.Add(word);
                    continue;
                }
                var reversedWord = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                {
                    if (!char.IsLetter(word[i]))
                        reversedWord[i] = word[i];
                }

                for (int i = word.Length - 1, j = 0; i >= 0 && j < word.Length; i--, j++)
                {
                    if (!char.IsLetter(word[i]))
                    {
                        j--;
                        continue;
                    }

                    if (reversedWord[j] != '\0')
                    {
                        i++;
                        continue;
                    }
                    reversedWord[j] = word[i];
                }

                reversedWords.Add(string.Join("", reversedWord));

            }

            string reversedSentence = new string(string.Join(" ", reversedWords));
            Console.WriteLine(reversedSentence);
            return reversedSentence;
        }

    }
}