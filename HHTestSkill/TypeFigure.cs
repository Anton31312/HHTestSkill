using System;

namespace HHTestSkill
{
    public abstract class TypeFigure
    {
		public string TypeName { get; set; }

		public TypeFigure(string typeName)
		{
			TypeName = typeName;
		}

		public abstract double Square();

		public override string ToString()
		{
			return $"Тип фигуры: " + TypeName;
		}
	}
}
