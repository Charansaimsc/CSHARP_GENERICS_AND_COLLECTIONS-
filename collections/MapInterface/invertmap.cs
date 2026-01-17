using System.Collections.Generic;

class DictionaryInverter
{
    public static Dictionary<int, List<string>> Invert(
        Dictionary<string, int> input)
    {
        Dictionary<int, List<string>> inverted =
            new Dictionary<int, List<string>>();

        foreach (var pair in input)
        {
            int value = pair.Value;
            string key = pair.Key;

            if (!inverted.ContainsKey(value))
            {
                inverted[value] = new List<string>();
            }

            inverted[value].Add(key);
        }

        return inverted;
    }
}
