using System;
using System.Collections.Generic;

namespace Angram_Difference
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> a = new List<string> { "a", "jk", "abb", "mn", "abc" };
      List<string> b = new List<string> { "bb", "kj", "bbc", "op", "def" };
      var result = GetMinimumDifference(a, b);
      Console.WriteLine(string.Join(",", result));
    }
    public static List<int> GetMinimumDifference(List<string> a, List<string> b)
    {
      string s1, s2;
      List<int> result = new List<int>();
      int length = a.Count, i = 0;
      while (i < length)
      {
        s1 = a[i];
        s2 = b[i];
        result.Add(countManipulations(s1, s2));
        i++;
      }
      return result;
    }

    static int countManipulations(string s1,
                                  string s2)
    {
      if (s1.Length != s2.Length) return -1;
      int count = 0;

      // store the count of character
      int[] char_count = new int[26];

      // iterate though the first String
      // and increase the count.
      for (int i = 0; i < s1.Length; i++)
        char_count[s1[i] - 'a']++;

      // iterate through the second string
      // decrease the count.
      for (int i = 0; i < s2.Length; i++)
        char_count[s2[i] - 'a']--;

      for (int i = 0; i < 26; ++i)
      {
        if (char_count[i] != 0)
        {
          count += Math.Abs(char_count[i]);
        }
      }

      return count / 2;
    }
  }
}
