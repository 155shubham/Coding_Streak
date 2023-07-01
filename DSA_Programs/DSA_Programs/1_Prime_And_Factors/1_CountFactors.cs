using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Programs.DailyOneProgram
{

    /*
        Problem Description:
        Given an integer A, you need to find the count of it's factors.

        Factor of a number is the number which divides it perfectly leaving no remainder.

        Example : 1, 2, 3, 6 are factors of 6


        Problem Constraints
        1 <= A <= 109


        Input Format
        First and only argument is an integer A.


        Output Format
        Return the count of factors of A.


        Example Input
        Input 1:
        5
        Input 2:
        10


        Example Output
        Output 1:
        2
        Output 2:
        4


        Example Explanation
        Explanation 1:
        Factors of 5 are 1 and 5.
        Explanation 2:
        Factors of 10 are 1, 2, 5 and 10.
    */
    internal class CountFactors
    {
        public static int solve(int A)
        {
            int i = 1;
            int cnt = 0;

            if (A < 1 || A > 1000000000) return 0;

            while (i <= Math.Sqrt(A))
            {
                if (A % i == 0)
                {
                    cnt = cnt + 2;
                }
                i++;
            }

            if ((i - 1) * (i - 1) == A)
            {
                cnt--;
            }

            return cnt;
        }
    }
}
