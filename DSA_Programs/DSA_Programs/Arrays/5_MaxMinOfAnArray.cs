using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays
{
    /*
     Q1. Max Min of an Array
    Unsolved
    feature icon
    Using hints is now penalty free
    Use Hint
    Problem Description
    Given an array A of size N. You need to find the sum of Maximum and Minimum element in the given array.


    Problem Constraints
    1 <= N <= 105
    -109 <= A[i] <= 109


    Input Format
    First argument A is an integer array.


    Output Format
    Return the sum of maximum and minimum element of the array


    Example Input
    Input 1:

    A = [-2, 1, -4, 5, 3]
    Input 2:

    A = [1, 3, 4, 1]


    Example Output
    Output 1:

    1
    Output 2:

    5


    Example Explanation
    Explanation 1:

    Maximum Element is 5 and Minimum element is -4. (5 + (-4)) = 1. 
    Explanation 2:

    Maximum Element is 4 and Minimum element is 1. (4 + 1) = 5.
      
     */
    internal class MaxMinOfAnArray
    {
        public static int solve(List<int> A)
        {
            int n = A.Count;

            if (n < 1 || n > 100000) return 0;

            for (int i = 0; i > n; i++)
            {
                if (A[i] < -10000000000 || A[i] > 1000000000) return 0;
            }

            int max = A[0]; // we should not take it as zero because no's in array can be negative also
            for (int i = 1; i < n; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }

            int min = A[0]; // we should not take it as zero because no's in array can be negative also
            for (int i = 1; i < n; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }

            return max + min;
        }
    }
}
