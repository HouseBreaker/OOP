using System;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Shapes
{
	public abstract class BasicShape : IShape
	{
		private const int Pad = -5;
		private double width, height;

		protected BasicShape(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}

		public double Width
		{
			get { return width; }
			private set { width = ValidateDouble(value, "width"); }
		}

		public double Height
		{
			get { return height; }
			private set { height = ValidateDouble(value, "height"); }
		}

		public abstract double CalculateArea();
		public abstract double CalculatePerimeter();

		private static double ValidateDouble(double value, string paramName)
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException(paramName, paramName + "cannot be negative or 0");
			}
			return value;
		}

		public override string ToString()
		{
			return $"Width: {Width,Pad} " +
			       $"Height: {Height}";
		}
	}
}