using System;
using System.IO;
using System.Text;
using _02.Static_Members_and_Namespaces_Homework.Geometry.Geometry3D;

namespace _02.Static_Members_and_Namespaces_Homework.Geometry.Storage
{
	public static class GeometryTxtStorage
	{
		public static Path3D LoadPathFromFile(string filePath)
		{
			Path3D path = new Path3D();
			
			foreach (var line in File.ReadLines(filePath))
			{
				var tokens = line.Split(new[] {", "}, StringSplitOptions.None);

				var x = double.Parse(tokens[0]);
				var y = double.Parse(tokens[1]);
				var z = double.Parse(tokens[2]);

				path.Add(new Point3D(x, y, z));
			}

			return path;
		}

		public static void SavePathToFile(Path3D path, string filePath)
		{
			var sb = new StringBuilder();

			foreach (var point in path)
			{
				sb.AppendLine($"{point.X}, {point.Y}, {point.Z}");
			}
			
			File.WriteAllText(filePath, sb.ToString().TrimEnd());
			Console.WriteLine($"Path saved to {filePath}");
		}
	}
}