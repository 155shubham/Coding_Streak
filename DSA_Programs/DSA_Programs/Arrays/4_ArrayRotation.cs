using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays
{
    /*
    4. Array Rotation
    Unsolved
    feature icon
    Using hints is now penalty free
    Use Hint
    Problem Description
    Given an integer array A of size N and an integer B, you have to return the same array after rotating it B times towards the right.


    Problem Constraints
    1 <= N <= 105
    1 <= A[i] <=109
    1 <= B <= 109


    Input Format
    The first argument given is the integer array A.
    The second argument given is the integer B.


    Output Format
    Return the array A after rotating it B times to the right


    Example Input
    Input 1:

    A = [1, 2, 3, 4]
    B = 2
    Input 2:

    A = [2, 5, 6]
    B = 1


    Example Output
    Output 1:

    [3, 4, 1, 2]
    Output 2:

    [6, 2, 5]


    Example Explanation
    Explanation 1:

    Rotate towards the right 2 times - [1, 2, 3, 4] => [4, 1, 2, 3] => [3, 4, 1, 2]
    Explanation 2:

    Rotate towards the right 1 time - [2, 5, 6] => [6, 2, 5]
    */
    internal class ArrayRotation
    {
        public static List<int> solve(List<int> A, int B)
        {
            int n = A.Count;

            if (n < 1 || n > 100000 || B < 1 || B > 1000000000) return new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 1000000000) return new List<int>();
            }

            // Imp to look upon which covers one of the test case when B is greater than n
            if (B > n) B = B % n;

            A = reverseArray(A, 0, n - 1);
            A = reverseArray(A, 0, B - 1);
            A = reverseArray(A, B, n - 1);

            return A;
        }

        private static List<int> reverseArray(List<int> arr, int x, int y)
        {
            int i = x, j = y, temp = 0;
            while (i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            return arr;
        }
    }
}
