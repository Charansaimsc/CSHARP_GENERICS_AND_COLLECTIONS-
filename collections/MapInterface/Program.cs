using System;
using System.Collections.Generic;
namespace mapinterface
{
    public class Program
    {
        static void Main(string[] args)
        {
        //     string filePath = "input.txt";

        // WordFrequency counter = new WordFrequency();
        // counter.CountWords(filePath);

Dictionary<string, int> input = new Dictionary<string, int>()
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        Dictionary<int, List<string>> result =
            DictionaryInverter.Invert(input);

        foreach (var pair in result)
        {
            Console.Write(pair.Key + " = [ ");
            foreach (var value in pair.Value)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("]");
        }
    





        }
    }
}