using System;
using System.Text;

namespace _03.OOP_Inheritance_and_Abstraction___1
{
	public class Book
	{
		private string title, author;
		private decimal price;

		public Book(string title, string author, decimal price)
		{
			this.Title = title;
			this.Author = author;
			this.Price = price;
		}

		public string Title
		{
			get { return this.title; }
			protected set
			{
				ValidateString(value, "title");
				this.title = value;
			}
		}

		public string Author
		{
			get { return this.author; }
			protected set
			{
				ValidateString(value, "author");
				this.author = value;
			}
		}

		public virtual decimal Price
		{
			get { return this.price; }
			protected set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("Price cannot be negative.");
				}
				this.price = value;
			}
		}


		private void ValidateString(string value, string param)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentNullException(param, "String cannot be empty or whitespace");
			}
		}

		public override string ToString()
		{
			StringBuilder outSb = new StringBuilder();
			outSb.AppendFormat($"-Type: {this.GetType().Name}{Environment.NewLine}");
			outSb.AppendFormat($"-Title: {this.Title}{Environment.NewLine}");
			outSb.AppendFormat($"-Author: {this.Author}{Environment.NewLine}");
			outSb.AppendFormat($"-Price: {this.Price:F2}");

			return outSb.ToString();
		}
	}
}
