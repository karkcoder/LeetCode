using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
	public class StrStrSolution
	{
		public int StrStr(string haystack, string needle)
		{
			if (haystack.Length == 0 || needle.Length == 0)
				return 0;

			for (int i = 0; i < haystack.Length; i++)
			{
				if ((haystack.Length - i) >= needle.Length)
				{
					if (haystack.Substring(i, needle.Length) == needle)
					{
						return i;
					}
				}
				else
					return 0;
			}
			return -1;
		}
	}
}
