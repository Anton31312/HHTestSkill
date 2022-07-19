using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTestSkill
{
    public class CircleCheck : TypeFigure
    {
		public double Rad { get; set; }

		public CircleCheck(string typeName, double r) : base(typeName)
		{
			Rad = r;
		}

		public override double Square()
		{
			return Math.Round(3.14f * Math.Pow(Rad, 2), 1);
		}
	}
}
