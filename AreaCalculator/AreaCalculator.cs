using System;

namespace AreaCalculator
{
    public class Triangle : IFigure
    {
        public double Side_A { get; private set; }
        public double Side_B { get; private set; }
        public double Side_C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            Side_A = a;
            Side_B = b;
            Side_C = c;
        }

        public double CalculateArea()
        {
            double p, s;

            p = (Side_A + Side_B + Side_C) / 2;
            s = Math.Sqrt(p * (p - Side_A) * (p - Side_B) * (p - Side_C));

            return s;
        }

        public bool IsTriangleRight()
        {
            bool result = (Side_A * Side_A + Side_B * Side_B == Side_C * Side_C) 
                || (Side_A * Side_A + Side_C * Side_C == Side_B * Side_B) 
                || (Side_B * Side_B + Side_C * Side_C == Side_A * Side_A);

            return result;
        }
    }

    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

}
