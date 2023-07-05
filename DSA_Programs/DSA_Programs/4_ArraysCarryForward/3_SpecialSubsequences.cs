using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysCarryForward
{
    /*
    Q4. Special Subsequences "AG"

    Problem Description
    You have given a string A having Uppercase English letters.

    You have to find how many times subsequence "AG" is there in the given string.

    NOTE: Return the answer modulo 109 + 7 as the answer can be very large.



    Problem Constraints
    1 <= length(A) <= 105



    Input Format
    First and only argument is a string A.



    Output Format
    Return an integer denoting the answer.



    Example Input
    Input 1:

     A = "ABCGAG"
    Input 2:

     A = "GAB"


    Example Output
    Output 1:

     3
    Output 2:

     0


    Example Explanation
    Explanation 1:

     Subsequence "AG" is 3 times in given string 
    Explanation 2:

     There is no subsequence "AG" in the given string.
    */
    internal class SpecialSubsequences
    {
        public static int solve(string A)
        {
            int n = A.Length;

            int ACount = 0;
            int AIndex = -1;
            int GIndex = -1;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == 'A')
                {
                    ACount++;
                    AIndex = i;
                }
                if (A[i] == 'G')
                {
                    // GCount++; 
                    GIndex = i;
                }
                if (AIndex > -1 && GIndex > -1 && GIndex > AIndex && A[i] == 'G') ans = (ans + ACount) % 1000000007; // GUGPU A G A FQBMPY A GG AA O A L A EL GGG A O G L G  E G Z
            }

            return ans;
        }
    }
}
