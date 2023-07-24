using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.RandomPrograms
{
    internal class MaximumValuesInArray
    {
        public static int[] FindMax(int[] numbers, int n)
        {
            int len = numbers.Length;
            int itr = 0;
            int[] res;
            int j = 0;

            if (n < len)
            {
                itr = len - n;
                res = new int[n];
            }
            else
            {
                itr = 0;
                res = new int[len];
            }

            Array.Sort(numbers);

            for (int i = len - 1; i >= itr; i--)
            {
                res[j] = numbers[i];
                j++;
            }

            return res;
        }
    }
}
