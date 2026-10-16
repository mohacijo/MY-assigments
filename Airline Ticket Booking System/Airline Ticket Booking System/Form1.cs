using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
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

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Declaring variables;
            string name, travelClass;
            int passengerAge, numberofTickets;
            double buggageWeight, discount, childDiscount, seniorDiscount, insurance, travelClassPrice, basicTicketCost;
            //inialising the variable name and also initialising some variables with texbox input
            name = txtname.Text;
            //validating numeric data input
            if (!int.TryParse(txtAge.Text, out passengerAge) ||
                !int.TryParse(txtnumberoftickets.Text, out numberofTickets) ||
                !double.TryParse(txtbaggageweigth.Text, out buggageWeight))
            {
                MessageBox.Show("Please input a numeric data");
                return;
            }
            //validate age
            if (passengerAge < 1 || passengerAge > 100)
            {
                MessageBox.Show("Age must be between 1 and 100");
                return;
            }
            //validate number of tickets
            if (numberofTickets < 1 || numberofTickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5");
                return;
            }
            //validate buggage weight
            if (buggageWeight <= 0 || buggageWeight > 50)
            {
                MessageBox.Show("Buggage weight cannot be negative and cannot exceed 50");
                return;
            }
            //select travel class
            if(rbtnfirst.Checked)
            {
                travelClass = "First class";
                travelClassPrice = 400;

                if (passengerAge < 12)
                {
                    MessageBox.Show("Passenger below 12 cannot book first class");
                    listBox1.Items.Add("Booking rejected");
                    return;
                }
            }

            else if (rbtnnormal.Checked)
            {
                travelClass = "Normal class";
                travelClassPrice = 150;
            }
            else if (rbtnbusiness.Checked)
            {
                travelClass = "Business class";
                travelClassPrice = 650;
            }

            else
            {
                MessageBox.Show("Please select a travel class");
                return;
            }
            //calculating basic ticket cost
            basicTicketCost = travelClassPrice * numberofTickets;
            //calculating ticket discounts
            discount = 0;
            if (numberofTickets >= 3 && numberofTickets <= 4)
            {
                discount = 0.05 * basicTicketCost;

            }
            else if (numberofTickets == 5)
            {
                discount = 0.1 * basicTicketCost;

            }
            //calculating cost after ticket discount
            double subTotal = basicTicketCost - discount;
            //calculating child and senior discount
            childDiscount = 0;
            if (passengerAge < 12)
            {
                childDiscount = 0.2 * subTotal;
            }
            seniorDiscount = 0;
            if (passengerAge >= 60)
            {
                seniorDiscount = 0.1 * subTotal;
            }

            insurance = 0;
            if (checkboxinsurance.Checked)
            {
                insurance = 25 * numberofTickets;
            }
            //final cost calculation
            double finalCost = subTotal - childDiscount - seniorDiscount + insurance;

            //displaying the output in the listbox
            listBox1.Items.Clear();
            listBox1.Items.Add("Passenger Name: " + name);
            listBox1.Items.Add("Passenger Age: " + passengerAge);
            listBox1.Items.Add("Travel Class: " + travelClass);
            listBox1.Items.Add("Number of Tickets: " + numberofTickets);
            listBox1.Items.Add("Buggage Weight: " + buggageWeight + " kg");
            listBox1.Items.Add("Basic Ticket Cost: $" + basicTicketCost);
            listBox1.Items.Add("Ticket Discount: $" + discount);
            listBox1.Items.Add("Child Discount: $" + childDiscount);
            listBox1.Items.Add("Senior Discount: $" + seniorDiscount);
            listBox1.Items.Add("Insurance Cost: $" + insurance);
            listBox1.Items.Add("Final Cost: $" + finalCost);

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clearing all the input fields and listbox
            txtname.Clear();
            txtAge.Clear();
            txtnumberoftickets.Clear();
            txtbaggageweigth.Clear();
            rbtnfirst.Checked = false;
            rbtnnormal.Checked = false;
            rbtnbusiness.Checked = false;
            checkboxinsurance.Checked = false;
            listBox1.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exiting the application
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
