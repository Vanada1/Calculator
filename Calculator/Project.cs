using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
	public class Project
	{
		List<Calculator> Calculators { get; set; }

		public Project(List<Calculator> calculators)
		{
			Calculators = calculators;
		}

		public Project()
		{
			Calculators = new List<Calculator>();
		}

		public List<Calculator> GetDataByTime(DateTime time)
		{
			List<Calculator> foundCalculators = new List<Calculator>();
			foreach (var calculator in Calculators)
			{
				if((calculator.TimeResult.Year == time.Year) && 
					(calculator.TimeResult.Month == time.Month) &&
					(calculator.TimeResult.Day == time.Day))
				{
					foundCalculators.Add(calculator);
				}
			}

			return foundCalculators;
		}
	}
}
