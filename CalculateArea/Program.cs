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
            CircleArea();
            SquareArea();
            TriangleArea();
            Console.ReadKey();
        }

        
        public static void CircleArea()
        {
            const float Pi = 3.14f;
            Console.Write("Please provide Circle Radius : ");
            int Radius = Convert.ToInt32(Console.ReadLine());
            double Area = Pi * (Radius * Radius);
            Console.WriteLine("Circle Area is : {0}", Area);
        }

        public static void SquareArea()
        {
            Console.Write("Please provide side of Square : ");
            double Side = Convert.ToDouble(Console.ReadLine());
            double SquareArea = Side * Side;
            Console.WriteLine("Square Area is : {0}", SquareArea);
        }

        public static void TriangleArea()
        {
            Console.Write("Please provide Base of Triangle : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please provide Height of Triangle : ");
            double h = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * b * h;
            Console.WriteLine("Triangle Area is : {0}", area);

        }

    }


}
