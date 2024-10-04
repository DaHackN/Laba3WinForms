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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Цельсий в Фаренгейт");
            comboBox1.Items.Add("Фаренгейт в Цельсий");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperature;
            
            if (double.TryParse(textBox1.Text, out temperature))
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    double fahrenheit = CelsiusToFahrenheit(temperature);
                    label1.Text = $"{fahrenheit:F2} F";
                }
                else
                {
                    double celsius = FahrenheitToCelsius(temperature);
                    label1.Text = $"{celsius:F2} C";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите конкретное значение температуры");

            }
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
