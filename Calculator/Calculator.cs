using System;

namespace CalculatorApp
{
	/// <summary>
	/// Main class of program 
	/// </summary>
	public class Calculator:ICloneable
    {

        /// <summary>
        /// First number property
        /// </summary>
        public double? FirstValue { get; set; }

        /// <summary>
		/// Second number property
		/// </summary>
		public double? SecondValue { get; set; }

		/// <summary>
		/// Calculation <see cref="Result"/> property
		/// </summary>
		public double? Result { get; private set; } = 0.0;

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
		/// <param name="firstValue"></param>
		/// <param name="secondValue"></param>
		/// <param name="operation"></param>
		public Calculator(double? firstValue, double? secondValue,
			Operation operation)
		{
			FirstValue = firstValue;
			SecondValue = secondValue;
			Operation = operation;
		}

        /// <summary>
        /// Default constructor for <see cref="Calculator"/> class
        /// </summary>
		public Calculator()
        {
            FirstValue = null;
            SecondValue = null;
            Operation = Operation.None;
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
					Result = FirstValue + SecondValue;
					break;
				}
				case Operation.Subtraction:
				{
					Result = FirstValue - SecondValue;
					break;
				}
				case Operation.Multiplication:
				{
					Result = FirstValue * SecondValue;
					break;
				}
				case Operation.Division:
				{
					Result = FirstValue / SecondValue;
					break;
				}
				case Operation.Exponentiation:
				{
                    if (FirstValue != null && SecondValue != null)
                    {
                        Result = Math.Pow((double)FirstValue, (double)SecondValue);
                    }
                    else
                    {
                        throw new Exception(nameof(FirstValue) + "  null or " +
                                            nameof(SecondValue) + " null");
                    }
					break;
				}
				default:
				{
					throw new ArgumentException("Unknown command");
				}
			}

            if (Result == null)
            {
                throw new Exception("Result is null");
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

			return ($"{FirstValue} {operation} {SecondValue} = {Result} " +
				TimeResult.ToString());
		}

        public object Clone()
        {
            return new Calculator(FirstValue, SecondValue, Operation);
        }
    }
}
