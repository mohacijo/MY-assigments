using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from TextBoxes
                string customerName = textCustomer.Text;

                double previousReading = double.Parse(textPrevious.Text);
                double currentReading = double.Parse(textCurrent.Text);
                double pricePerUnit = double.Parse(textUnitPrice.Text);

                // Calculate electricity usage
                double electricityUsage = currentReading - previousReading;

                // Calculate bill
                double bill = electricityUsage * pricePerUnit;

                // Calculate tax 7%
                double taxAmount = bill * 0.07;

                // Calculate total bill
                double totalBill = bill + taxAmount;

                // Display results
                textElectricity.Text = electricityUsage.ToString();
               Taxamount.Text = taxAmount.ToString("0.00");
               Totalbill.Text = totalBill.ToString("0.00");

                // Display customer information
                Totalbill.Text =
                    "Customer: " + customerName +
                    "\nUnits Used: " + electricityUsage +
                    "\nBill: $" + bill.ToString("0.00") +
                    "\nTax: $" + taxAmount.ToString("0.00") +
                    "\nFixed Charge: $0.00";
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
