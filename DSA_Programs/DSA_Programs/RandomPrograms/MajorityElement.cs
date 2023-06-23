using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Programs.Random
{
    internal class MajorityElement
    {
        public int FindMajorityElement(List<int> A)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int value = 0;

            foreach (int item in A)
            {
                dict[item] = dict.TryGetValue(item, out value) ? ++value : 1;
            }

            foreach (var item in dict)
            {
                if (item.Value > A.Count / 2)
                {
                    return item.Key;
                }
            }

            return -1;
        }
    }
}
