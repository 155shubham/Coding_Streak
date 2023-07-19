using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays2DMatrices
{
    internal class AntiDiagonals
    {
        public static List<List<int>> diagonal(List<List<int>> A)
        {
            int n = A.Count;
            int m = A[0].Count;
            int numOfAntiDiagonals = 2 * n - 1;

            List<List<int>> res = new List<List<int>>();

            for (int i = 0; i < numOfAntiDiagonals; i++)
            {
                res.Add(new List<int>(new int[n]));
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    res[i + j][i] = A[i][j];
                }
                for (int j = n - i, k = 1; j < n; j++, k++)
                {
                    res[i + j][i - k] = A[i][j];
                }
            }
            return res;

            ////n times
            //int x = 0, y = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    x = i;
            //    y = 0;
            //    for (int j = 0; j <= i; j++)
            //    {
            //        res[x][y] = A[j][i - j];
            //        y++;
            //    }
            //}

            ////n-1 times
            //x = n;
            //for (int i = n-1; i>0; i--)
            //{
            //    y = 0;

            //    while ()
            //    {
            //        res[x][y] = A[j][i+1-j];
            //        y++;
            //    }
            //    x++;
            //    j++;
            //}

            //return res;
        }
    }
}
