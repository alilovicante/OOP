using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace lv2
{
    public static class RandomExtension
    {
        public static Vector Generate(this int p)
        {
            Random generate = new Random();
            int a, b, c;
            a = generate.Next(p);
            b = generate.Next(p);
            c = generate.Next(p);
            return new Vector(a, b, c);
        }
    }

}
