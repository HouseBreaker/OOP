using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Static_Members_and_Namespaces_Homework.Geometry.Geometry3D
{
	public class Path3D : IEnumerable<Point3D>
	{
		private readonly List<Point3D> points;

		public Path3D()
		{
			points = new List<Point3D>();
		}

		public IEnumerator<Point3D> GetEnumerator()
		{
			return points.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Point3D point)
		{
			points.Add(point);
		}

		public double TotalLength()
		{
			double totalLength = 0;
			for (int i = 0; i < points.Count - 1; i++)
			{
				totalLength += DistanceCalculator3D.Calc(points[i], points[i + 1]);
			}

			return totalLength;
		}

		public override string ToString()
		{
			StringBuilder store = new StringBuilder();
			int count = 1;
			foreach (var point in points)
			{
				store.AppendLine($"Point {count}: {point.X}, {point.Y}, {point.Z}");
				count++;
			}

			return store.ToString().Trim();
		}
	}
}