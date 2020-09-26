using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace CalculatorUI
{
	public partial class MainForm : Form
	{
		Project _project = new Project();

		private void OnNumberChanged(object sender, EventArgs e)
		{
			ValueTextBox.Text = _project.Number;
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_project.NumberChenged += OnNumberChanged;
            FirstValueLabel.Text = "";
            OperatorLabel.Text = "";
		}
		private void ValueTextBox_TextChanged(object sender, EventArgs e)
		{
			_project.Number = ValueTextBox.Text;
		}
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
			_project.Number += ".";
		}

		private void ButtonResever_Click(object sender, EventArgs e)
        {
            _project.Number = _project.Number.Substring(0,1) != "-" ?
                _project.Number.Insert(0, "-") : 
                _project.Number.Replace("-", "");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstValueLabel.Text = "";
            OperatorLabel.Text = "";
            _project.Number = "";
        }
    }
}
