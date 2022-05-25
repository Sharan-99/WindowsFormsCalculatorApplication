using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsCalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Regex validation = new Regex("^[0-9]+$");
            var num1 = txtBoxFirstNumber.Text;
            var num2 = txtBoxSecondNumber.Text;
            if (!validation.IsMatch(num1) || !validation.IsMatch(num2))
            {
                MessageBox.Show("Please enter valid inputs for the operands");
            }
            else
            {
                var n1 = Convert.ToInt32(num1);
                var n2 = Convert.ToInt32(num2);
                var operation = string.Empty;
                if (rbtnAddition.Checked)
                {
                    var total = n1 + n2;
                    MessageBox.Show("Result of Addition: " + total);
                }
                else if (rbtnSubtraction.Checked)
                {
                    var total = n1 - n2;
                    MessageBox.Show("Result of Subtraction: " + total);
                }
                else if (rbtnMultiplication.Checked)
                {
                    var total = n1 * n2;
                    MessageBox.Show("Result of Multiplication: " + total);
                }
                else
                {
                    var total = n1 / n2;
                    MessageBox.Show("Result of Division: " + total);
                }
            }
        }
    }
}
