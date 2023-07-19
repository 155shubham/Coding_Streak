using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Bit_Manipulations
{

    /*
    Q7. Any base to decimal

    Problem Description
    You are given a number A. You are also given a base B. A is a number on base B.
    You are required to convert the number A into its corresponding value in decimal number system.

    Problem Constraints
    0 <= A <= 109
    2 <= B <= 9

    Input Format
    First argument A is an integer.
    Second argument B is an integer.

    Output Format
    Return an integer.

    Example Input
    Input 1:
    A = 1010
    B = 2
    Input 2:
    A = 22 
    B = 3

    Example Output
    Output 1:
    10
    Output 2:
    8

    Example Explanation
    For Input 1:
    The decimal 10 in base 2 is 1010.
    For Input 2:
    The decimal 8 in base 3 is 22.

    */

    internal class AnyBaseToDecimal
    {
        public static int solve(int A, int B)
        {
            string numStr = A.ToString();
            int len = numStr.Length;
            int numDNS = 0;
            int digit = 0;

            for (int i = 0; i < len; i++)
            {
                digit = (int)Char.GetNumericValue(numStr[len-1-i]);
                numDNS += (digit * (int)Math.Pow(B, i));
            }

            return numDNS;
        }
    }
}
