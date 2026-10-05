namespace practice
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
            this.textHourworked = new System.Windows.Forms.TextBox();
            this.textPeyrate = new System.Windows.Forms.TextBox();
            this.lblcalculate = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hour worked: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly pey rate: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 64);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gross pey: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textHourworked
            // 
            this.textHourworked.Location = new System.Drawing.Point(577, 81);
            this.textHourworked.Multiline = true;
            this.textHourworked.Name = "textHourworked";
            this.textHourworked.Size = new System.Drawing.Size(603, 112);
            this.textHourworked.TabIndex = 4;
            // 
            // textPeyrate
            // 
            this.textPeyrate.Location = new System.Drawing.Point(577, 229);
            this.textPeyrate.Multiline = true;
            this.textPeyrate.Name = "textPeyrate";
            this.textPeyrate.Size = new System.Drawing.Size(603, 100);
            this.textPeyrate.TabIndex = 5;
            // 
            // lblcalculate
            // 
            this.lblcalculate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculate.Location = new System.Drawing.Point(577, 404);
            this.lblcalculate.Name = "lblcalculate";
            this.lblcalculate.Size = new System.Drawing.Size(603, 105);
            this.lblcalculate.TabIndex = 6;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(152, 808);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(427, 215);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "Calculate gross pey";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(627, 808);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(417, 215);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(1088, 808);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(417, 215);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2011, 1101);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblcalculate);
            this.Controls.Add(this.textPeyrate);
            this.Controls.Add(this.textHourworked);
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
        private System.Windows.Forms.TextBox textHourworked;
        private System.Windows.Forms.TextBox textPeyrate;
        private System.Windows.Forms.Label lblcalculate;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

