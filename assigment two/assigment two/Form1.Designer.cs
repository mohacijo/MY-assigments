namespace assigment_two
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textsid = new System.Windows.Forms.TextBox();
            this.textdepartment = new System.Windows.Forms.TextBox();
            this.textsemester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(304, 397);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(349, 37);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the student name";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Location = new System.Drawing.Point(304, 477);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(300, 37);
            this.lblsid.TabIndex = 1;
            this.lblsid.Text = "Enter the student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(304, 567);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(317, 37);
            this.lbldepartment.TabIndex = 2;
            this.lbldepartment.Text = "Enter the department";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(304, 661);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(285, 37);
            this.lblsemester.TabIndex = 3;
            this.lblsemester.Text = "Enter the semester";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(402, 843);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(793, 169);
            this.lbloutput.TabIndex = 4;
            this.lbloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(722, 394);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(603, 62);
            this.textname.TabIndex = 5;
            // 
            // textsid
            // 
            this.textsid.Location = new System.Drawing.Point(713, 474);
            this.textsid.Multiline = true;
            this.textsid.Name = "textsid";
            this.textsid.Size = new System.Drawing.Size(603, 62);
            this.textsid.TabIndex = 6;
            // 
            // textdepartment
            // 
            this.textdepartment.Location = new System.Drawing.Point(713, 564);
            this.textdepartment.Multiline = true;
            this.textdepartment.Name = "textdepartment";
            this.textdepartment.Size = new System.Drawing.Size(603, 62);
            this.textdepartment.TabIndex = 7;
            // 
            // textsemester
            // 
            this.textsemester.Location = new System.Drawing.Point(713, 661);
            this.textsemester.Multiline = true;
            this.textsemester.Name = "textsemester";
            this.textsemester.Size = new System.Drawing.Size(603, 62);
            this.textsemester.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 169);
            this.label1.TabIndex = 9;
            this.label1.Text = "STUDENT INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(337, 1125);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(362, 133);
            this.btnshow.TabIndex = 10;
            this.btnshow.Text = "SHOW INFORMATION";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(987, 1125);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(362, 133);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1612, 1148);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(362, 133);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2353, 1387);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textsemester);
            this.Controls.Add(this.textdepartment);
            this.Controls.Add(this.textsid);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblsid);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textsid;
        private System.Windows.Forms.TextBox textdepartment;
        private System.Windows.Forms.TextBox textsemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

