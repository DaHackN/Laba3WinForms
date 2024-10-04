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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lapka3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b))
            {
                RandNum(a,b);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите конкретные числа");
            }
        }

        private void RandNum(double a, double b)
        {
            Random random = new Random();
            double result = a + (b - a) * random.NextDouble();
            label1.Text = $"{result}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}

