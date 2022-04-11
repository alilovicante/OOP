using System;

namespace LinearAlgebra
{
    public class Vector
    {
        private double i;
        private double j;
        private double k;

        public Vector()
        {
            i = 0;
            j = 0;
            k = 0;
        }
        public Vector(double i, double j, double k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
        }
        public double I { get { return i; } set { this.i = value; } }
        public double J { get { return j; } set { this.j = value; } }
        public double K { get { return k; } set { this.k = value; } }
        public override string ToString()
        {
            return $"{I},{J},{K}";
        }
        public double CalculateL2Norm()
        {
            return System.Math.Sqrt((i * i) + (j * j) + (k * k));
        }
    }
}

