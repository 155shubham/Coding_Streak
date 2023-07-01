using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays
{
    /*

    Q2. Linear Search - Multiple Occurences
    Solved
    feature icon
    Using hints is now penalty free
    Use Hint
    Problem Description

    Given an array A and an integer B, find the number of occurrences of B in A.


    Problem Constraints

    1 <= B, Ai <= 109
    1 <= |A| <= 105


    Input Format

    Given an integer array A and an integer B.


    Output Format

    Return an integer, number of occurrences of B in A.


    Example Input

    Input 1:
     A = [1, 2, 2], B = 2 
    Input 2:
     A = [1, 2, 1], B = 3 


    Example Output

    Output 1:
     2
    Output 2:
     0


    Example Explanation

    Explanation 1:
    Element at index 2, 3 is equal to 2 hence count is 2.
    Explanation 2:
    There is no element equal to 3 in the array.

    */
    internal class LinearSearchMultipleOccurences
    {
        public static int solve(List<int> A, int B)
        {
            int n = A.Count;

            if (n < 1 || n > 100000 || B < 1 || B > 1000000000) return 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 1000000000) return 0;
            }

            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (B == A[i])
                {
                    cnt++;
                }
            }

            return cnt;
        }
    }
}


// TC: O(n)
// OC: O(1)