using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Interest_Rate_Calculator
{
	public delegate decimal CalculateInterest(decimal sum, double interest, int years);

	class InterestRateCalculator
	{
		private readonly CalculateInterest interestDelegate;

		public InterestRateCalculator(decimal sum, double interest, int years, CalculateInterest interestDelegate)
		{
			this.Sum = sum;
			this.Interest = interest;
			this.Years = years;
			this.interestDelegate = interestDelegate;
		}

		private decimal Sum { get; set; }

		private double Interest { get; set; }

		private int Years { get; set; }

		public override string ToString()
		{
			return $"{this.interestDelegate(this.Sum, this.Interest, this.Years):F4}";
		}
	}
}