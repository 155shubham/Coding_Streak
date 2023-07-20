using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.BitManipulations1
{
    /*
    Q8. Decimal to Any Base

    Problem Description
    Given a decimal number A and a base B, convert it into its equivalent number in base B.


    Problem Constraints
    0 <= A <= 512
    2 <= B <= 10


    Input Format
    The first argument will be decimal number A.
    The second argument will be base B.


    Output Format
    Return the conversion of A in base B.


    Example Input
    Input 1:
    A = 4
    B = 3
    Input 2:
    A = 4
    B = 2 


    Example Output
    Output 1:
    11
    Output 2:
    100


    Example Explanation
    Explanation 1:
    Decimal number 4 in base 3 is 11.
    Explanation 2:
    Decimal number 4 in base 2 is 100. 


    */
    internal class DecimalToAnyBase
    {
        public static int solve(int A, int B)
        {
            int sum = 0;
            int pos = 1;

            while (A > 0)
            {
                sum += ((A % B) * pos);
                pos *= 10;
                A /= B;
            }

            return sum;
        }
    }
}
