using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTestSkill
{
    public static class Program
    {
        static void Main(string[] args)
        {
            CircleCheck circle = new CircleCheck("Круг", 12);
            TriangleCheck triangle = new TriangleCheck("Треугольник", 1, 2, 3);

            Console.WriteLine($"{circle.Square()} {circle.TypeName}");
            Console.WriteLine($"{triangle.Square()} {triangle.TypeName}");
        }

        public static double Square(TypeFigure typeFigure)
        {
            return typeFigure.Square();
        }
    }
}
