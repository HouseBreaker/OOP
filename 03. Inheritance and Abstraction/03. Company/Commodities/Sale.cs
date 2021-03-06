﻿using System;
using _03.Company.Interfaces;

namespace _03.Company.Commodities
{
	public class Sale : ISale
	{
		public string Name { get; set; }

		public DateTime Date { get; set; }

		public decimal Price { get; set; }

		public Sale(string name, DateTime date, decimal price)
		{
			this.Name = name;
			this.Date = date;
			this.Price = price;
		}

		public override string ToString()
		{
			return this.Name + " - " + this.Price;
		}
	}
}