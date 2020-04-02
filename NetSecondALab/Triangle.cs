using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FakeItEasy;

namespace NetSecondALab
{
    class Triangle : Point
    {
        private Point point1;
        private Point point2;
        private Point point3;

        private Point vector1;
        private Point vector2;
        private Point vector3;

        public Triangle()
        {
            point1 = new Point();
            point2 = new Point();
            point3 = new Point();

            List<Point> points = new List<Point>() { point1, point2, point3 };
            int x, y;
            String name;
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine("Введите имя точки :");
                name = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введите координату точки по Х :");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите координату точки по Y :");
                        y = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неверный ввод. Попробуйте еще раз!!!\n");
                        continue;
                    }
                    break;
                }

                points[i].Name = name;
                points[i].X = x;
                points[i].Y = y;
            }

            vector1 = new Point();
            vector2 = new Point();
            vector3 = new Point();

            vector1 = point1.Vector(point2);
            vector2 = point3.Vector(point2);
            vector3 = point1.Vector(point3);
        }
        public bool IsTriangle()
        {
            if (vector1.VectorLnt() + vector2.VectorLnt() > vector3.VectorLnt()
                    && vector1.VectorLnt() + vector3.VectorLnt() > vector2.VectorLnt()
                        && vector3.VectorLnt() + vector2.VectorLnt() > vector1.VectorLnt())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double getP()
        {
            return Math.Round(vector1.VectorLnt() + vector2.VectorLnt() + vector3.VectorLnt(), 4);
        }

        public double getS()
        {
            double p = this.getP() / 2;
            return Math.Round(Math.Sqrt(p * (p - vector1.VectorLnt()) * (p - vector2.VectorLnt()) * (p - vector3.VectorLnt())), 4);
        }

        public void printInfo()
        {
            if (IsTriangle())
            {
                Console.WriteLine("\nТреугольник " + point1.Name + point2.Name + point3.Name + " :");
                Console.WriteLine("---------------");
                Console.WriteLine("Точки:");
                Console.WriteLine(point1.ToString());
                Console.WriteLine(point2.ToString());
                Console.WriteLine(point3.ToString());
                Console.WriteLine("---------------");
                Console.WriteLine("Вектора:");
                Console.WriteLine(vector1.ToString());
                Console.WriteLine(vector2.ToString());
                Console.WriteLine(vector3.ToString());
                Console.WriteLine("---------------");
                Console.WriteLine("Длины сторон:");
                Console.WriteLine(vector1.Name + " : " + vector1.VectorLnt());
                Console.WriteLine(vector2.Name + " : " + vector2.VectorLnt());
                Console.WriteLine(vector3.Name + " : " + vector3.VectorLnt());
                Console.WriteLine("---------------");
                Console.WriteLine("Углы треугольника:");
                Console.WriteLine(point1.Name + " : " + vector1.VectorAngl(vector3));
                Console.WriteLine(point2.Name + " : " + vector2.VectorAngl(vector1));
                Console.WriteLine(point3.Name + " : " + vector3.VectorAngl(vector2));
                Console.WriteLine("---------------");
                Console.WriteLine("Периметр треугольника:");
                Console.WriteLine(this.getP());
                Console.WriteLine("---------------");
                Console.WriteLine("Площадь треугольника:");
                Console.WriteLine(this.getS());
                Console.WriteLine("---------------");
            }
            else 
            {
                Console.WriteLine("\nТреугольника не существует!!!\n");
            }
        }

    }
}
