using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysPrefixSum
{
    /*
    Q3. Range Sum Query

    Problem Description
    You are given an integer array A of length N.
    You are also given a 2D integer array B with dimensions M x 2, where each row denotes a [L, R] query.
    For each query, you have to find the sum of all elements from L to R indices in A (0 - indexed).
    More formally, find A[L] + A[L + 1] + A[L + 2] +... + A[R - 1] + A[R] for each query.



    Problem Constraints
    1 <= N, M <= 105
    1 <= A[i] <= 109
    0 <= L <= R < N


    Input Format
    The first argument is the integer array A.
    The second argument is the 2D integer array B.


    Output Format
    Return an integer array of length M where ith element is the answer for ith query in B.


    Example Input
    Input 1:
    A = [1, 2, 3, 4, 5]
    B = [[0, 3], [1, 2]]
    Input 2:

    A = [2, 2, 2]
    B = [[0, 0], [1, 2]]


    Example Output
    Output 1:
    [10, 5]
    Output 2:

    [2, 4]


    Example Explanation
    Explanation 1:
    The sum of all elements of A[0 ... 3] = 1 + 2 + 3 + 4 = 10.
    The sum of all elements of A[1 ... 2] = 2 + 3 = 5.
    Explanation 2:

    The sum of all elements of A[0 ... 0] = 2 = 2.
    The sum of all elements of A[1 ... 2] = 2 + 2 = 4.

    */
    internal class RangeSumQuery
    {
        public static List<long> rangeSum(List<int> A, List<List<int>> B)
        {

            List<long> resLst = new List<long>(); // to store the result
            List<long> PS = new List<long>(); // To store the prefix sum
            int n = A.Count;
            int m = B.Count;

            // Constratint validation
            if (n < 1 || n > 100000 || m < 1 || m > 100000) return resLst;

            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 1000000000) return resLst;
            }

            // Find the Prefix sum to pickup
            PS.Add(A[0]);
            for (int i = 1; i < n; i++)
            {
                PS.Add(PS[i - 1] + A[i]);
            }

            int leftQuery = 0; // L
            int rightQuery = 0; // R     
            for (int j = 0; j < m; j++)
            {
                leftQuery = B[j][0];
                rightQuery = B[j][1];

                if (leftQuery >= 0 && leftQuery < n && rightQuery >= 0 && rightQuery < n && leftQuery <= rightQuery)
                {
                    if (leftQuery == 0) resLst.Add(PS[rightQuery]);
                    else resLst.Add(PS[rightQuery] - PS[leftQuery - 1]);
                }
            }

            return resLst;
        }
    }
}


// The return type should be long the as the result can be more than integer range because the values of A array are till 10^9.

// TC: O(n + n) --> O(2n) --> O(n)
//SC: O(n+n) --> O(2n) -- > O(n) [two new arraya are created hence n + n]