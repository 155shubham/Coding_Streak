using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysSubArrays
{

    /*
    Q5. Maximum Subarray Easy
    Problem Description
    You are given an integer array C of size A. Now you need to find a subarray (contiguous elements) so that the sum of contiguous elements is maximum.
    But the sum must not exceed B.


    Problem Constraints
    1 <= A <= 103
    1 <= B <= 109
    1 <= C[i] <= 106


    Input Format
    The first argument is the integer A.
    The second argument is the integer B.
    The third argument is the integer array C.


    Output Format
    Return a single integer which denotes the maximum sum.


    Example Input
    Input 1:
    A = 5
    B = 12
    C = [2, 1, 3, 4, 5]
    Input 2:

    A = 3
    B = 1
    C = [2, 2, 2]


    Example Output
    Output 1:
    12
    Output 2:

    0


    Example Explanation
    Explanation 1:
    We can select {3,4,5} which sums up to 12 which is the maximum possible sum.
    Explanation 2:

    All elements are greater than B, which means we cannot select any subarray.
    Hence, the answer is 0.

    */
    internal class MaximumSubArrays
    {
        public static int maxSubarray(int A, int B, List<int> C)
        {
            if (A < 1 || A > 1000 || B < 1 || B > 1000000000) return 0;

            for (int i = 0; i < A; i++)
            {
                if (C[i] < 1 || C[i] > 1000000) return 0;
            }

            int ans = 0;
            for (int i = 0; i < A; i++)
            {
                int sumOfEachSubArray = 0;
                for (int j = i; j < A; j++)
                {
                    sumOfEachSubArray += C[j];
                    if (sumOfEachSubArray <= B && sumOfEachSubArray >= ans) ans = sumOfEachSubArray;
                }
            }

            return ans;
        }
    }
}
