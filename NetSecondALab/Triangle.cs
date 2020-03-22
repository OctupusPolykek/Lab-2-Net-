using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FakeItEasy;

namespace NetSecondALab
{
    class Triangle
    {
        private int ax;
        public int Ax { get => ax; set => ax = value; }
        private int ay;
        public int Ay { get => ay; set => ay = value; }

        private int bx;
        public int Bx { get => bx; set => bx = value; }
        private int by;
        public int By { get => by; set => by = value; }

        private int cx;
        public int Cx { get => cx; set => cx = value; }
        private int cy;
        public int Cy { get => cy; set => cy = value; }

        private double getVector(int ax, int bx)
        {
            return bx - ax;
        }

        private double getLnt(int ax, int ay, int bx, int by)
        {
            return Math.Round(Math.Abs(Math.Sqrt(Math.Pow((getVector(ax, bx)), 2) + Math.Pow((getVector(ay, by)), 2))), 4);
        }

        private double getAngl(int ax, int ay, int bx, int by, int cx, int cy)
        {
            return Math.Round((getVector(ax, bx) * getVector(ax, cx) + getVector(ay, by) * getVector(ay, cy)) / (getLnt(ax, ay, bx, by) * getLnt(ax, ay, cx, cy)), 4);
        }

        //private double RadianToDegree(double angle)
        //{
        //    return angle / 180.0;
        //}

        private double getPer(double a, double b, double c)
        {
            return Math.Round(a + b + c, 4);
        }
        private double getArea(double a, double b, double c)
        {
            return Math.Round(Math.Sqrt((a + b + c)/2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)), 4);
        }

        public bool Check() 
        {
            if (getLnt(Ax, Ay, Bx, By) + getLnt(Ax, Ay, Cx, Cy) > getLnt(Bx, By, Cx, Cy) 
                && getLnt(Ax, Ay, Bx, By) + getLnt(Bx, By, Cx, Cy) > getLnt(Ax, Ay, Cx, Cy) 
                    && getLnt(Ax, Ay, Cx, Cy) + getLnt(Bx, By, Cx, Cy) > getLnt(Ax, Ay, Bx, By))
            {
                return true;
            }
            else
            {
                return false;
            }
       
        }
        public void coutLnt() 
        {
            Console.WriteLine($"Lenth[AB]:{getLnt(Ax, Ay, Bx, By)}");
            Console.WriteLine($"Lenth[AC]:{getLnt(Ax, Ay, Cx, Cy)}");
            Console.WriteLine($"Lenth[BC]:{getLnt(Bx, By, Cx, Cy)}");
        }

        public void coutAngl()
        {
            Console.WriteLine($"Angel[A]:{getAngl(Ax, Ay, Bx, By, Cx, Cy)}");
            Console.WriteLine($"Angel[B]:{getAngl(Bx, By, Cx, Cy, Ax, Ay)}");
            Console.WriteLine($"Angel[C]:{getAngl(Cx, Cy, Ax, Ay, Bx, By)}");
        }

        public void coutPer()
        {
            Console.WriteLine($"Perimeter:{getPer(getLnt(Ax, Ay, Bx, By), getLnt(Ax, Ay, Cx, Cy), getLnt(Bx, By, Cx, Cy))}");
        }

        public void coutArea()
        {
            Console.WriteLine($"Area:{getArea(getLnt(Ax, Ay, Bx, By), getLnt(Ax, Ay, Cx, Cy), getLnt(Bx, By, Cx, Cy))}");
        }
    }
}
