using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Programs.DailyOneProgram
{
    /*

        Problem Description:

        Given a number A. Return square root of the number if it is perfect square otherwise return -1.

        Note: A number is a perfect square if its square root is an integer.

        Problem Constraints

        1 <= A <= 108
        Input Format

        First and the only argument is an integer A.
        Output Format

        Return an integer which is the square root of A if A is perfect square otherwise return -1.
        Example Input

        Input 1:
        A = 4
        Input 2:

        A = 1001
        Example Output

        Output 1:
        2
        Output 2:

        -1
        Example Explanation

        Explanation 1:
        sqrt(4) = 2
        Explanation 2:

        1001 is not a perfect square.

    */
    internal class SquareRoot
    {
        public static int solve(int A)
        {

            if (A < 1 | A > 100000000) return -1;

            int x = 1;
            
            for (x = 1; x <= Math.Sqrt(A); x++)
            {
                if (x * x == A)
                {
                    return x;
                }
            }
            // int i = 1;
            // while (i < A) {
            //     if (i * i == A) {
            //         return i;
            //     }
            // }
            return -1;
        }
    }
}
