namespace assigment3
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
            this.textCustomer = new System.Windows.Forms.TextBox();
            this.textPrevious = new System.Windows.Forms.TextBox();
            this.textCurrent = new System.Windows.Forms.TextBox();
            this.textUnitPrice = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textElectricity = new System.Windows.Forms.TextBox();
            this.Taxamount = new System.Windows.Forms.TextBox();
            this.Totalbill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter customer name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter previous reading :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter current reading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter price per unit($):";
            // 
            // textCustomer
            // 
            this.textCustomer.Location = new System.Drawing.Point(609, 130);
            this.textCustomer.Multiline = true;
            this.textCustomer.Name = "textCustomer";
            this.textCustomer.Size = new System.Drawing.Size(341, 64);
            this.textCustomer.TabIndex = 4;
            // 
            // textPrevious
            // 
            this.textPrevious.Location = new System.Drawing.Point(609, 261);
            this.textPrevious.Multiline = true;
            this.textPrevious.Name = "textPrevious";
            this.textPrevious.Size = new System.Drawing.Size(341, 64);
            this.textPrevious.TabIndex = 5;
            // 
            // textCurrent
            // 
            this.textCurrent.Location = new System.Drawing.Point(609, 380);
            this.textCurrent.Multiline = true;
            this.textCurrent.Name = "textCurrent";
            this.textCurrent.Size = new System.Drawing.Size(341, 64);
            this.textCurrent.TabIndex = 6;
            // 
            // textUnitPrice
            // 
            this.textUnitPrice.Location = new System.Drawing.Point(609, 496);
            this.textUnitPrice.Multiline = true;
            this.textUnitPrice.Name = "textUnitPrice";
            this.textUnitPrice.Size = new System.Drawing.Size(341, 64);
            this.textUnitPrice.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(467, 630);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(347, 209);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate Bill";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 910);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Electricity usage (unit) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 994);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tax amount:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 1083);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Bill ";
            // 
            // textElectricity
            // 
            this.textElectricity.Location = new System.Drawing.Point(586, 907);
            this.textElectricity.Multiline = true;
            this.textElectricity.Name = "textElectricity";
            this.textElectricity.Size = new System.Drawing.Size(422, 71);
            this.textElectricity.TabIndex = 12;
            // 
            // Taxamount
            // 
            this.Taxamount.Location = new System.Drawing.Point(586, 994);
            this.Taxamount.Multiline = true;
            this.Taxamount.Name = "Taxamount";
            this.Taxamount.Size = new System.Drawing.Size(431, 71);
            this.Taxamount.TabIndex = 13;
            // 
            // Totalbill
            // 
            this.Totalbill.Location = new System.Drawing.Point(586, 1080);
            this.Totalbill.Multiline = true;
            this.Totalbill.Name = "Totalbill";
            this.Totalbill.Size = new System.Drawing.Size(431, 79);
            this.Totalbill.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(2051, 1206);
            this.Controls.Add(this.Totalbill);
            this.Controls.Add(this.Taxamount);
            this.Controls.Add(this.textElectricity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.textUnitPrice);
            this.Controls.Add(this.textCurrent);
            this.Controls.Add(this.textPrevious);
            this.Controls.Add(this.textCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCustomer;
        private System.Windows.Forms.TextBox textPrevious;
        private System.Windows.Forms.TextBox textCurrent;
        private System.Windows.Forms.TextBox textUnitPrice;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textElectricity;
        private System.Windows.Forms.TextBox Taxamount;
        private System.Windows.Forms.TextBox Totalbill;
    }
}

