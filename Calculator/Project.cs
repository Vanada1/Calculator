using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
	public class Project
	{
		/// <summary>
		/// Calculation list
		/// </summary>
		List<Calculator> Calculators { get; set; }

		/// <summary>
		/// Constructor for <see cref="Project"/> class
		/// </summary>
		/// <param name="calculators"></param>
		public Project(List<Calculator> calculators)
		{
			Calculators = calculators;
		}

		/// <summary>
		/// Default constructor for <see cref="Project"/> class
		/// </summary>
		public Project()
		{
			Calculators = new List<Calculator>();
		}

		/// <summary>
		/// Searches all calculations for a specific date
		/// </summary>
		/// <param name="time"> date for search</param>
		/// <returns>List of found calculations </returns>
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
