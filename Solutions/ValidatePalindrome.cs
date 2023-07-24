using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solutions
{
    public partial class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty);

            char[] array1 = s.ToLower().ToArray();
            char[] array2 = new char[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array2[array1.Length - 1 - i] = array1[i];
            }

            return Enumerable.SequenceEqual(array1, array2);
        }
    }
}