using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorApp;

namespace CalculatorUI
{
	public partial class MainForm : Form
	{
		Project _project = new Project();

        private void OperationValue(Operation operation)
        {
            if (_project.CurrentCalculator.Operation != Operation.None &&
                _project.CurrentCalculator.FirstValue != null &&
                ValueTextBox.Text.Length == 0)
            {
                _project.CurrentCalculator.Operation = operation;
                SetLabelStatus();
            }
            else if (ValueTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter the number", "Error");
            }
            else
            {
                if (_project.CurrentCalculator.FirstValue != null)
                {
                    Calculate();
                }

                _project.CurrentCalculator = new Calculator();

                try
                {
                    _project.CurrentCalculator.FirstValue = double.Parse(ValueTextBox.Text);
                    _project.CurrentCalculator.Operation = operation;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, $"Error");
                }

                SetLabelStatus();
            }
		}

        private void Calculate()
        {
            try
            {
                _project.CurrentCalculator.SecondValue = double.Parse(ValueTextBox.Text);
                ValueLabel.Text += ValueTextBox.Text;
                _project.CurrentCalculator.Calculate();
                _project.Calculators.Add(_project.CurrentCalculator.Clone() as Calculator);
                _project.CurrentCalculator.FirstValue = null;
                _project.Number = "";
                ProjectManager.SaveProject(_project);
              ValueTextBox.Text = _project.CurrentCalculator.Result.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, $"Error");
            }
		}

		private void OnNumberChanged(object sender, EventArgs e)
		{
			ValueTextBox.Text = _project.Number;
		}

        private void SetLabelStatus()
        {
            ValueLabel.Text = _project.CurrentCalculator.FirstValue.ToString() +
                                   _project.GetOperation();
            _project.Number = "";
        }

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
        {
            _project = ProjectManager.ReadProject();
			_project.NumberChanged += OnNumberChanged;
            ValueLabel.Text = "";
		}

  //      private void ValueTextBox_TextChanged(object sender, EventArgs e)
		//{
		//	_project.Number = ValueTextBox.Text;
		//}

		private void Button1_Click(object sender, EventArgs e)
		{
			_project.Number += "1";
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			_project.Number += "2";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			_project.Number += "3";
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			_project.Number += "4";
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			_project.Number += "5";
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			_project.Number += "6";
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			_project.Number += "7";
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			_project.Number += "8";
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			_project.Number += "9";
		}

		private void Button0_Click(object sender, EventArgs e)
		{
			_project.Number += "0";
		}

		private void ButtonDot_Click(object sender, EventArgs e)
        {
            int index = ValueTextBox.Text.IndexOf(".");
            if (index == -1)
            {
                _project.Number += ".";
            }
        }

		private void ButtonSignСhange_Click(object sender, EventArgs e)
        {
            if (_project.Number.Length != 0)
            {
                _project.Number = _project.Number.Substring(0, 1) != "-"
                    ? _project.Number.Insert(0, "-")
                    : _project.Number.Replace("-", "");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ValueLabel.Text = "";
            _project.Number = "";
            ValueTextBox.Text = "";
			_project.CurrentCalculator = new Calculator();
        }
        private void ResultButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ButtonPow_Click(object sender, EventArgs e)
        {
            OperationValue(Operation.Exponentiation);
        }

        private void ButtonDev_Click(object sender, EventArgs e)
        {
            OperationValue(Operation.Division);
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            OperationValue(Operation.Multiplication);
        }

        private void ButtonSubtraction_Click(object sender, EventArgs e)
        {
            OperationValue(Operation.Subtraction);
        }

        private void ButtonSum_Click(object sender, EventArgs e)
        {
            OperationValue(Operation.Addition);
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            var addForm = new HistoryForm();
            addForm.Calculators = _project.Calculators;
            addForm.ShowDialog();
        }

        private void MainForm_FormClosing(Object sender,
            FormClosingEventArgs e)
        {
            _project.CurrentCalculator = new Calculator();
            _project.Number = "";
            ProjectManager.SaveProject(_project);
        }
    }
}
