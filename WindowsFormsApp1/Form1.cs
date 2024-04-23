using System;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        private double u = 0, r1 = 0, r2 = 0;
        private double epsilon = 1e-6;

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out r1))
            {
                Calculate();
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out r2))
            {
                Calculate();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out u))
            {
                Calculate();
            }
        }

        public void Calculate()
        {
            double r;
            double i;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (radioButton1.Checked)
                {
                    if (r1 + r2 < epsilon)
                    {
                        textBox4.Text = "Ошибка!";
                    }
                    else
                    {
                        r = r1 + r2;
                        i = u / r;
                        textBox4.Text = $"{(i):0.000} A";
                    }
                }
                else
                {
                    if (r1 * r2 < epsilon)
                    {
                        textBox4.Text = "Ошибка!";
                    }
                    else
                    {
                        r = (r1 * r2) / (r1 + r2);
                        i = u / r;
                        textBox4.Text = $"{i:0.000} A";
                    }
                }
            }
        }
    }
}
