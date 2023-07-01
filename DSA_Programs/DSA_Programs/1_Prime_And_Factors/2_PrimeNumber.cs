using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Programs.DailyOneProgram
{
    /*
        Problem Description:
        Given a number A. Return 1 if A is prime and return 0 if not. 

        Note : 
        The value of A can cross the range of Integer.


        Problem Constraints
        1 <= A <= 1012


        Input Format
        The first argument is a single integer A.


        Output Format
        Return 1 if A is prime else return 0.


        Example Input
        Input 1:
        A = 5
        Input 2:

        A = 10


        Example Output
        Output 1:
        1
        Output 2:

        0


        Example Explanation
        Explanation 1:
        5 is a prime number.
        Explanation 2:

        10 is not a prime number.
    */
    internal class PrimeNumber
    {
        public static int solve(long A)
        {
            if (A < 1 || A > 1000000000000) return 0;

            var countOfFactors = FactorsCount(A);
            if (countOfFactors == 2)
            {
                return 1;
            }
            return 0;
        }

        private static int FactorsCount(long A)
        {
            int i = 1;
            int cnt = 0;

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
