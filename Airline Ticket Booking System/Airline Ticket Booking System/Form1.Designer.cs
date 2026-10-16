namespace Airline_Ticket_Booking_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtnumberoftickets = new System.Windows.Forms.TextBox();
            this.txtbaggageweigth = new System.Windows.Forms.TextBox();
            this.rbtnfirst = new System.Windows.Forms.RadioButton();
            this.rbtnbusiness = new System.Windows.Forms.RadioButton();
            this.rbtnnormal = new System.Windows.Forms.RadioButton();
            this.checkboxinsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passenger Age: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numbe of tickets: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Baggage weight(kg): ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(535, 79);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(453, 56);
            this.txtname.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(535, 158);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(453, 56);
            this.txtAge.TabIndex = 5;
            // 
            // txtnumberoftickets
            // 
            this.txtnumberoftickets.Location = new System.Drawing.Point(535, 252);
            this.txtnumberoftickets.Multiline = true;
            this.txtnumberoftickets.Name = "txtnumberoftickets";
            this.txtnumberoftickets.Size = new System.Drawing.Size(453, 56);
            this.txtnumberoftickets.TabIndex = 6;
            // 
            // txtbaggageweigth
            // 
            this.txtbaggageweigth.Location = new System.Drawing.Point(535, 346);
            this.txtbaggageweigth.Multiline = true;
            this.txtbaggageweigth.Name = "txtbaggageweigth";
            this.txtbaggageweigth.Size = new System.Drawing.Size(453, 56);
            this.txtbaggageweigth.TabIndex = 7;
            // 
            // rbtnfirst
            // 
            this.rbtnfirst.AutoSize = true;
            this.rbtnfirst.Location = new System.Drawing.Point(34, 105);
            this.rbtnfirst.Name = "rbtnfirst";
            this.rbtnfirst.Size = new System.Drawing.Size(275, 56);
            this.rbtnfirst.TabIndex = 8;
            this.rbtnfirst.TabStop = true;
            this.rbtnfirst.Text = "First class";
            this.rbtnfirst.UseVisualStyleBackColor = true;
            // 
            // rbtnbusiness
            // 
            this.rbtnbusiness.AutoSize = true;
            this.rbtnbusiness.Location = new System.Drawing.Point(666, 105);
            this.rbtnbusiness.Name = "rbtnbusiness";
            this.rbtnbusiness.Size = new System.Drawing.Size(369, 56);
            this.rbtnbusiness.TabIndex = 9;
            this.rbtnbusiness.TabStop = true;
            this.rbtnbusiness.Text = "Business class";
            this.rbtnbusiness.UseVisualStyleBackColor = true;
            // 
            // rbtnnormal
            // 
            this.rbtnnormal.AutoSize = true;
            this.rbtnnormal.Location = new System.Drawing.Point(321, 105);
            this.rbtnnormal.Name = "rbtnnormal";
            this.rbtnnormal.Size = new System.Drawing.Size(332, 56);
            this.rbtnnormal.TabIndex = 10;
            this.rbtnnormal.TabStop = true;
            this.rbtnnormal.Text = "Normal class";
            this.rbtnnormal.UseVisualStyleBackColor = true;
            // 
            // checkboxinsurance
            // 
            this.checkboxinsurance.AutoSize = true;
            this.checkboxinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxinsurance.Location = new System.Drawing.Point(12, 80);
            this.checkboxinsurance.Name = "checkboxinsurance";
            this.checkboxinsurance.Size = new System.Drawing.Size(807, 56);
            this.checkboxinsurance.TabIndex = 11;
            this.checkboxinsurance.Text = "Add Travel insurance($25 per ticket)";
            this.checkboxinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(47, 216);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(241, 107);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(374, 216);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(241, 107);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(666, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 107);
            this.button3.TabIndex = 14;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtnumberoftickets);
            this.groupBox1.Controls.Add(this.txtbaggageweigth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 465);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnbusiness);
            this.groupBox2.Controls.Add(this.rbtnfirst);
            this.groupBox2.Controls.Add(this.rbtnnormal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(124, 491);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1064, 249);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel class";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.checkboxinsurance);
            this.groupBox3.Controls.Add(this.btncalculate);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(124, 769);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1039, 390);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditonal options";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(1223, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(675, 892);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2046, 1171);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtnumberoftickets;
        private System.Windows.Forms.TextBox txtbaggageweigth;
        private System.Windows.Forms.RadioButton rbtnfirst;
        private System.Windows.Forms.RadioButton rbtnbusiness;
        private System.Windows.Forms.RadioButton rbtnnormal;
        private System.Windows.Forms.CheckBox checkboxinsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

