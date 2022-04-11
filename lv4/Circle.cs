using System;
using System.Collections.Generic;
using System.Text;

namespace lv4
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius { get { return radius; } private set { this.radius = value; } }
        public double CalculateArea()
        {
            if (Radius >= 0)
            {
                return Math.Pow(radius, 2) * Math.PI;
            }
            else { throw new ArgumentException("Predan je negativan radijus!"); };
        }
        public double CalculateCircumference()
        {
            if (Radius >= 0)
            {
                return 2 * radius * Math.PI;
            }
            else { throw new ArgumentException("Predan je negativan radijus!"); };
        }
        public override string ToString()
        {
            return $"Radijus: {Radius}";
        }
    }
}
