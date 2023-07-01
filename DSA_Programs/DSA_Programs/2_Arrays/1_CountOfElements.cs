using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_Programs.Arrays
{
    /*
    Q1.Count of elements
        Solved
        feature icon
        Using hints is now penalty free
        Use Hint
            Problem Description
            Given an array A of N integers.
        Count the number of elements that have at least 1 elements greater than itself.


        Problem Constraints
        1 <= N <= 105
        1 <= A[i] <= 109


        Input Format
        First and only argument is an array of integers A.


        Output Format
        Return the count of elements.


        Example Input
        Input 1:
        A = [3, 1, 2]
        Input 2:
        A = [5, 5, 3]


        Example Output
        Output 1:
        2
        Output 2:
        1


        Example Explanation
        Explanation 1:
        The elements that have at least 1 element greater than itself are 1 and 2
        Explanation 2:
        The elements that have at least 1 element greater than itself is 3
        */
    internal class CountOfElements
    {
        public static int solve(List<int> A)
        {

            //validate length of N
            int n = A.Count;
            if (n < 1 || n > 100000) return 0;

            //validate elements of A
            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 1000000000) return 0;
            }

            // Find the max
            int max = A[0];    // Assume max = first element of A   
            for (int i = 1; i < n; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }

            // Find the number of elements less than the max 
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] < max)
                {
                    cnt++;
                }
            }

            return cnt;

        }
    }
}


//TC: O(n) : n + n 
// SC: O(1) : All constants terms like n , i. max, cnt;
