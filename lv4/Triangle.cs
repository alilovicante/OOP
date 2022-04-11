using System;
using System.Collections.Generic;
using System.Text;

namespace lv4
{
    class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double Side1 { get { return side1; } private set { this.side1 = value; } }
        public double Side2 { get { return side2; } private set { this.side2 = value; } }
        public double Side3 { get { return side3; } private set { this.side3 = value; } }
        public double CalculateArea()
        {
            if ((Side1 + Side2 >= Side3 || Side1 + Side3 >= Side2 || Side2 + Side3 >= Side1)&&(Side1>0 && Side2>0 && Side3>0))
            {
                double s = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
            }
            else { throw new ArgumentException("Stranice ne čine trokut ili je za stranicu predana negativna vrijednost!"); }
        }
        public double CalculateCircumference()
        {
            if ((Side1 + Side2 >= Side3 || Side1 + Side3 >= Side2 || Side2 + Side3 >= Side1) && (Side1 > 0 && Side2 > 0 && Side3 > 0))
            {
                return Side1 + Side2 + Side3;
            }
            else { throw new ArgumentException("Stranice ne čine trokut ili je za stranicu predana negativna vrijednost!"); }
        }
        public override string ToString()
        {
            return $"Prva stranica: {Side1}\nDruga stranica: {Side2}\nTreca stranica: {Side3}";
        }
    }
}
