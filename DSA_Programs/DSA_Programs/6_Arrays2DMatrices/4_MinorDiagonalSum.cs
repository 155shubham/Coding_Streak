using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays2DMatrices
{

    /*
    Q4. Minor Diagonal Sum
    Solved
    feature icon
    Using hints is now penalty free
    Use Hint
    Problem Description
    You are given a N X N integer matrix. You have to find the sum of all the minor diagonal elements of A.

    Minor diagonal of a M X M matrix A is a collection of elements A[i, j] such that i + j = M + 1 (where i, j are 1-based).



    Problem Constraints
    1 <= N <= 103

    -1000 <= A[i][j] <= 1000



    Input Format
    First and only argument is a 2D integer matrix A.



    Output Format
    Return an integer denoting the sum of minor diagonal elements.



    Example Input
    Input 1:

     A = [[1, -2, -3],
          [-4, 5, -6],
          [-7, -8, 9]]
    Input 2:

     A = [[3, 2],
          [2, 3]]


    Example Output
    Output 1:

     -5 
    Output 2:

     4 


    Example Explanation
    Explanation 1:

     A[1][3] + A[2][2] + A[3][1] = (-3) + 5 + (-7) = -5
    Explanation 2:

     A[1][2] + A[2][1] = 2 + 2 = 4

    */
    internal class MinorDiagonalSum
    {
        public static int solve(List<List<int>> A)
        {
            int n = A.Count;
            int m = A[0].Count;
            int sum = 0;

            for (int r = 0; r < n; r++)
            {
                sum += A[r][(n-1) - r];
            }

            return sum;
        }
    }
}


// The Minor Diagonal Elements are the ones that occur from Top Right of Matrix Down To Bottom Left Corner. Also known as Secondary Diagonal.
// r+j = n+1 => j = n+1-j but if r & j are  0 based then r + j = n-1 => j = (n-1) - r