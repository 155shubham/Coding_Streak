using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysPrefixSum
{

    /*
    Q6. Even numbers in a range

    Problem Description
    You are given an array A of length N and Q queries given by the 2D array B of size Q×2.

    Each query consists of two integers B[i][0] and B[i][1].

    For every query, your task is to find the count of even numbers in the range from A[B[i][0]] to A[B[i][1]].



    Problem Constraints
    1 <= N <= 105
    1 <= Q <= 105
    1 <= A[i] <= 109
    0 <= B[i][0] <= B[i][1] < N


    Input Format
    First argument A is an array of integers.
    Second argument B is a 2D array of integers.


    Output Format
    Return an array of integers.


    Example Input
    Input 1:
    A = [1, 2, 3, 4, 5]
    B = [   [0, 2] 
            [2, 4]
            [1, 4]   ]
    Input 2:
    A = [2, 1, 8, 3, 9, 6]
    B = [   [0, 3]
            [3, 5]
            [1, 3] 
            [2, 4]   ]


    Example Output
    Output 1:
    [1, 1, 2]
    Output 2:
    [2, 1, 1, 1]


    Example Explanation
    For Input 1:
    The subarray for the first query is [1, 2, 3] (index 0 to 2) which contains 1 even number.
    The subarray for the second query is [3, 4, 5] (index 2 to 4) which contains 1 even number.
    The subarray for the third query is [2, 3, 4, 5] (index 1 to 4) which contains 2 even numbers.
    For Input 2:
    The subarray for the first query is [2, 1, 8, 3] (index 0 to 3) which contains 2 even numbers.
    The subarray for the second query is [3, 9, 6] (index 3 to 5) which contains 1 even number.
    The subarray for the third query is [1, 8, 3] (index 1 to 3) which contains 1 even number.
    The subarray for the fourth query is [8, 3, 9] (index 2 to 4) which contains 1 even number.


    */
    internal class EvenNumbersInARange
    {
        public static List<int> solve(List<int> A, List<List<int>> B)
        {
            int n = A.Count;
            int q = B.Count;
            List<int> ansLst = new List<int>();

            if (n < 1 || n > 100000 || q < 1 || q > 100000) return ansLst;

            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 1000000000) return ansLst;
            }

            for (int i = 0; i < q; i++)
            {
                if (B[i][0] < 0 || B[i][0] >= n || B[i][1] < 0 || B[i][1] >= n || B[i][0] > B[i][1]) return ansLst;
            }

            int cnt = 0;
            List<int> evenPS = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (A[i] % 2 == 0)
                {
                    cnt++;
                }
                evenPS.Add(cnt);
            }

            for (int i = 0; i < q; i++)
            {
                if (B[i][0] == 0) ansLst.Add(evenPS[B[i][1]]);
                else ansLst.Add(evenPS[B[i][1]] - evenPS[B[i][0] - 1]);
            }

            return ansLst;
        }
    }
}


// TC: O(n)
//  SC: O(n)