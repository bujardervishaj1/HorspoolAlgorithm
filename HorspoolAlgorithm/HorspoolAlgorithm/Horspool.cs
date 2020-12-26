using System;
using System.Collections.Generic;
using System.Linq;

namespace HorspoolAlgorithm
{
    public class Horspool
    {
        private readonly string _pattern;

        private readonly string _text;

        public Horspool(string pattern, string text)
        {
            this._pattern = pattern;
            this._text = text;
        }

        private Dictionary<char, int> ShiftTable()
        {
            Dictionary<char, int> table = new Dictionary<char, int>();

            for (int i = 0; i < _text.Length; i++)
            {
                if (!table.Keys.Contains(_text[i]))
                    table.Add(_text[i], _pattern.Length);
            }

            for (int j = 0; j < _pattern.Length - 1; j++)
            {
                table[_pattern[j]] = _pattern.Length - 1 - j;
            }

            return table;
        }

        public int HorspoolMatching()
        {
            var table = ShiftTable();

            var i = _pattern.Length - 1;

            while (i < _text.Length)
            {
                var k = 0;
                while (k < _pattern.Length && _pattern[_pattern.Length -1 - k] == _text[i - k])
                {
                    k += 1;
                }
                if (k == _pattern.Length)
                {
                    return i - _pattern.Length + 1;
                }
                else
                {
                    i += table[_text[i]];
                }
            }
            return -1;
        }
    }
}
