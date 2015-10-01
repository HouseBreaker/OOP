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

		public void Add(double x, double y, double z)
		{
			points.Add(new Point3D(x, y, z));
		}

		public string TotalLength()
		{
			double totalLength = 0;
			int totalPoints = 1;
			for (int i = 0; i < points.Count - 1; i++)
			{
				totalLength += DistanceCalculator3D.Calc(points[i], points[i + 1]);
				totalPoints++;
			}
			return $"Total length of {totalPoints} points: {totalLength}";
		}

		public override string ToString()
		{
			StringBuilder store = new StringBuilder();
			int count = 1;
			foreach (var point in points)
			{
				store.Append($"Point {count}: {point.X}, {point.Y}, {point.Z}\n");
				count++;
			}
			string store2 = store.ToString().Trim();
			return store2;
		}
	}
}

