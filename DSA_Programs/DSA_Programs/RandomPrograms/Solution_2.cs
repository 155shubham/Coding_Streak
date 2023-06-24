//using System;
//using System.Collections.Generic;
//// you can also use other imports, for example:
//// using System.Collections.Generic;

//// you can write to stdout for debugging purposes, e.g.
//// Console.WriteLine("this is a debug message");

namespace DSA_Programs.RandomPrograms
{
    //class Solution
    //{
    //    public int solution(int N, string S)
    //    {
    //        // Store reserved seats for quick lookup
    //        HashSet<string> reservedSeats = new HashSet<string>(S.Split(' '));

    //        int maxFamilies = 0;

    //        bool validRowRange = N > 0 && N < 51;
    //        if (!validRowRange) return 0;

    //        bool validReservedSeatRange = reservedSeats.Count >= 0 && reservedSeats.Count < 1910;
    //        if (!validRowRange) return 0;

    //        // Loop
    //        for (int row = 1; row <= N; row++)
    //        {

    //            if (CheckAvailability(reservedSeats, row, "BCDE"))
    //            {
    //                maxFamilies++;
    //                if (CheckAvailability(reservedSeats, row, "FGHJ"))
    //                {
    //                    maxFamilies++;
    //                }
    //            }
    //            else if (CheckAvailability(reservedSeats, row, "DEFG"))
    //            {
    //                maxFamilies++;
    //            }
    //        }
    //        return maxFamilies;
    //    }

    //    // Check seat availability in a row
    //    private bool CheckAvailability(HashSet<string> reservedSeats, int row, string seatRange)
    //    {
    //        foreach (char seat in seatRange)
    //        {
    //            string seatString = row.ToString() + seat;
    //            if (reservedSeats.Contains(seatString))
    //                return false;
    //        }
    //        return true;
    //    }
    //}
}