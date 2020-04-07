using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        string[] splittedSentence = sentence.Split(" ");
        string builder = "";

        for (int i = 0; i < splittedSentence.Length; i++)
        {
            string currentWord = splittedSentence[i];
            if (currentWord.Length >= 5)
            {
                char[] chars = currentWord.ToCharArray();
                Array.Reverse(chars);
                string newWord = string.Join("", chars);
                if (i == splittedSentence.Length - 1)
                {
                    builder += newWord;
                }
                else
                {
                    builder += newWord + " ";
                }

            }
            else
            {
                if (i == splittedSentence.Length - 1)
                {
                    builder += currentWord;
                }
                else
                {
                    builder += currentWord + " ";
                }
            }
        }
        return builder;
    }
}