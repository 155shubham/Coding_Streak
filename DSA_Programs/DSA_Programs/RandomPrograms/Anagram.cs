using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace  DSA_Programs.RandomPrograms
{
    internal class Anagram
    {
        public void Check_If_Anagram(string str1, string str2)
        {
            char[] arr1 = str1.ToLower().ToCharArray();
            char[] arr2 = str2.ToLower().ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            string val1 = new string(arr1);
            string val2 = new string(arr2);

            if (val1 == val2)
            {
                Console.WriteLine($"{str1} & {str2} are anagrams");
            }
            else
            {
                Console.WriteLine($"{str1} & {str2} are not anagrams");
            }
        }

        //public void Check_If_Anagram_Linq(string str1, string str2)
        //{
        //    char[] arr1 = str1.ToCharArray();
        //    char[] arr2 = str2.ToCharArray();

        //    arr1.OrderBy()
        //    Array.Sort(arr2);

        //    if (arr1.Length == arr2.Length && arr1 == arr2)
        //    {

        //    }

        //}
    }
}
