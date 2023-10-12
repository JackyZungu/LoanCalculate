using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loanAmnt = 0.0;
            double downPay = 0.0;
            double interestRate = 0.0;  
            double monthlyPay  = 0.0;
            int terms = 0;
            {
                try
                {

                    if (!string.IsNullOrEmpty(textBox1.Text))
                        loanAmnt = Convert.ToDouble(textBox1.Text);

                    if (!string.IsNullOrEmpty(textBox2.Text))
                        downPay = Convert.ToDouble(textBox2.Text);

                    if (!string.IsNullOrEmpty(textBox3.Text))
                        interestRate = Convert.ToDouble(textBox3.Text);
                    if (!string.IsNullOrEmpty(textBox4.Text))
                        terms = Convert.ToInt32(textBox4.Text);

                    int termsinMonths = terms * 12;
                    monthlyPay = (loanAmnt - downPay) * (Math.Pow((1 + interestRate / 12),
                        termsinMonths) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsinMonths) - 1));

                    monthlyPay = Math.Round(monthlyPay, 2);
                }
                catch
                {
                    MessageBox.Show("Please provide numerical value");
                }

                lbMonthlyPay.Text = "R" + monthlyPay.ToString();

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             double loanAmnt = 0.0;             
            double downPay = 0.0;
            double interestRate = 0.0; 
            double monthlyPay = 0.0;
            int terms = 0;

            
            if (!String.IsNullOrEmpty(textBox1.Text))
                loanAmnt = Convert.ToDouble(textBox1.Text);

            if (!String.IsNullOrEmpty(textBox2.Text)) 
                downPay = Convert.ToDouble(textBox2.Text);

            if (!String.IsNullOrEmpty(textBox3.Text)) 
                interestRate = Convert.ToDouble(textBox3.Text);
            if (!String.IsNullOrEmpty(textBox4.Text)) 
                terms = Convert.ToInt32(textBox4.Text);
          
                         
            int termsinMonths = terms * 12;             interestRate /= 12; 
            monthlyPay = (interestRate * loanAmnt) / (1 - Math.Pow(1 + interestRate, termsinMonths * -1));
            monthlyPay = Math.Round(monthlyPay, 2);

            lbMonthlyPay.Text = "R" + monthlyPay.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
