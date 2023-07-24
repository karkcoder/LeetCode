using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Solutions
{
    public partial class Solution
    {
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        //An input string is valid if:

        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Every close bracket has a corresponding open bracket of the same type.

        //Example 1:

        //Input: s = "()"
        //Output: true

        //Example 2:

        //Input: s = "()[]{}"
        //Output: true

        //Example 3:

        //Input: s = "(]"
        //Output: false

        public bool IsValid(string s)
        {
            //If there is only one character, why even bother doing a test, return false immediately
            if (s.Length <= 1)
            {
                return false;
            }

            char[] chars = s.ToCharArray();
            Stack stack = new Stack();
            Dictionary<char, char> keyValues = new Dictionary<char, char>  //creating a dictionary so that keys are opening brackets and values are closing brackets
            {
                { '{', '}' },
                { '(', ')' },
                { '[', ']' }
            };

            foreach (var c in chars)
            {
                if (keyValues.ContainsKey(c)) // if there are opening bracket, add to stack
                {
                    stack.Push(c);
                }
                else if (keyValues.ContainsValue(c) && stack.Count == 0) //edge case if the string starts with closing bracket
                {
                    return false;
                }
                else // if c is not an opening bracket and the stack already has some value, then peek the last value and see if it matches its value, if it does not, exist, if it does, pop the stack and move on to the next character
                {
                    var key = stack.Peek();
                    if (!keyValues.GetValueOrDefault((char)key).Equals(c))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}