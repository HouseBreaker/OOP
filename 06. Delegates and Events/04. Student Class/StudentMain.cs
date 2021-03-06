﻿using System;

namespace _04.Student_Class
{
	class StudentMain
	{
		static void Main(string[] args)
		{
			Student student = new Student("Peter", 22);
			student.PropertyChange += (sender, eventArgs) =>
			{
				Console.WriteLine("Property changed: {0} (from {1} to {2})",
					eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
			};
			student.Name = "Maria";
			student.Age = 19;

		}
	}
}