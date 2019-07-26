using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorForm
{
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// This is the constructor for the CalculatorForm 
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is a Shared event handler for the CalculatorButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;

            int ButtonValue;
            bool Result = int.TryParse(TheButton.Text, out ButtonValue);

            if (Result)
            {

                ResultLabel.Text = TheButton.Text;

            }
            else
            {
                ResultLabel.Text = "Not a Number";
            }
        }
    }
}
