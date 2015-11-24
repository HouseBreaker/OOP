using System;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Shapes
{
	public class Circle : IShape
	{
		private const int Pad = -4;

		private double radius;

		public Circle(double radius)
		{
			this.Radius = radius;
		}

		public double Radius
		{
			get { return radius; }
			set { radius = Math.Abs(value); }
		}
		
		public double CalculateArea()
		{
			return Math.PI*Radius*Radius;
		}

		public double CalculatePerimeter()
		{
			return 2*Math.PI*Radius;
		}

		public override string ToString()
		{
			return $"Radius: {Radius}";
		}
	}
}