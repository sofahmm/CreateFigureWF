//kumyshbaeva sofia 220 pr
using System;

namespace create_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(0, 0);
            p.Created(2, 4);

            Circle c = new Circle(2, 4);
            c.Created(5);

            Triangle t = new Triangle(2, 4);
            t.Created(-1, -1, 5, -1);
        }
    }

    class Point
    {
        protected int x1;
        protected int y1;

        public Point(int x, int y)
        {
            x1 = x;
            y1 = y;
        }

        public virtual int Created(int x, int y)
        {
            Console.WriteLine("Координата поставленной точки: " + x + ";" + y);
            return 0;
        }
    }

    /*class Segment : Point
    {
        public Segment()
        {

        }
    }

    class Rectangle
    {

    }*/
    class Triangle : Point
    {
        public Triangle(int x1, int y1) : base(x1, y1)
        {

        }

        public int Created(int x2, int y2, int x3, int y3)
        {
            Console.WriteLine("окружность с вершиной в точке:" + x1 + ";" + y1 + "и с основанием в координатах:" + x2 + ";" + y2 + x3 + ";" + y3);
            return 0;
        }
    }

    class Circle : Point
    {
        public Circle(int x1, int y1) : base(x1, y1)
        {

        }

        public int Created(int r)
        {
            Console.WriteLine("Окружность с центром в точке с координатой: " + x1 + ";" + y1 + " и радиусом " + r);
            return 0;
        }
    }
}
