

using System.Linq;

namespace DSA_Programs.ArraysSlidingWindow
{

    /*
    Q3. Spiral Order Matrix II

    Problem Description
    Given an integer A, generate a square matrix filled with elements from 1 to A2 in spiral order and return the generated square matrix.

    Problem Constraints
    1 <= A <= 1000

    Input Format
    First and only argument is integer A

    Output Format
    Return a 2-D matrix which consists of the elements added in spiral order.

    Example Input
    Input 1:

    1
    Input 2:

    2
    Input 3:

    5

    Example Output
    Output 1:

    [ [1] ]
    Output 2:

    [ [1, 2], 
      [4, 3] ]
    Output 2:

    [ [1,   2,  3,  4, 5], 
      [16, 17, 18, 19, 6], 
      [15, 24, 25, 20, 7], 
      [14, 23, 22, 21, 8], 
      [13, 12, 11, 10, 9] ]


    Example Explanation

    Explanation 1:
    Only 1 is to be arranged.

    Explanation 2:
    1 --> 2
          |
          |
    4<--- 3

    Explanation 3:
    1    ---->     5
    |  17 --> 19   |
    |  |  25  |    |
    |  23 <-- 21   |
    13  <----      9
    */
    internal class SpiralOrderMatrixII
    {
        public static List<List<int>> generateMatrix(int A)
        {
            List<List<int>> ans = new List<List<int>>(A * A);

            if (A == 1)
            {
                ans.Add(new List<int>() { A });
                return ans;
            }

            //first initialise the list default to 0
            for (int k = 0; k < A; k++)
            {
                ans.Add(new List<int>(new int[A]));
            }

            int sNum = 1;  // start number which will be 1 and we have to generate next numbers from this to form matrix of A*A

            int i = 0;
            int j = 0;

            while (A > 1)
            {
                for (int k = 0; k < A - 1; k++)
                {
                    ans[i][j] = sNum;
                    sNum++;
                    j++;
                }

                for (int k = 0; k < A - 1; k++)
                {
                    ans[i][j] = sNum;
                    sNum++;
                    i++;
                }

                for (int k = 0; k < A - 1; k++)
                {
                    ans[i][j] = sNum;
                    sNum++;
                    j--;
                }

                for (int k = 0; k < A - 1; k++)
                {
                    ans[i][j] = sNum;
                    sNum++;
                    i--;
                }

                i++;
                j++;
                A -= 2;

                if (A == 1) ans[i][j] = sNum;
            }

            return ans;
        }

    }
}
