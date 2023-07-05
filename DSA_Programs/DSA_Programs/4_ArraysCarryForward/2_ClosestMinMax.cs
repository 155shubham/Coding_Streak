using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysCarryForward
{

    /*
    
    Q3. Closest MinMax

    Problem Description
    Given an array A, find the size of the smallest subarray such that it contains at least one occurrence of the maximum value of the array

    and at least one occurrence of the minimum value of the array.



    Problem Constraints
    1 <= |A| <= 2000



    Input Format
    First and only argument is vector A



    Output Format
    Return the length of the smallest subarray which has at least one occurrence of minimum and maximum element of the array



    Example Input
    Input 1:

    A = [1, 3, 2]
    Input 2:

    A = [2, 6, 1, 6, 9]


    Example Output
    Output 1:

     2
    Output 2:

     3


    Example Explanation
    Explanation 1:

     Take the 1st and 2nd elements as they are the minimum and maximum elements respectievly.
    Explanation 2:

     Take the last 3 elements of the array.
    */
    internal class ClosestMinMax
    {
        public static int solve(List<int> A)
        {
            int n = A.Count;

            // min and min
            int min = A[0];
            int max = A[0];
            for (int i = 1; i < n; i++)
            {
                if (A[i] < min) min = A[i];
                if (A[i] > max) max = A[i];
            }

            int maxIndex = -1;
            int minIndex = -1;
            int ans = n; // store the max value greater than the length of the array
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == min) minIndex = i;
                if (A[i] == max) maxIndex = i;
                if (minIndex > -1 && maxIndex > -1)
                {
                    temp = (Math.Max(minIndex, maxIndex) - Math.Min(minIndex, maxIndex)) + 1;
                    if (temp < ans) ans = temp;
                }

            }

            return ans;
        }
    }
}
