namespace CalculatorUI
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.ResultsListBox = new System.Windows.Forms.ListBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// ResultsListBox
			// 
			this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsListBox.FormattingEnabled = true;
			this.ResultsListBox.ItemHeight = 15;
			this.ResultsListBox.Location = new System.Drawing.Point(18, 42);
			this.ResultsListBox.Name = "ResultsListBox";
			this.ResultsListBox.ScrollAlwaysVisible = true;
			this.ResultsListBox.Size = new System.Drawing.Size(227, 334);
			this.ResultsListBox.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.Location = new System.Drawing.Point(18, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(227, 23);
			this.dateTimePicker1.TabIndex = 3;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// HistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 391);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.ResultsListBox);
			this.MinimumSize = new System.Drawing.Size(280, 430);
			this.Name = "HistoryForm";
			this.Text = "HistoryForm";
			this.Load += new System.EventHandler(this.HistoryForm_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}