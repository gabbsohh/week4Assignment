using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment
{
    internal class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int width, height;

            /*
             Finally, in your Main function, choose minimum and maximum measurements for length and width (or get them from the user). 
            These should be sent to the "MakeRectangle" function, which should
            send back a randomized length and width. Use those values to create an instance of a Rectangle, 
            and print its length, width, area, and perimeter.
             */

            MakeRectangle(min, max, out width, out height);
            Rectangle rect = new Rectangle();

            Console.WriteLine("Length: " + height);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + MathUtility.Area(width, height));
            Console.WriteLine("Perimeter: " + MathUtility.Perimeter(width, height));
        }

        //functions
        public static void MakeRectangle(int min, int max, out int width, out int height)
        {
            width = random.Next(0, 100);
            height = random.Next(0, 100);

            Console.WriteLine(width);
            Console.WriteLine(height);
        }
    }
    public class Rectangle
    {
        int width;
        int height;
    }

    public class MathUtility
    {
        public static int Area(int width, int height)
        {
            return width * height;
        }

        public static int Perimeter(int width, int height)
        {
            return (2 * (width + height));
        }
    }

}
