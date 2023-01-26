using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Form1 : Form
    {
        double firstValue, secondValue;
        string operators;

        public Form1()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }
            Button num = (Button)sender;

            if (textResult.Text == "0")
                textResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!textResult.Text.Contains("."))
                    {
                        textResult.Text = textResult.Text + num.Text;
                    }
                } else
                {
                    textResult.Text = textResult.Text + num.Text;
                };
            }
        }

        private void NumberOperator(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }
            Button op = (Button)sender;

            
            firstValue = Convert.ToDouble(textResult.Text);
            operators = op.Text;
            textResult.Text = "";


        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            firstValue = 0;
            secondValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }
            secondValue = Convert.ToDouble(textResult.Text);

            switch (operators)
            {
                case "-":
                    textResult.Text = Convert.ToString(firstValue - secondValue);
                    break;

                case "+":
                    textResult.Text = Convert.ToString(firstValue + secondValue);
                    break;

                case "*":
                    textResult.Text = Convert.ToString(firstValue * secondValue);
                    break;

                case "/":
                    textResult.Text = Convert.ToString(firstValue / secondValue);
                    break;

                default:
                    break;


            }
            
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";

            string f = Convert.ToString(firstValue);
            string s = Convert.ToString(secondValue);

            f = "";
            s = "";
        }

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }
            double pm = Convert.ToDouble(textResult.Text);
            textResult.Text = Convert.ToString(-1 * pm);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            if (textResult.Text.Length > 0)
            {
                textResult.Text = textResult.Text.Remove(textResult.Text.Length - 1, 1);
            }

            if (textResult.Text.Length == 0)
            {
                textResult.Text = "0";
            }
        }


        private void btnPi_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            textResult.Text = "3.141592653589793";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            if (textResult.Text == "0")
            {
                textResult.Text = "error";
            }
            else
            {
                double val = Convert.ToDouble(textResult.Text);
                val = Math.Log10(val);
                textResult.Text = Convert.ToString(val);
            }
            
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = Math.Sqrt(val);
            textResult.Text = Convert.ToString(val);
        }

        private void btnSq_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = val * val;
            textResult.Text = Convert.ToString(val);
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = val * val * val;
            textResult.Text = Convert.ToString(val);
        }

        private void btnInv_Click(object sender, EventArgs e)
        {

            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            if (textResult.Text == "0")
            {
                textResult.Text = "error";
            }
            else
            {
                double val = Convert.ToDouble(textResult.Text);
                val = 1/val;
                textResult.Text = Convert.ToString(val);
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = Math.Sin(val);
            textResult.Text = Convert.ToString(val);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = Math.Cos(val);
            textResult.Text = Convert.ToString(val);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = Math.Tan(val);
            textResult.Text = Convert.ToString(val);
        }

        private void btnSinH_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = Math.Sinh(val);
            textResult.Text = Convert.ToString(val);
        }

        private void btnCosH_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = Math.Cosh(val);
            textResult.Text = Convert.ToString(val);
        }

        private void btnTanH_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = Math.Tanh(val);
            textResult.Text = Convert.ToString(val);
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            double fact = 1;
            for (double i = val; i>0; i--)
            {
                fact = fact * i;
            }
            textResult.Text = Convert.ToString(fact);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            if (textResult.Text == "0")
            {
                textResult.Text = "error";
            }
            else
            {
                double val = Convert.ToDouble(textResult.Text);
                val = Math.Log(val);
                textResult.Text = Convert.ToString(val);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double type;
            bool isDouble = double.TryParse(textResult.Text, out type);
            if (!isDouble)
            {
                textResult.Text = "0";
            }

            double val = Convert.ToDouble(textResult.Text);
            val = val/100;
            textResult.Text = Convert.ToString(val);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
