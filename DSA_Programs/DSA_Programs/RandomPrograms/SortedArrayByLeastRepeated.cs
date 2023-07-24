using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.RandomPrograms
{

    /*
    Given an array of integers , sort the array by the least repeated integers,. if multiple integers have the same number occurences, 
    sort them in descending order. Return the final array. Write the program in c#.
    */
    internal class SortedArrayByLeastRepeated
    {     
        public static int[] solve(int[] arr)
        {
            Dictionary<int, int> occurrenceCount = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (occurrenceCount.ContainsKey(num))
                    occurrenceCount[num]++;
                else
                    occurrenceCount[num] = 1;
            }

            var sorted = arr
                .OrderBy(x => occurrenceCount[x]) // Sort by least repeated
                .ToArray();

            return sorted;
        }
    }
}
