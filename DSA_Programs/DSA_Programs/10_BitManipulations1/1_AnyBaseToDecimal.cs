using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Bit_Manipulations
{
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
