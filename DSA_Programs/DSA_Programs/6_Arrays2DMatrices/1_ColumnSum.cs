using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays2DMatrices
{

    /*
    Q1. Column Sum

    Problem Description:
    You are given a 2D integer matrix A, return a 1D integer array containing column-wise sums of original matrix.

    Problem Constraints
    1 <= A.size() <= 103

    1 <= A[i].size() <= 103

    1 <= A[i][j] <= 103

    Input Format
    First argument is a 2D array of integers.(2D matrix).

    Output Format
    Return an array containing column-wise sums of original matrix.

    Example Input
    Input 1:

    [1,2,3,4]
    [5,6,7,8]
    [9,2,3,4]

    Example Output
    Output 1:

    {15,10,13,16}

    Example Explanation
    Explanation 1

    Column 1 = 1+5+9 = 15
    Column 2 = 2+6+2 = 10
    Column 3 = 3+7+3 = 13
    Column 4 = 4+8+4 = 16
    */
    internal class ColumnSum
    {
        public static List<int> solve(List<List<int>> A)
        {
            int n = A.Count;
            int m = A[0].Count;
            List<int> res = new List<int>();

            if (n < 1 || n > 1000 || m < 1 || m > 1000) return res;


            ////Commented this as this was throwing error while solving the
            //  for (int r = 0; r < n; r++) {
            //     for (int c = 0; c < m; c++) {
            //         if (A[r][c] < 1 || A[r][c] > 1000) return res;
            //     }
            // }

            for (int c = 0; c < m; c++)
            {
                int sum = 0;
                for (int r = 0; r < n; r++)
                {
                    sum += A[r][c];
                }
                res.Add(sum);
            }

            return res;
        }
    }
}
