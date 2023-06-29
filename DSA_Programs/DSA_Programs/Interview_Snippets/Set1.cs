using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.Interview_Snippets
{
    internal class Samples
    {
        public static void M1()
        {
            int num = 2;
            fun1(ref num);
            Console.WriteLine(num);
            Console.ReadLine();
        }

        static void fun1(ref int num) {
            num = num * num;
        
        
        }

        public static void M2()
        {
            string s1 = "Hindi";
            string s2;
            s2 = s1.Insert(6, "English");
            Console.WriteLine(s2);
        }

        public static void M3()
        {
            int[] val = { 1, 2, 3, 4 };
            var lt = from n in val
                     let x = val.Average()
                     where n < x
                     select n;
            Console.WriteLine(val.Average());

        }

        public static void M4()
        {
            string a1 = "ollA";
            string a2 = "olla";
            if(a1 == a2) { Console.WriteLine("Equal"); }
            if(a1.Equals(a2)) { Console.WriteLine("Equal"); }

        }
    }
}
