namespace WindowsFormsApp1
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
            this.dayoftheweek = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputlabel = new System.Windows.Forms.Label();
            this.dayofweekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayofmonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayoftheweek
            // 
            this.dayoftheweek.AutoSize = true;
            this.dayoftheweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayoftheweek.Location = new System.Drawing.Point(443, 188);
            this.dayoftheweek.Name = "dayoftheweek";
            this.dayoftheweek.Size = new System.Drawing.Size(376, 55);
            this.dayoftheweek.TabIndex = 0;
            this.dayoftheweek.Text = "day of the week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the numeric of the mont";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter mont name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter of the year";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // outputlabel
            // 
            this.outputlabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputlabel.Location = new System.Drawing.Point(438, 592);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(1186, 128);
            this.outputlabel.TabIndex = 4;
            this.outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputlabel.Click += new System.EventHandler(this.outputlabel_Click);
            // 
            // dayofweekTextBox
            // 
            this.dayofweekTextBox.Location = new System.Drawing.Point(1166, 161);
            this.dayofweekTextBox.Multiline = true;
            this.dayofweekTextBox.Name = "dayofweekTextBox";
            this.dayofweekTextBox.Size = new System.Drawing.Size(458, 66);
            this.dayofweekTextBox.TabIndex = 5;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(1155, 356);
            this.monthTextBox.Multiline = true;
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(458, 73);
            this.monthTextBox.TabIndex = 6;
            // 
            // dayofmonthTextBox
            // 
            this.dayofmonthTextBox.Location = new System.Drawing.Point(1166, 264);
            this.dayofmonthTextBox.Multiline = true;
            this.dayofmonthTextBox.Name = "dayofmonthTextBox";
            this.dayofmonthTextBox.Size = new System.Drawing.Size(458, 66);
            this.dayofmonthTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(1145, 445);
            this.yearTextBox.Multiline = true;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(458, 66);
            this.yearTextBox.TabIndex = 8;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(414, 776);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(232, 112);
            this.btnshow.TabIndex = 9;
            this.btnshow.Text = "Show data";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(790, 776);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(317, 112);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnend
            // 
            this.btnend.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnend.Location = new System.Drawing.Point(1275, 776);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(232, 122);
            this.btnend.TabIndex = 11;
            this.btnend.Text = "END";
            this.btnend.UseVisualStyleBackColor = false;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(2127, 910);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayofmonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayofweekTextBox);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayoftheweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayoftheweek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.TextBox dayofweekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayofmonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnend;
    }
}

