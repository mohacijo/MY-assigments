using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating values for food and prices
            string food1, food2;
            double price1, price2;
            //getting values from textboxes
            food1 = food1textBox.Text;
            food2 = food2textBox.Text;
            price1 = double.Parse(price1textBox.Text);
            price2 = double.Parse(price2textBox.Text);
            //calculating the sum of prices, sales tax, tips, and total
            double sum = price1 + price2;
            //calculating sales tax and tips
            double salesText = sum * 0.07;
            double tips = sum * 0.15;
            //calculating total
            double total = (sum + salesText) - tips;
            //displaying the results in labels

            StextBox.Text = salesText.ToString("C");
            TtextBox.Text = tips.ToString("C");
            TotaltextBox.Text = total.ToString("C");
        }
    }
}
