/*Read a text file and count the frequency of each word using a
Dictionary<string, int>.
Example:
Input: "Hello world, hello Java!"
Output: { "hello": 2, "world": 1, "java": 1 }*/
using System;
using System.Collections.Generic;
using System.IO;

class WordFrequency
{
    public void CountWords(string filePath)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        string text = File.ReadAllText(filePath).ToLower();

        char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r', '\t' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}
