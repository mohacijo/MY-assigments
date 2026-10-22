using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap_Assigment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Declare variables
            double calories;
            double fat;
            double fatCalories;
            double percentage;

            

            // Validate calories
            if (!double.TryParse(txtcalories.Text, out calories)
                || calories <= 0)
            {
                MessageBox.Show("Calories must be greater than 0.");
                txtcalories .Focus();
                return;
            }

            // Validate fat grams
            if (!double.TryParse(txtfat.Text, out fat) || fat <= 0)
            {
                MessageBox.Show("Fat must be greater than 0.");
                txtfat.Focus();
                return;
            }

            // Calculate calories from fat
            fatCalories = fat * 9;

            // Fat calories cannot exceed total calories
            if (fatCalories > calories)
            {
                MessageBox.Show(
                    "Calories from fat cannot exceed total calories.");
                txtfat.Focus();
                return;
            }

            // Calculate fat percentage
            percentage = (fatCalories / calories) * 100;

            // Display number of calories
            lblcolories.Text = fatCalories.ToString("N2");

            // Display fat percentage
            lblpercentage.Text = percentage.ToString("N2") + "%";

            // Check Low Fat
           btncheckBox.Checked = percentage < 30;
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and labels
            txtcalories.Clear();
            txtfat.Clear();
            lblcolories.Text = string.Empty;
            lblpercentage.Text = string.Empty;
            btncheckBox.Checked = false;

        }
    }
}
