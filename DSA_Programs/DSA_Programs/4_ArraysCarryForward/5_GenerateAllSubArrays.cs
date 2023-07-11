using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysCarryForward
{
    internal class GenerateAllSubArray
    {
        public List<List<int>> solve(List<int> A)
        {
            int n = A.Count;
            List<List<int>> res = new List<List<int>>();

            if (n < 1 || n > 100) return new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 100000) return new List<List<int>>();
            }

            for (int i = 0; i < n; i++)
            {

                for (int j = i; j < n; j++)
                {
                    List<int> lst3 = new List<int>();
                    for (int k = i; k <= j; k++)
                    {
                        lst3.Add(A[k]);
                    }
                    res.Add(lst3);
                }
            }

            return res;
        }
    }
}
