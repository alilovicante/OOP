using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace lv2
{
    public class Vector
    {
        private int i;
        private int j;
        private int k;

        public Vector() { i = 0; j = 0; k = 0; }
        public Vector(int i, int j, int k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
        }
        public int I
        {
            get { return i; }
        }
        public int J
        {
            get { return j; }
        }
        public int K
        {
            get { return k; }
        }
        public string Ispis()
        {
            return $"{i}i,{j}j,{k}k";
        }
        public static Vector operator+ (Vector v1,Vector v2)
        {
            return (new Vector(v1.i + v2.i, v1.j + v2.j, v1.k + v2.k));
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return (new Vector(v1.i - v2.i, v1.j - v2.j, v1.k - v2.k));
        }

    }
}
