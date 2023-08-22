using System.Data;

namespace ConsoleApp3
{




  public class GeometryHelper
   {
        public static double SquareArea(int a)
        {
           return a*a;
        }
        public static double TriangleArea(int a,int b,int c)
        {
            int s = (a + b + c) / 2;  //Heron Formula
            return Math.Sqrt(s*(s - a) * (s - b) * (s - c));
        }
        public static double CircleArea(int a)
        {
            return a * a * Math.PI;
        }
    }






    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeometryHelper.SquareArea(4));
            Console.WriteLine(GeometryHelper.TriangleArea(3,4,5));
            Console.WriteLine(GeometryHelper.CircleArea(4));

        }
    }
}