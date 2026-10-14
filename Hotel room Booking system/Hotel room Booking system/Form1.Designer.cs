namespace Hotel_room_Booking_system
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
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.txtguestage = new System.Windows.Forms.TextBox();
            this.txtnight = new System.Windows.Forms.TextBox();
            this.txtguestnumber = new System.Windows.Forms.TextBox();
            this.rstandard = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rhight = new System.Windows.Forms.RadioButton();
            this.btncheckbox = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest Age: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Nights:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Guest:";
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(638, 93);
            this.txtguestname.Multiline = true;
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(541, 75);
            this.txtguestname.TabIndex = 4;
            this.txtguestname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtguestage
            // 
            this.txtguestage.Location = new System.Drawing.Point(638, 188);
            this.txtguestage.Multiline = true;
            this.txtguestage.Name = "txtguestage";
            this.txtguestage.Size = new System.Drawing.Size(541, 75);
            this.txtguestage.TabIndex = 5;
            // 
            // txtnight
            // 
            this.txtnight.Location = new System.Drawing.Point(638, 289);
            this.txtnight.Multiline = true;
            this.txtnight.Name = "txtnight";
            this.txtnight.Size = new System.Drawing.Size(541, 75);
            this.txtnight.TabIndex = 6;
            // 
            // txtguestnumber
            // 
            this.txtguestnumber.Location = new System.Drawing.Point(638, 396);
            this.txtguestnumber.Multiline = true;
            this.txtguestnumber.Name = "txtguestnumber";
            this.txtguestnumber.Size = new System.Drawing.Size(541, 75);
            this.txtguestnumber.TabIndex = 7;
            // 
            // rstandard
            // 
            this.rstandard.AutoSize = true;
            this.rstandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstandard.Location = new System.Drawing.Point(57, 103);
            this.rstandard.Name = "rstandard";
            this.rstandard.Size = new System.Drawing.Size(272, 59);
            this.rstandard.TabIndex = 8;
            this.rstandard.TabStop = true;
            this.rstandard.Text = "Standard";
            this.rstandard.UseVisualStyleBackColor = true;
            this.rstandard.CheckedChanged += new System.EventHandler(this.rbtnstandard_CheckedChanged);
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNormal.Location = new System.Drawing.Point(379, 103);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(229, 59);
            this.rbtnNormal.TabIndex = 9;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Normal";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // rhight
            // 
            this.rhight.AutoSize = true;
            this.rhight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhight.Location = new System.Drawing.Point(673, 103);
            this.rhight.Name = "rhight";
            this.rhight.Size = new System.Drawing.Size(185, 59);
            this.rhight.TabIndex = 10;
            this.rhight.TabStop = true;
            this.rhight.Text = "Hight";
            this.rhight.UseVisualStyleBackColor = true;
            // 
            // btncheckbox
            // 
            this.btncheckbox.AutoSize = true;
            this.btncheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckbox.Location = new System.Drawing.Point(25, 91);
            this.btncheckbox.Name = "btncheckbox";
            this.btncheckbox.Size = new System.Drawing.Size(984, 68);
            this.btncheckbox.TabIndex = 11;
            this.btncheckbox.Text = "BreakFast(10 per Guest per nights)";
            this.btncheckbox.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(45, 238);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(209, 106);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(677, 238);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(209, 106);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(365, 238);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(209, 106);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtguestname);
            this.groupBox1.Controls.Add(this.txtguestage);
            this.groupBox1.Controls.Add(this.txtnight);
            this.groupBox1.Controls.Add(this.txtguestnumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1307, 500);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Room Booking System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnNormal);
            this.groupBox2.Controls.Add(this.rstandard);
            this.groupBox2.Controls.Add(this.rhight);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 623);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 230);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncheckbox);
            this.groupBox3.Controls.Add(this.btncalculate);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 891);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1026, 406);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional Options";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(1360, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(786, 892);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(3026, 1309);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.TextBox txtguestage;
        private System.Windows.Forms.TextBox txtnight;
        private System.Windows.Forms.TextBox txtguestnumber;
        private System.Windows.Forms.RadioButton rstandard;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.RadioButton rhight;
        private System.Windows.Forms.CheckBox btncheckbox;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

