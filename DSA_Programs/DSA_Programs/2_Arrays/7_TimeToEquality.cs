using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays
{

    /*
    Q3. Time to equality
    Unsolved
    feature icon
    Using hints is now penalty free
    Use Hint
    Problem Description
    Given an integer array A of size N. In one second, you can increase the value of one element by 1.

    Find the minimum time in seconds to make all elements of the array equal.


    Problem Constraints
    1 <= N <= 1000000
    1 <= A[i] <= 1000


    Input Format
    First argument is an integer array A.


    Output Format
    Return an integer denoting the minimum time to make all elements equal.


    Example Input
    A = [2, 4, 1, 3, 2]


    Example Output
    8


    Example Explanation
    We can change the array A = [4, 4, 4, 4, 4]. The time required will be 8 seconds.

    */
    internal class TimeToEquality
    {
        public static int solve(List<int> A)
        {
            int n = A.Count;

            if (n < 1 || n > 1000000) return 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 1000) return 0;
            }

            int max = A[0];
            for (int i = 1; i < n; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }

            int secondsCnt = 0;
            for (int i = 0; i < n; i++)
            {
                secondsCnt = secondsCnt + (max - A[i]);
            }

            return secondsCnt;
        }
    }
}


// TC: O(n)
// OC: O(1)