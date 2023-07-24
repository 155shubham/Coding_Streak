using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ModularAritmeticIntroduction
{
    internal class PowerWithModules
    {
        public static int solve(int A, int B, int C)
        {
            long ans = 1;

            for (int i = 1; i <= B; i++)
            {
                ans = (ans * A) % C;
            }

            return (int)(ans % C);
        }
    }
}
