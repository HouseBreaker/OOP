namespace _02.Static_Members_and_Namespaces_Homework.Geometry.Geometry3D
{
	public class Point3D
	{
		public Point3D(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }

		public static Point3D StartingPoint { get; } = new Point3D(0, 0, 0);

		public override string ToString()
		{
			return $"X: {X}|Y: {Y}|Z: {Z}";
		}
	}
}
