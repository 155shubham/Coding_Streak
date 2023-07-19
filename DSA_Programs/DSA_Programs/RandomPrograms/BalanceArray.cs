using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.RandomPrograms
{
    internal class BalanceArray
    {
        public static int solve(List<int?> A)
        {
            A.RemoveAll(x => x == null);

            int len = A.Count;

            if (len < 1 || len > 100000) return 0;


            for (int i = 0; i < len; i++)
            {
                if (A[i] < 1 || A[i] > 1000000000)
                {
                    return 0;
                }
            }

            List<int?> subLst = new List<int?>();
            int cnt = 0;
            int specialElementIndex = 0;

            while (specialElementIndex < len)
            {
                for (int i = 0; i < len; i++)
                {
                    if (specialElementIndex != i)
                    {
                        subLst.Add(A[i]);
                    }
                }

                int? diff = FindDifferenceBetnEvenSumAndOddSum(subLst);
                if (diff == 0) cnt++;
                specialElementIndex++;
                subLst.Clear();
            }

            return cnt;
        }

        private static int? FindDifferenceBetnEvenSumAndOddSum(List<int?> A)
        {
            int? evenSum = 0;
            int? oddSum = 0;
            int? len = A.Count;

            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0) evenSum += A[i]; else oddSum += A[i];
            }

            return evenSum > oddSum ? evenSum - oddSum : oddSum - evenSum;
        }
    }
}
