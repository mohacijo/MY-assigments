using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //import the class
            StreamWriter outputFile;
            //create a new file
            outputFile = File.CreateText("output.txt");
            outputFile.WriteLine("hello world");
            outputFile.WriteLine("welcome to C#");
            outputFile.WriteLine("my name is mohamed cijo");
            outputFile.WriteLine("This is my first file");

            //close the file
            outputFile.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //import the class
            StreamReader inputFile;
            //open the file
            inputFile = File.OpenText("output.txt");
            //read the file
            String line;
            while (inputFile.EndOfStream == false)
            {
                line = inputFile.ReadLine();
                listBox1.Items.Add(line);
            }

            //close the file
            inputFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //file delete
            File.Delete("output.txt");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear the ListBox
            listBox1.Items.Clear();

            // Clear the file contents if the file exists
            if (File.Exists("output.txt"))
            {
                File.WriteAllText("output.txt", "");
            }



        }
    }
}
