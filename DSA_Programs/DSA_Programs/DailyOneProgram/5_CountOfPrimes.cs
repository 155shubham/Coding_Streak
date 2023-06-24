using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Programs.DailyOneProgram
{

    /*
     Problem Description
        You will be given an integer n. You need to return the count of prime numbers less than or equal to n.


        Problem Constraints
        0 <= n <= 10^3


        Input Format
        Single input parameter n in function.


        Output Format
        Return the count of prime numbers less than or equal to n.


        Example Input
        Input 1:
        19
        Input 2:
        1


        Example Output
        Output 1:
        8
        Output 2:
        0


        Example Explanation
        Explanation 1:
        Primes <= 19 are 2, 3, 5, 7, 11, 13, 17, 19
        Explanation 2:
        There are no primes <= 1

    */
    internal class CountOfPrimes
    {
        public static int solve(int A)
        {
            if (A < 0 || A > 1000 || A == 0 || A == 1) return 0;

            int cnt = 0;
            for (int i = 2; i <= A; i++)
            {
                if (IsPrime(i)) cnt++;
            }

            return cnt;
        }

        private static bool IsPrime(int num)
        {
            int factorsCnt = 0;
            int i = 0;

            for (i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    factorsCnt = factorsCnt + 2;
                }
            }
            if ((i - 1) * (i - 1) == num) factorsCnt--;

            if (factorsCnt == 2) return true;

            return false;
        }
    }
}
