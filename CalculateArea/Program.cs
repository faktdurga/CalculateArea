using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateArea
{
   public class Program
    {
        static void Main(string[] args)
        {
            //CircleArea();
            //SquareArea();
            //TriangleArea();

            CalculateArea ca = new CalculateArea();
            Console.WriteLine("If Radius of Circle is 5.0 then area of circle is {0}", ca.Area(5.0) );
            Console.WriteLine("If Side of Sqares is 5 then area of circle is {0}", ca.Area(5));
            Console.WriteLine("If Base and Height of Triange is 6 and 5 respectively then area of Triangle is {0}", ca.Area(6, 5));
            Console.ReadKey();
        }




        public class CalculateArea
        {
            public double Area(double Radius)
            {
                double AreaOfCircle = 3.14 * Radius * Radius;
                return AreaOfCircle;
            }

            public int Area(int Side)
            {
                int AreaOfSquare = Side * Side;
                return AreaOfSquare;
            }

            public double Area(int b, int h)
            {
                double AreaOfTriangle = 0.5 * b * h;
                return AreaOfTriangle;
            }
        }
        
        //public static void CircleArea()
        //{
        //    const float Pi = 3.14f;
        //    Console.Write("Please provide Circle Radius : ");
        //    int Radius = Convert.ToInt32(Console.ReadLine());
        //    double Area = Pi * (Radius * Radius);
        //    Console.WriteLine("Circle Area is : {0}", Area);
        //}

        //public static void SquareArea()
        //{
        //    Console.Write("Please provide side of Square : ");
        //    double Side = Convert.ToDouble(Console.ReadLine());
        //    double SquareArea = Side * Side;
        //    Console.WriteLine("Square Area is : {0}", SquareArea);
        //}

        //public static void TriangleArea()
        //{
        //    Console.Write("Please provide Base of Triangle : ");
        //    double b = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Please provide Height of Triangle : ");
        //    double h = Convert.ToDouble(Console.ReadLine());
        //    double area = 0.5 * b * h;
        //    Console.WriteLine("Triangle Area is : {0}", area);

        //}

    }


}
