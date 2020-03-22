using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSecondALab
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            triangle.Ax = -3;
            triangle.Ay = 4;

            triangle.Bx = -1;
            triangle.By = 0;

            triangle.Cx = 0;
            triangle.Cy = 3;

            if (triangle.Check())
            {
                Console.WriteLine("---------------");
                triangle.coutLnt();
                Console.WriteLine("---------------");
                triangle.coutAngl();
                Console.WriteLine("---------------");
                triangle.coutPer();
                Console.WriteLine("---------------");
                triangle.coutArea();
                Console.WriteLine("---------------");
            }
            else 
            {
                Console.WriteLine("Triangle does not exist.");
            }
        }
    }
}
