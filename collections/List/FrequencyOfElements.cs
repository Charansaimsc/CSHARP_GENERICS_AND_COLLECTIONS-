using System;
using System.Collections.Generic;
using System.Data;
class FrequencyFind
{
    static Dictionary<string,int> CountFreq(List<string> items)
    {
        Dictionary<string,int> dict = new Dictionary<string, int>();
        foreach(var item in items)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]=dict[item]+1;
            }
            else
            {
                dict[item] =1;
            }
        }
        return dict;
    }
    public static void PrintFrequency(List<string> items)
    {
        Dictionary<string,int> frequency = CountFreq(items);
        foreach(var pair in frequency)
        {
            Console.WriteLine(pair.Key+"     ---->"+pair.Value);
        }
    }
}