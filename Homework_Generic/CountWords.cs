using System;
using System.Collections.Generic;

class CountWords
{
    private static Dictionary<string, uint> dict;

    public
    CountWords()
    {
        dict = new Dictionary<string, uint>();
    }

    public void
    AddWord(string word)
    {
        if (dict.ContainsKey(word))
        {
            dict[word] += 1;
        }
        else
        {
            dict.Add(word, 1);
        }
    }

    public void
    PrintStats()
    {
        foreach (var i in dict)
        {
            Console.WriteLine("Word {0} appears {1} times.", i.Value, i.Key);
        }
    }
}

