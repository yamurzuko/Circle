using System;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double thickness = 0.1;
            
            do
            {
                Console.Write("Enter radius:::: ");
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("radius have to be positive number");
                }
            }
            while (radius <= 0);
            Console.WriteLine();
            double rIn = radius - thickness;
            double rOut = radius + thickness;
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                double value = x * x + y * y;
                if (value >= rIn * rIn && value <= rOut * rOut)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
                }
                Console.WriteLine();
            }
        }
    }
}