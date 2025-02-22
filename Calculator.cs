using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass_1
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool x = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultbox.Text = "0";
            label.Text = "0";
            resultValue = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnequal.PerformClick();
                operationPerformed = button.Text;
                label.Text = resultValue + " " + operationPerformed;
                x = true;
            }

            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(resultbox.Text);
                label.Text = resultValue + " " + operationPerformed;
                x = true;

            }
        }

        private void resultbox_TextChanged(object sender, EventArgs e)
        {
            x = false;
        }

        private void btnclearc_Click(object sender, EventArgs e)
        {
            resultbox.Text = "0";
            label.Text ="0" ;
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            if(resultbox.Text=="0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "9";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0" || (x))
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if ((resultbox.Text == "0") || (x));
                resultbox.Clear();

            x = false;
            resultbox.Text = resultbox.Text + ".";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; 

            if (resultValue != 0)
            {
                btnequal.PerformClick();
                operationPerformed = button.Text;
                label.Text = resultValue + " " + operationPerformed;
                x = true;
            }

            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(resultbox.Text);
                label.Text = resultValue + " " + operationPerformed;
                x = true;

            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    resultbox.Text = (resultValue + Double.Parse(resultbox.Text)).ToString();
                    break;
                case "-":
                    resultbox.Text = (resultValue - Double.Parse(resultbox.Text)).ToString();
                    break;
                case "*":
                    resultbox.Text = (resultValue * Double.Parse(resultbox.Text)).ToString();
                    break;
                case "/":
                    resultbox.Text = (resultValue / Double.Parse(resultbox.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = double.Parse(resultbox.Text);
            label.Text = "";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnequal.PerformClick();
                operationPerformed = button.Text;
                label.Text = resultValue + " " + operationPerformed;
                x = true;
            }

            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(resultbox.Text);
                label.Text = resultValue + " " + operationPerformed;
                x = true;

            }
        }

        private void btndivided_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnequal.PerformClick();
                operationPerformed = button.Text;
                label.Text = resultValue + " " + operationPerformed;
                x = true;
            }

            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(resultbox.Text);
                label.Text = resultValue + " " + operationPerformed;
                x = true;

            }
        }
    }
}
