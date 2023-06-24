using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Programs.RandomPrograms
{

    /*
     * PROBLEM:
     * Could you please write a function, in c#, that takes an array of 4 points as its input, where each point is represented as a pair of x and y coordinates? 
     * The function should return a boolean value - true if these four points can form a square, and false otherwise. 
     * Please explain your thought process as you approach this problem.
     * Input: [[0,0], [0,1], [1,0], [1,1]] Output: true
     * Input: [[0,0], [0,1], [1,0], [2,1]] Output: false
     */

    //SOLUTION to above problem
    internal class Points
    {
        public int X, Y;

        public Points(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    internal class CheckIfSquareBasedOnCoordinates
    {
        public int CalculateDistance(Points p1, Points p2)
        {
            var xDiff = p1.X - p2.X;
            var yDiff = p1.Y - p2.Y;

            return xDiff * xDiff + yDiff * yDiff;
        }

        public bool IsSquare(Points[] points)
        {
            if (points == null) return false;
            if (points.Length == 0 || points.Length > 4) return false;

            int[] distance = new int[6];
            var index = 0;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    distance[index] = CalculateDistance(points[i], points[i + 1]);
                    index++;
                }
            }

            Array.Sort(distance);

            if (distance[0] == distance[1] && distance[1] == distance[2] && distance[2] == distance[3] && distance[4] == distance[5] && distance[0] < distance[4]) return true;
            else return false;
        }
    }
}
