using System;

namespace Calculator
{
	/// <summary>
	/// Main class of program 
	/// </summary>
	public class Calculator
	{
		/// <summary>
		/// First number property
		/// </summary>
		public double FirstNumber { get; set; }

		/// <summary>
		/// Second number property
		/// </summary>
		public double SecondNumber { get; set; }

		/// <summary>
		/// Calculation <see cref="Result"/> property
		/// </summary>
		public double Result { get; private set; } = 0.0;

		/// <summary>
		/// <see cref="Operation"/> property
		/// </summary>
		public Operation Operation { get; set; }

		/// <summary>
		/// <see cref="TimeResult"/> property
		/// </summary>
		public DateTime TimeResult { get; private set; }

		/// <summary>
		/// Constructor for <see cref="Calculator"/> class
		/// </summary>
		/// <param name="firstNumber"></param>
		/// <param name="secondNumber"></param>
		/// <param name="operation"></param>
		public Calculator(double firstNumber, double secondNumber,
			Operation operation)
        {
			FirstNumber = firstNumber;
			SecondNumber = secondNumber;
			Operation = operation;
        }

		/// <summary>
		/// <see cref="Calculate"/> <see cref="Result"/>
		/// </summary>
		public void Calculate()
		{
			switch (Operation)
			{
				case Operation.Addition:
				{
					Result = FirstNumber + SecondNumber;
					break;
				}
				case Operation.Subtraction:
				{
					Result = FirstNumber - SecondNumber;
					break;
				}
				case Operation.Multiplication:
				{
					Result = FirstNumber * SecondNumber;
					break;
				}
				case Operation.Division:
				{
					Result = FirstNumber / SecondNumber;
					break;
				}
				case Operation.Exponentiation:
				{
					Result = Math.Pow(FirstNumber, SecondNumber);
					break;
				}
				default:
				{
					throw new ArgumentException("Unknown comand");
				}
			}

			TimeResult = DateTime.Now;
		}

		/// <summary>
		/// Override metod <see cref="ToString"/>
		/// </summary>
		/// <returns> <see cref="string"/> class</returns>
        public override string ToString()
        {
			string operation;
			switch (Operation)
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
						throw new ArgumentException("Unknown comand");
					}
			}

			return ($"{FirstNumber} {operation} {SecondNumber} = {Result} " +
				TimeResult.ToString());
        }
    }
}
