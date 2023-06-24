using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Programs.RandomPrograms
{


    /*
     * Write a program to find the substring in a string which is having max no of characters but non-repeating.
     * string str = "pwwkew";
     * o/p: wke
     * 
     */
    internal class LengthOfLongestSubstring
    {
        public int FindLengthOfLongestSubstring(string s)
        {
            string str = s;
            int maxLen = 1;
            string tempStr = "";

            if (str.Length < 0 || str.Length > 50000) return 0;

            if (string.IsNullOrEmpty(str)) return 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1] && tempStr == "")
                {
                    tempStr = "" + str[i] + str[i + 1]; //form a new string tempStr = //maxLen++;   
                }
                else if (str[i] != str[i + 1] && tempStr != "" && !tempStr.Contains(str[i + 1]))
                {
                    tempStr = tempStr + str[i + 1]; // ab + c + d
                                                    //maxLen++;
                }
                else if (str[i] == str[i + 1] || tempStr.Contains(str[i + 1]))
                {
                    tempStr = "";
                }
                if (maxLen < tempStr.Length)
                    maxLen = tempStr.Length;
            }
            return maxLen;
        }
        //public void SampleMethod()
        //{
        //    string str = "pwwkew";
        //    int len = str.Length;
        //    int maxLen = 1;
        //    string subStr = String.Empty; //string builder

        //    ArrayList arrLst = new ArrayList();

        //    for (var i = 0; i < len; i++)
        //    {
        //        if (str[i] != str[i + 1])
        //        {
        //            if (String.IsNullOrEmpty(subStr))
        //            {
        //                if (!subStr.Contains(str[i + 1]))
        //                {
        //                    subStr = subStr + str[i + 1];
        //                    maxLen++;
        //                }
        //                else
        //                {
        //                    arrLst.Add(maxLen);
        //                    subStr = String.Empty;
        //                    maxLen = 1;
        //                    break;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            arrLst.Add(maxLen);
        //            subStr = String.Empty;
        //            maxLen = 1;
        //        }
        //    }
        //}
    }
}
