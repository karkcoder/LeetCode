using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> list = new List<char>();
            foreach(char c in s)
            {
                if (!list.Contains(c))
                {
                    list.Add(c);
                }
            }
            return list.Count;

        }
    }
}
