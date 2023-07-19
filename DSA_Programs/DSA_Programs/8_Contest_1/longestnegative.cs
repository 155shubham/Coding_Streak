using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.contest
{
    internal class longestnegative
    {
        public static int solve(List<int> A)
        {
            int n = A.Count;
            int len = 0;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] < 0)
                {
                    len++;
                    ans = Math.Max(ans, len);
                }
                else
                {
                    len = 0;
                }
            }

            return ans;
        }
    }
}
