using System;

namespace LinearAlgebra.Math
{
    public static class VectorMath
    {
        public static double GetDotProduct(Vector v1, Vector v2)
        {
            return (v1.I * v2.I) + (v1.J * v2.J) + (v1.K * v2.K);
        }
        public static double GetVectorsAngle(Vector v1, Vector v2)
        {
            return System.Math.Acos(GetDotProduct(v1, v2) / (v1.CalculateL2Norm() * v2.CalculateL2Norm()));
        }
    }
}
