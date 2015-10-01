namespace _03.OOP_Inheritance_and_Abstraction___1
{
	class GoldenEditionBook : Book
	{
		private const decimal Rate = 1.3m;
		public GoldenEditionBook(string title, string author, decimal price) 
			: base(title, author, price)
		{
			this.Title = title;
			this.Author = author;
			this.Price = price;
		}

		public override decimal Price
		{
			get
			{
				return base.Price * Rate;
			}
		}
		
	}
}
