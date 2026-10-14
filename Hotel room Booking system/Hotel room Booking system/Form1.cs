using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_room_Booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnstandard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Declare variables

            string guestName;

            string roomType = "";

            int age, nights, guests;

            double roomRate = 0;

            double basicCost, stayDiscount = 0;

            double seniorDiscount = 0;

            double breakfastCost = 0;

            double surcharge = 0;

            double finalCost;

            bool bookingApproved = true;

            // Get guest name

            guestName = txtguestname.Text.Trim();

            // Validate guest name

            if (guestName == "")

            {

                MessageBox.Show("Guest name cannot be empty.");

                txtguestname.Focus();

                return;

            }

            // Validate numeric inputs using TryParse

            if (!int.TryParse(txtguestage.Text, out age))

            {

                MessageBox.Show("Enter a valid guest age.");

                txtguestage.Focus();

                return;

            }

            if (!int.TryParse(txtnight.Text, out nights))

            {

                MessageBox.Show("Enter a valid number of nights.");

                txtnight.Focus();

                return;

            }

            if (!int.TryParse(txtguestnumber.Text, out guests))

            {

                MessageBox.Show("Enter a valid number of guests.");

                txtguestnumber.Focus();

                return;

            }

            // Validate age

            if (age < 18 || age > 90)

            {

                MessageBox.Show("Age must be between 18 and 90.");

                return;

            }

            // Validate nights

            if (nights < 1 || nights > 30)

            {

                MessageBox.Show("Nights must be between 1 and 30.");

                return;

            }

            // Validate number of guests

            if (guests < 1 || guests > 6)

            {

                MessageBox.Show("Guests must be between 1 and 6.");

                return;

            }

            // Determine room type and rate using switch

            if (rstandard.Checked)

            {

                roomType = "Standard";

            }

            else if (rbtnNormal.Checked)

            {

                roomType = "Normal";

            }

            else if (rhight.Checked)

            {

                roomType = "Hight";

            }

            else

            {

                MessageBox.Show("Please select a room type.");

                return;

            }

            switch (roomType)

            {

                case "Standard":

                    roomRate = 50;

                    if (guests > 2)

                    {

                        bookingApproved = false;

                    }

                    break;

                case "Normal":

                    roomRate = 80;

                    // Normal is treated as Deluxe (maximum 4 guests)

                    if (guests > 4)

                    {

                        bookingApproved = false;

                    }

                    break;

                case "Hight":

                    roomRate = 130;

                    // Hight is treated as Suite (maximum 6 guests)

                    if (guests > 6)

                    {

                        bookingApproved = false;

                    }

                    break;

            }

            // Display booking approval or rejection

            if (!bookingApproved)

            {

                listBox1.Items.Clear();

                listBox1.Items.Add("BOOKING REJECTED");

                listBox1.Items.Add("--------------------------");

                listBox1.Items.Add("Guest: " + guestName);

                listBox1.Items.Add("Room Type: " + roomType);

                listBox1.Items.Add("Number of Guests: " + guests);

                listBox1.Items.Add("Guest capacity exceeded.");

                MessageBox.Show(

                    "Booking rejected! Too many guests for this room.",

                    "Booking Status",

                    MessageBoxButtons.OK,

                    MessageBoxIcon.Warning);

                return;

            }

            // Calculate basic room cost

            basicCost = roomRate * nights;

            // Stay discount

            if (nights >= 1 && nights <= 4)

            {

                stayDiscount = 0;

            }

            else if (nights >= 5 && nights <= 9)

            {

                stayDiscount = basicCost * 0.05;

            }

            else if (nights >= 10)

            {

                stayDiscount = basicCost * 0.12;

            }

            // Additional senior discount

            if (age >= 60)

            {

                seniorDiscount = basicCost * 0.05;

            }

            // Breakfast: $10 per guest per night

            if (btncheckbox.Checked)

            {

                breakfastCost = guests * nights * 10;

            }

            // Calculate cost after discounts

            double discountedRoomCost =

                basicCost - stayDiscount - seniorDiscount;

            // Service surcharge for more than 4 guests

            if (guests > 4)

            {

                surcharge = discountedRoomCost * 0.05;

            }

            // Calculate final cost

            finalCost = discountedRoomCost

                      + breakfastCost

                      + surcharge;

            // Display results in ListBox

            listBox1.Items.Clear();

            listBox1.Items.Add("HOTEL ROOM BOOKING");

            listBox1.Items.Add("==========================");

            listBox1.Items.Add("Booking Approved!");

            listBox1.Items.Add("--------------------------");

            listBox1.Items.Add("Guest Name: " + guestName);

            listBox1.Items.Add("Guest Age: " + age);

            listBox1.Items.Add("Room Type: " + roomType);

            listBox1.Items.Add("Rate Per Night: $" +

                roomRate.ToString("0.00"));

            listBox1.Items.Add("Number of Nights: " + nights);

            listBox1.Items.Add("Number of Guests: " + guests);

            listBox1.Items.Add("--------------------------");

            listBox1.Items.Add("Basic Room Cost: $" +

                basicCost.ToString("0.00"));

            listBox1.Items.Add("Stay Discount: -$" +

                stayDiscount.ToString("0.00"));

            listBox1.Items.Add("Senior Discount: -$" +

                seniorDiscount.ToString("0.00"));

            listBox1.Items.Add("Breakfast Cost: +$" +

                breakfastCost.ToString("0.00"));

            listBox1.Items.Add("Service Surcharge: +$" +

                surcharge.ToString("0.00"));

            listBox1.Items.Add("--------------------------");

            listBox1.Items.Add("TOTAL COST: $" +

                finalCost.ToString("0.00"));
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear all input fields and selections
            txtguestname.Clear();
            txtguestage.Clear();
            txtnight.Clear();
            txtguestnumber.Clear();
            // Clear radio buttons and checkbox
            rstandard.Checked = false;
            rbtnNormal.Checked = false;
            rhight.Checked = false;
            // Clear checkbox
            btncheckbox.Checked = false;
            // Clear the ListBox
            listBox1.Items.Clear();


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();

        }
    }
}
