using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTestSkill
{
    public class TriangleCheck : TypeFigure
    {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

        public TriangleCheck (string typeName, double a, double b, double c) : base(typeName)
        {
            if (IsExist(a, b, c))
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public override double Square()
        {
            var halfMeter = A + B + C / 2;
            var square = Math.Sqrt(halfMeter * (halfMeter - A) * (halfMeter - B) * (halfMeter - C));
            return Math.Round(square);
        }

        private static bool IsExist (double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new TriangleExcep("Такого треугольника не существует (сторона меньше 0)");
            }

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new TriangleExcep("Такого треугольника не существует (сторона больше суммы двух других)");
            }

            return true;
        }

        public bool StraightTriangle()
        {
            bool straight = (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                               || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                               || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));

            return straight;
        }
    }
}
