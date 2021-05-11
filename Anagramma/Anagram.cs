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
                for (int i = word.Length - 1, j = 0; i >= 0 && j < word.Length; i--, j++)
                {
                    if (char.IsLetter(word[i]))
                    {
                        if (char.IsLetter(word[j]))
                        {
                            reversedWord[j] = word[i];
                        }
                        else
                        {
                            i++;
                        }
                    }
                    else
                    {
                        reversedWord[i] = word[i];
                        j--;
                    }
                }

                reversedWords.Add(string.Join("", reversedWord));
            }

            return string.Join(" ", reversedWords);
        }
    }
}