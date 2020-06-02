using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.6.1 Calculate The Area of a circle
            float rad;
            bool parsed = false;
            while (parsed == false)
            {
                Console.WriteLine("Input a radius:");
                string input = Console.ReadLine();
                parsed = float.TryParse(input, out rad);

                if (parsed && rad >= 0)
                {
                    double area = Circle.Area(rad);
                    double circum = Circle.Circum(rad);
                    float diam = Circle.Diam(rad);


                    Console.WriteLine($"The Area of a circle  of radius {rad} is: {area}.");

                    // 2.6.2 More Calculations
                    Console.WriteLine($"The Circumference of a circle of radius {rad} is: {circum}.");
                    Console.WriteLine($"The Diameter of a circle of radius {rad} is: {diam}.");

                    // 2.6.3 Road Trip!
                    Console.WriteLine("How many MPG does your car have?:");
                    double mpg = double.Parse(Console.ReadLine());
                    double gasSpent = circum / mpg;
                    Console.WriteLine($"You will use {gasSpent} gallons of gas to go around this circle.");
                }
                else if (!parsed)
                {
                    Console.WriteLine("ERROR!!");
                    parsed = true; // or use break;
                }
                else if (rad < 0)
                {
                    Console.WriteLine("Please input a valid number");
                    parsed = false;
                }
            }
        }
    }

    public class Circle
    {
        public static double Area(float radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static float Diam(float radius)
        {
            return 2 * radius;
        }

        public static double Circum(float radius)
        {
            return Math.PI * 2 * radius;
        }

    }
}
