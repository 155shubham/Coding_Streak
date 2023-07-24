using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.BitManipulations2
{
    /*

    Q1. Check bit

    Problem Description
    You are given two integers A and B.
    Return 1 if B-th bit in A is set
    Return 0 if B-th bit in A is unset
    Note:
    The bit position is 0-indexed, which means that the least significant bit (LSB) has index 0.


    Problem Constraints
    1 <= A <= 109
    0 <= B <= 30


    Input Format
    First argument A is an integer.
    Second argument B is an integer.


    Output Format
    Return an integer.


    Example Input
    Input 1:
    A = 4
    B = 1
    Input 2:
    A = 5
    B = 2


    Example Output
    Output 1:
    0
    Output 2:
    1

    */
    internal class CheckBit
    {
        // Best Way: Using And operator
        public int solve(int A, int B)
        {
            if ((A & 1 << B) != 0) return 1;
            else return 0;
        }

        // Best Way: Using OR operator
        public int solve1(int A, int B)
        {
            if ((A | 1 << B) == A) return 1;
            else return 0;
        }


        // Best Way: Using And operator
        public int solve2(int A, int B)
        {
            if ((A ^ 1 << B) < A) return 1;
            else return 0;
        }

        //Better way
        public int solve3(int A, int B)
        {
            int bit = 0;
            int i = 0;

            while (A > 0)
            {
                if (B == i & A % 2 == 1) return 1;
                else if (B == i & A % 2 == 0) return 0;
                A /= 2;
                i++;
            }

            return A % 2;
        }
    }
}


// Take care of the test case where B will be more than the no of bit present in the binar representation