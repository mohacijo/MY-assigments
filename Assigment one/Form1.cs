using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void outputlabel_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            String week, year, month, day;
            week = dayofweekTextBox.Text;
            month = monthTextBox.Text;
            year = yearTextBox.Text;
            day = dayofmonthTextBox.Text;
            outputlabel.Text = week + " " + day + " " + month + " " + year;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dayofweekTextBox.Clear();
            dayofmonthTextBox.Clear();
            yearTextBox.Clear();
            monthTextBox.Clear();
           outputlabel.Text = "";
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
