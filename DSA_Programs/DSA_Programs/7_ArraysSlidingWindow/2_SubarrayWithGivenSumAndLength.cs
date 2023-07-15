using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysSlidingWindow
{
    /*
        Q1.Subarray with given sum and length

        Problem Description
        Given an array A of length N.Also given are integers B and C.

        Return 1 if there exists a subarray with length B having sum C and 0 otherwise



        Problem Constraints
        1 <= N <= 105

        1 <= A[i] <= 104

        1 <= B <= N

        1 <= C <= 109



        Input Format
        First argument A is an array of integers.

        The remaining arguments B and C are integers



        Output Format
        Return 1 if such a subarray exist and 0 otherwise


        Example Input
        Input 1:
        A = [4, 3, 2, 6, 1]
        B = 3
        C = 11
        Input 2:

        A = [4, 2, 2, 5, 1]
        B = 4
        C = 6


        Example Output
        Output 1:
        1
        Output 2:

        0


        Example Explanation
        Explanation 1:
        The subarray [3, 2, 6] is of length 3 and sum 11.
        Explanation 2:
        There are no such subarray.
      */
    internal class SubarrayWithGivenSumAndLength
    {
        public int solve(List<int> A, int B, int C)
        {
            int n = A.Count;
            List<int> PS = new List<int>();
            int sum = A[0];

            // Prefix sum
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    PS.Add(A[i]);
                }
                else
                {
                    sum += A[i];
                    PS.Add(sum);
                }
            }

            int s = 0;
            int e = n - B;
            while (s <= e)
            {
                if (s == 0 && PS[s + B - 1] == C) return 1;
                else if (s != 0 && (PS[s + B - 1] - PS[s - 1]) == C) return 1;
                s++;
            }
            return 0;
        }
    }
}
