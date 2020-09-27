using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalculatorApp;

namespace CalculatorUI
{
    public partial class HistoryForm : Form
    {
        public List<Calculator> Calculators;
        private List<Calculator> _searchedCalculators;

        private void UpdateListBox(List<Calculator> results)
        {
            _searchedCalculators = results;
            ResultsListBox.DataSource = null;
            ResultsListBox.DataSource = _searchedCalculators;
        }

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            UpdateListBox(Calculators);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateResult = dateTimePicker1.Value;
            List<Calculator> searchedCalculators = new List<Calculator>();
            foreach (var calculator in Calculators)
            {
                if (calculator != null && calculator.TimeResult.Year == dateResult.Year &&
                    calculator.TimeResult.Month == dateResult.Month && 
                    calculator.TimeResult.Day == dateResult.Day)
                {
                    searchedCalculators.Add(calculator);
                }
            }

            UpdateListBox(searchedCalculators);
        }
    }
}
