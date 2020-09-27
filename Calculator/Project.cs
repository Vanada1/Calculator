using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
	public class Project
    {
        private string _number;

        /// <summary>
		/// Set and return values
		/// </summary>
		public List<Calculator> Calculators { get; set; }

        /// <summary>
        /// Set and return values in textbox
        /// </summary>
        public string Number
        {
            get => _number;
            set
            {
                if (Number != value)
                {
                    _number = value;
					NumberChanged?.Invoke(this, new EventArgs());
                }
            }
        }

		/// <summary>
		/// Set and return Current values of program
		/// </summary>
		public Calculator CurrentCalculator { get; set; }

		/// <summary>
		/// Constructor for <see cref="Project"/> class
		/// </summary>
		/// <param name="calculators"></param>
		public Project(List<Calculator> calculators)
		{
			Calculators = calculators;
            Number = "";
			CurrentCalculator = new Calculator();
        }

        /// <summary>
		/// Default constructor for <see cref="Project"/> class
		/// </summary>
		public Project()
		{
			Calculators = new List<Calculator>();
            Number = "";
            CurrentCalculator = new Calculator();
        }

		/// <summary>
		/// Activity the event when changed value element
		/// </summary>
		public event EventHandler NumberChanged;

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

        public string GetOperation()
        {
            string operation;

            switch (CurrentCalculator.Operation)
            {
                case Operation.Addition:
                {
                    operation = "+";
                    break;
                }
                case Operation.Subtraction:
                {
                    operation = "-";
                    break;
                }
                case Operation.Multiplication:
                {
                    operation = "*";
                    break;
                }
                case Operation.Division:
                {
                    operation = "/";
                    break;
                }
                case Operation.Exponentiation:
                {
                    operation = "^"; ;
                    break;
                }
                default:
                {
                    throw new ArgumentException("Unknown command");
                }
            }

            return operation;
        }
    }
}
