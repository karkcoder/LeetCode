using System.Collections.Generic;

namespace Solutions
{
    //217: Contains Duplicate
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();

            foreach (int num in nums)
            {
                if (hash.Contains(num)) return true;
                hash.Add(num);
            }
            return false;
        }

    }
}
