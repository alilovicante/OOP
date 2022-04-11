using System;
using LinearAlgebra;
using LinearAlgebra.Math;
using lv5;

namespace Test
{
    class Program
    {
        static void Main() { Class1.RunSimpleDemo(); }
        static void RunExercise1()
        {
            Vector v1 = new Vector(1, 4, 8);
            Vector v2 = new Vector(2, 7, 9);
            v1.I = 13;
            v2.I = 17;
            Console.WriteLine(VectorMath.GetVectorsAngle(v1, v2));
        }
    }
}

