using System;
using System.Collections.Generic;
using System.Linq;

namespace HorspoolAlgorithm
{
    public static class Horspool
    {
        private static Dictionary<char, int> ShiftTable(string pattern, string text)
        {
            Dictionary<char, int> table = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!table.Keys.Contains(text[i]))
                    table.Add(text[i], pattern.Length);
            }

            for (int j = 0; j < pattern.Length - 1; j++)
            {
                table[pattern[j]] = pattern.Length - 1 - j;
            }

            return table;
        }

        public static int HorspoolMatching(string pattern, string text)
        {
            if (pattern.Length > text.Length)
                return -1;

            if (pattern.Except(text).Any())
                return -1;

            var table = ShiftTable(pattern,text);

            var i = pattern.Length - 1;

            while (i < text.Length)
            {
                var k = 0;
                while (k < pattern.Length && pattern[pattern.Length -1 - k] == text[i - k])
                {
                    k += 1;
                }
                if (k == pattern.Length)
                {
                    return i - pattern.Length + 1;
                }
                else
                {
                    i += table[text[i]];
                }
            }
            return -1;
        }
    }
}
