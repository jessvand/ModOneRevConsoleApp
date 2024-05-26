using System.ComponentModel.DataAnnotations;

namespace ModOneReviewConsoleApp
{
    public class Program
    {

        public static void Main()
        {
            // using the method
            double radius =  12;
            double area = AreaOfCircleCalculated(radius);
            Console.WriteLine($"the area of the circle is:{area}");

            double length = 4;
            double width = 6;
            double areaRec = AreaOfRectangle(length, width);
            Console.WriteLine($"The area of the rectangle is {areaRec}");

            double side1 = 24;
            double side2 =24;
            double areaSq = AreaOfSquare(side1, side2);
            Console.WriteLine($"The area of the square is {areaSq}");

            double baseLength = 10;
            double height = 97;
            double areaTri = TriangleArea(baseLength, height);
            Console.WriteLine($"The area of the triangle is {areaTri}");
        }

        public static double AreaOfCircleCalculated(double radius)
        {

            double area = Math.PI*Math.Pow(radius, 2);         
            return area;
           
        }

        
        public static double AreaOfRectangle(double length, double width)
        {
            double areaRec = length * width;
            return areaRec;
        }

        public static double AreaOfSquare(double side1, double side2)
        {
            double areaSq = side1*side2;
            return areaSq;
        }     

        public static double TriangleArea(double baseLength, double height)
        {
            double areaTri = baseLength * height*height;
            return areaTri;
        }


}   }    

