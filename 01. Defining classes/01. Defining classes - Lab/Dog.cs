﻿using System;

	class Dog
	{
		private string name;

		public Dog() 
			: this("unnamed dog", "unknown breed")
		{
				
		}

		public Dog(string name, string breed)
		{
			this.Name = name;
			this.Breed = breed;
		}

		public string Name
		{
			get { return this.name; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be blank");
				}
				this.name = value;
			}
		}
		public string Breed { get; set; }

		public void Bark()
		{
			Console.WriteLine("{0} ({1}) says Bau!", this.Name, this.Breed);
		}
	}