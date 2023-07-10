using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays2DMatrices
{

    /*
    Q2. Row Sum

    Problem Constraints
    1 <= A.size() <= 103

    1 <= A[i].size() <= 103

    1 <= A[i][j] <= 103



    Input Format
    First argument A is a 2D array of integers.(2D matrix).



    Output Format
    Return an array containing row-wise sums of original matrix.



    Example Input
    Input 1:

    [1,2,3,4]
    [5,6,7,8]
    [9,2,3,4]


    Example Output
    Output 1:

    [10,26,18]


    Example Explanation
    Explanation 1

    Row 1 = 1+2+3+4 = 10
    Row 2 = 5+6+7+8 = 26
    Row 3 = 9+2+3+4 = 18


    */
    internal class RowSum
    {
        public List<int> solve(List<List<int>> A)
        {
            int n = A.Count;
            int m = A[0].Count;
            List<int> res = new List<int>();

            if (n < 1 || n > 1000 || m < 1 || m > 1000) return res;

            for (int r = 0; r < n; r++)
            {
                int sum = 0;
                for (int c = 0; c < m; c++)
                {
                    sum += A[r][c];
                }
                res.Add(sum);
            }
            return res;
        }
    }
}
