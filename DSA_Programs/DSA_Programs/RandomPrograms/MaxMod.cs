using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.RandomPrograms
{
    internal class MaxMod
    {
        public static int solve(List<int> A)
        {
            int len = A.Count;
            if (len < 1 || len > 100000) return 0;

            for (int i = 0; i < len; i++)
            {
                if (A[i] < 0 || A[i] > 100000)
                {
                    return 0;
                }

            }

            int temp = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (A[i] % A[j] > temp)
                    {
                        temp = A[i] % A[j];
                    }
                }
            }

            return temp;
        }
    }
}
