using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Programs.Random
{
    /*
     * PROBLEM:
     * Find overlapping rectangles. 
     */

    // SOLUTION:
    internal class Rectangle
    {
        public int X { get; set; } // Assuming X co-ordinate of bottom left corner 
        public int Y { get; set; } // Assuming Y co-ordinate of bottom left corner 
        public int Length { get; set; } // Length of rectangle
        public int Width { get; set; } // Width of rectangle

        public Rectangle(int x, int y, int width, int length)
        {
            X = x;
            Y = y;
            Length = length;
            Width = width;
        }
    }
    internal class OverlappingRectangles
    {
        public bool FindOverLappingRectangles(Rectangle[] rectangles)
        {
            Rectangle rectA = rectangles[0];
            Rectangle rectB = rectangles[1];
            bool overLappingRectangles = false;

            // Check if bottom left corner of rect A lies on or in rect B
            if (rectA.X >= rectB.X && rectA.X <= rectB.X + rectB.Length && rectA.Y >= rectB.Y && rectA.Y <= rectB.Y + rectB.Width) return true;

            // Check if bottom right corner of rect A lies on or in rect B
            if (rectA.X + rectA.Length >= rectB.X && rectA.X + rectA.Length <= rectB.X + rectB.Length && rectA.Y >= rectB.Y && rectA.Y <= rectB.Y + rectB.Width) return true;

            // Check if top right corner of rect A lies on or in rect B
            if (rectA.X + rectA.Length >= rectB.X && rectA.X + rectA.Length <= rectB.X + rectB.Length && rectA.Y + rectA.Width >= rectB.Y && rectA.Y + rectA.Width <= rectB.Y + rectB.Width) return true;

            // Check if top left corner of rect A lies on or in rect B
            if (rectA.X >= rectB.X && rectA.X <= rectB.X + rectB.Length && rectA.Y + rectA.Width >= rectB.Y && rectA.Y + rectA.Width <= rectB.Y + rectB.Width) return true;

            return overLappingRectangles;
        }
    }
}
