using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace DSA_Programs.RandomPrograms
{
    /*
     Payment Pairs

        Jackie is analysing some payment data, stored in cents, and wants
        to find pairs of payments that add up to whole dollar amounts (e.g.,
        100, 200, 300). Given a list of payments, calculate the to total
        number of payment pairs that can be made.

        Example

        n=3

        payments = [40, 100, 60]

        One pair of payments can be chosen whose combined value is a
        multiple of a whole dollar (40 + 60 = 100) so the return value would

        be 1. While the third payment is for a whole dollar, payments must
        be chosen in pairs.

        Function Description
        Complete the function in the editor below.

        paymentPairs has the following parameter(s):

        int payments[n]: array of integers representing payment amounts
        in cents

        Returns:

        int: the number of payment pairs that add up to a multiple of a
        whole dollar

        Constraints

        e 1<n<10°
        o 1 <payments[i] < 1000, where 0<i<n
     */


    internal class PairNumbers
    {

        /*
        TC: O(n)

        //Solution Hint:
            //  Follow the steps below to solve the given problem: 

            //  Create a map to store the frequency of each number in the array.
            //  Check if (K – arr[i]) is present in the map, if present then increment the count variable by its frequency.
            //  After traversal is over, return the count.
        */
        public static long paymentPairs(List<int> payments)
        {
            int n = payments.Count;
            long cnt = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(100 - payments[i]))
                {
                   cnt = dict[100 - (payments[i] % 100)]; // as many no of complements that many nof of pair suppose 40,40,60
                }
                
                if (dict.ContainsKey(payments[i])) // if more than one time increse the count
                {
                    dict[payments[i]] += 1;
                }
                else
                {
                    dict.Add(payments[i], 1);
                }

            }

            return cnt;
        }


        //TC: O(n^2)
        public static long paymentPairs1(List<int> payments)
        {
            int n = payments.Count;
            long pairs = 0;
            int amt = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    amt = (payments[i] + payments[j]) % 100;
                    if (amt == 0) pairs++;
                }
            }

            return pairs;
        }
    }
}
