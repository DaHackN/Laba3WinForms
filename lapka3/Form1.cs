using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lapka3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a + b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a - b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) =>
            {
                if (b == 0)
                {
                    MessageBox.Show("На ноль делить нельзя.");
                    return 0;
                }
                return a / b;
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) =>
            {
                if (b == 0)
                {
                    MessageBox.Show("На ноль делить нельзя.");
                    return 0;
                }
                return Math.Floor(a / b);
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PerformOperation((a,b) => (Math.Pow(a,b)));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) =>
            {
                if (b == 0)
                {
                    MessageBox.Show("На ноль делить нельзя.");
                    return 0;
                }
                return a % b;
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => (Math.Log(a, b)));
        }

        private void PerformOperation(Func<double, double, double> operation)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = operation(num1, num2);
                label1.Text = $"Результат: {result}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите конкретные числа");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
