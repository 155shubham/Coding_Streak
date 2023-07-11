using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysCarryForward
{
    internal class SumOfAllSubArrays
    {
        public long subarraySum(List<int> A)
        {
            int n = A.Count;

            if (n < 1 || n > 100000) return 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 10000) return 0;
            }

            long totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                totalSum += (long)A[i] * (i + 1) * (n - i);
            }

            return totalSum;
        }
    }
}
