using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Arrays
{

    //What will be the output of the following code?
    internal class Problems_on_1D_Array
    {
        static void fun(int[] arr)
        {
            arr[3] = 98;
            return;
        }

        public static void solve()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            fun(arr);
            Console.WriteLine(arr[3]);
        }
    }
}
