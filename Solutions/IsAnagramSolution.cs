using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    public partial class Solution
    {
        //242. Valid Anagram
        //Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        //Example 1:

        //Input: s = "anagram", t = "nagaram"
        //Output: true

        //Example 2:

        //Input: s = "rat", t = "car"
        //Output: false

        //Constraints:

        //1 <= s.length, t.length <= 5 * 104
        //s and t consist of lowercase English letters.

        public bool IsAnagram(string s, string t)
        {
            if (s == t) return true; // lets not even proceed if the string are the same
            if (s.Length != t.Length) return false; // let not proceed if the length of the string does not match

            //convert string to char array
            char[] set1 = s.ToCharArray();
            char[] set2 = t.ToCharArray();

            Array.Sort(set1);
            Array.Sort(set2);

            return Enumerable.SequenceEqual(set1, set2);
        }
    }
}