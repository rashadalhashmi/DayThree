using System;
using System.Collections.Generic;
using System.Text;

namespace DayThree
{
    class Line
    {
        Point P1;
        Point P2;

        public Line(Point p1 , Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;


        }
        public int GetLength()
        {

         int length= (int) Math.Sqrt((Math.Pow(this.P1._x - this.P2._x, 2) + Math.Pow(this.P1._y - this.P2._y, 2)));

            return  length;

        }
    }
}
