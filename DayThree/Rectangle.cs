using System;
using System.Collections.Generic;
using System.Text;

namespace DayThree
{
    class Rectangle
    {

        public  Point  p1;
        public  Point  p2;
        Point  pc;
        Line Width;
        Line Hight;

        public Rectangle(Point p1 , Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            pc= new Point(this.p1._x, this.p2._y);
           
        }

        public int calculateayrea()
        {
            Width = new Line(p2, pc);
            int W = Width.GetLength();
            Hight = new Line(pc, p1);
            int H = Hight.GetLength();

            return W*H;

        }
    }
}
