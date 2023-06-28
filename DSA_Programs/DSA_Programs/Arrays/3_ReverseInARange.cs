using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays
{

    /*
    Q3. Reverse in a range
    Given an array A of N integers and also given two integers B and C. Reverse the elements of the array A within the given inclusive range [B, C].


    Problem Constraints
    1 <= N <= 105
    1 <= A[i] <= 109
    0 <= B <= C <= N - 1


    Input Format
    The first argument A is an array of integer.
    The second and third arguments are integers B and C


    Output Format
    Return the array A after reversing in the given range.


    Example Input
    Input 1:

    A = [1, 2, 3, 4]
    B = 2
    C = 3
    Input 2:

    A = [2, 5, 6]
    B = 0
    C = 2


    Example Output
    Output 1:

    [1, 2, 4, 3]
    Output 2:

    [6, 5, 2]


    Example Explanation
    Explanation 1:

    We reverse the subarray [3, 4].
    Explanation 2:

    We reverse the entire array [2, 5, 6].
    */
    internal class ReverseInARange
    {
        public static List<int> solve_for_specific_range(List<int> A, int B, int C)
        {
            int i = B;
            int j = C;
            int temp = 0;

            while (i <= j)
            {
                temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i++;
                j--;
            }

            return A;
        }


        //the following is generic program b = 0 and c = n - 1
        public static List<int> solve_for_all(List<int> A)
        {
            int n = A.Count;
            int i = 0;
            int j = n - 1;
            int temp = 0;

            while (i < j)
            {
                temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i++; ;
                j--; ;
            }

            return A;
        }
    }
}


// TC: O(N)
// SC: O(1)