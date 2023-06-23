using System;
using System.Linq;
using System.Text.RegularExpressions;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(string S)
    {

        // Initialize cnters for 'B', 'A', and 'N' occurrences
        int cntB = 0, cntA = 0, cntN = 0;
        int noOfMoves = 0;

        //Check length
        if (S.Length < 1 || S.Length > 1000000) return 0;

        //Check alphabet
        bool containsAlphabet = Regex.IsMatch(S, @"^[a-zA-Z]+$");
        if (!containsAlphabet) return 0;

        // Check uppercase
        bool containsLowerCaseLetters = S.Any(char.IsLower);
        if (containsLowerCaseLetters) return 0;

        //Check whitespace
        bool containsWhiteSpace = S.Any(char.IsWhiteSpace);
        if (containsWhiteSpace) return 0;

        //   bool isNumber = S.Any(char.IsNumber);
        // if (isNumber) return 0;

        // cnt occurrences of 'B', 'A', and 'N' in the string
        foreach (char c in S)
        {
            if (c == 'B')
                cntB++;
            else if (c == 'A')
                cntA++;
            else if (c == 'N')
                cntN++;
        }

        // Calculate the maximum number of moves possible
        while (cntB >= 1 && cntA >= 3 && cntN >= 2)
        {
            noOfMoves++;
            cntB--;
            cntA -= 3;
            cntN -= 2;
        }

        return noOfMoves;
    }
}
