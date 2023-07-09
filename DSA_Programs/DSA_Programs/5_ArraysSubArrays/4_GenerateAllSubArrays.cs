using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Programs.ArraysSubArrays
{
    /*
    Q7. Generate all subarrays

    Problem Description
    You are given an array A of N integers.
    Return a 2D array consisting of all the subarrays of the array

    Note : The order of the subarrays in the resulting 2D array does not matter.


    Problem Constraints
    1 <= N <= 100
    1 <= A[i] <= 105


    Input Format
    First argument A is an array of integers.


    Output Format
    Return a 2D array of integers in any order.


    Example Input
    Input 1:
    A = [1, 2, 3]
    Input 2:
    A = [5, 2, 1, 4]


    Example Output
    Output 1:
    [[1], [1, 2], [1, 2, 3], [2], [2, 3], [3]]
    Output 2:
    [[1 ], [1 4 ], [2 ], [2 1 ], [2 1 4 ], [4 ], [5 ], [5 2 ], [5 2 1 ], [5 2 1 4 ] ]


    Example Explanation
    For Input 1:
    All the subarrays of the array are returned. There are a total of 6 subarrays.
    For Input 2:
    All the subarrays of the array are returned. There are a total of 10 subarrays.


    */
    internal class GenerateAllSubArrays
    {
        public static List<List<int>> solve(List<int> A)
        {
            int n = A.Count;
            List<List<int>> res = new List<List<int>>();

            if (n < 1 || n > 100) return new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                if (A[i] < 1 || A[i] > 100000) return new List<List<int>>();
            }

            for (int i = 0; i < n; i++)
            {                
                for (int j = i; j < n; j++)
                {
                    List<int> lst3 = new List<int>();
                    for (int k = i; k <= j; k++)
                    {
                        lst3.Add(A[k]);
                    }
                    res.Add(lst3);
                }
            }

            return res;
        }
    }
}


// TC: O(n^3)
// SC: o(n^2)
// This can be solved using recursion