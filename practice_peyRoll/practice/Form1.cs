using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating variable

            double hour_worked, payrate, grosspay;

            double validation;
            //prevent exception date conversitoin using try parse mehtod
            if (double.TryParse(textHourworked.Text, out validation) & double.TryParse(textPeyrate.Text, out validation))
            {

                //assigment variable
                hour_worked = double.Parse(textHourworked.Text);
                payrate = double.Parse(textPeyrate.Text);
                //checking validatio user
                if (hour_worked > 0 & payrate > 0)
                {
                    //calculate the gross pay
                    grosspay = hour_worked * payrate;
                    lblcalculate.Text = grosspay.ToString("c");


                }
                else
                {
                    MessageBox.Show("hours_worked or paytate must be greater then 0");
                }
            }
            else
            {
                MessageBox.Show("txthours,txtpayrate only accept double or int");
            }
        



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textHourworked.Clear();
            textPeyrate.Clear();
            lblcalculate.Text = "";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

