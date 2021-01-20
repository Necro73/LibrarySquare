using System;
using System.Net.Mail;

namespace LibrarySquare
{
    public class Square
    {
        public double Circle(double x)
        {
            double s = Math.Pow(x, 2) * Math.PI;
            return s;
        }
        
        public double Triangle (double[] x)
        {
            if ((Math.Pow(x[0], 2) == (Math.Pow(x[1], 2) + Math.Pow(x[2], 2))) | (Math.Pow(x[1], 2) == (Math.Pow(x[0], 2) + Math.Pow(x[2], 2))) | (Math.Pow(x[2], 2) == (Math.Pow(x[1], 2) + Math.Pow(x[0], 2))))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            
            double p = (x[0] + x[1] + x[2]) / 2;
            double s = Math.Sqrt(p * (p - x[0]) * (p - x[1]) * (p - x[2]));
            return s;
        }
    }
}