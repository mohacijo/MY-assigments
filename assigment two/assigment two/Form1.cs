using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            String name = textname.Text;
            int studentid = int.Parse(textsid.Text);
            String department = textdepartment.Text;
            int semester = int.Parse(textsemester.Text);
            lbloutput.Text = "Name: " + name + "\nStudent ID: " + studentid + "Department: " + department + "Semester: " + semester;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textname.Text = "";
            textsid.Text = "";
            textdepartment.Text = "";
            textsemester.Text = "";
            lbloutput.Text = "";
        }
    }
}
