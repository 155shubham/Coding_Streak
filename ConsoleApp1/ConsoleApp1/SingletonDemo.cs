using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SingletonDemo
    {

        private static SingletonDemo SD;
        private static object SDLock = new object();
        private SingletonDemo()
        {
            
        }

        public static SingletonDemo Main() 
        {
            //SingletonDemo returnObj = null;
            if (SD == null)
            {
                lock (SDLock)// 2nd
                {
                    if (SD is null)
                    {
                        SD = new SingletonDemo(); // fir
                    }
                }
            }
            //returnObj = SD;
            return SD;
        
        }

        //TC: O(nlogn)
        public int[] SortArrays_Way1(int[] arr)
        {
            Array.Sort(arr);

            return arr;
        }

        //TC: 
        public int[] SortArrays_Way2(int[] arr)
        {

            for (int i =0; i < arr.Length;i++)
            {

            }

            return arr;
        }
        public static int[] MergeTwoSortedArrays(int[] arr1, int[] arr2) 
        {

            int[] temp = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length;i++)
            {
                temp[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                temp[arr1.Length + i] = arr2[i];
            }

            //for (int i = 0; i < temp.Length; i++)
            //{
            //    if (temp[i] > temp[i+1])
            //    {

            //    }
            //}

            Array.Sort(temp);

            return temp;

        }

        //linkedl list

        // two sorted arrays arr1—> 245689 ; arr2—>13679 resarr->12345667899
    }
}
