namespace Ass1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Exitbutton4 = new System.Windows.Forms.Button();
            this.Clearbutton3 = new System.Windows.Forms.Button();
            this.Gobutton2 = new System.Windows.Forms.Button();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ULTradioButton8 = new System.Windows.Forms.RadioButton();
            this.ECGradioButton7 = new System.Windows.Forms.RadioButton();
            this.CPRradioButton6 = new System.Windows.Forms.RadioButton();
            this.thirdradioButton5 = new System.Windows.Forms.RadioButton();
            this.SECradioButton4 = new System.Windows.Forms.RadioButton();
            this.FIRSTradioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FradioButton2 = new System.Windows.Forms.RadioButton();
            this.MradioButton1 = new System.Windows.Forms.RadioButton();
            this.IDtextBox2 = new System.Windows.Forms.TextBox();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Ass1.Properties.Resources.images;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = " Name: Samer Haddad\r\n Id: 152564\r\n";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.thirdradioButton5);
            this.groupBox1.Controls.Add(this.SECradioButton4);
            this.groupBox1.Controls.Add(this.FIRSTradioButton3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.IDtextBox2);
            this.groupBox1.Controls.Add(this.NametextBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Exitbutton4);
            this.panel3.Controls.Add(this.Clearbutton3);
            this.panel3.Controls.Add(this.Gobutton2);
            this.panel3.Controls.Add(this.Addbutton1);
            this.panel3.Location = new System.Drawing.Point(16, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 86);
            this.panel3.TabIndex = 14;
            // 
            // Exitbutton4
            // 
            this.Exitbutton4.BackgroundImage = global::Ass1.Properties.Resources.exit;
            this.Exitbutton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exitbutton4.Location = new System.Drawing.Point(367, 16);
            this.Exitbutton4.Name = "Exitbutton4";
            this.Exitbutton4.Size = new System.Drawing.Size(92, 55);
            this.Exitbutton4.TabIndex = 3;
            this.Exitbutton4.UseVisualStyleBackColor = true;
            this.Exitbutton4.Click += new System.EventHandler(this.Exitbutton4_Click);
            // 
            // Clearbutton3
            // 
            this.Clearbutton3.BackgroundImage = global::Ass1.Properties.Resources.clear;
            this.Clearbutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clearbutton3.Location = new System.Drawing.Point(256, 13);
            this.Clearbutton3.Name = "Clearbutton3";
            this.Clearbutton3.Size = new System.Drawing.Size(82, 57);
            this.Clearbutton3.TabIndex = 2;
            this.Clearbutton3.UseVisualStyleBackColor = true;
            this.Clearbutton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Gobutton2
            // 
            this.Gobutton2.BackgroundImage = global::Ass1.Properties.Resources.go;
            this.Gobutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gobutton2.Location = new System.Drawing.Point(138, 13);
            this.Gobutton2.Name = "Gobutton2";
            this.Gobutton2.Size = new System.Drawing.Size(87, 58);
            this.Gobutton2.TabIndex = 1;
            this.Gobutton2.UseVisualStyleBackColor = true;
            this.Gobutton2.Click += new System.EventHandler(this.Gobutton2_Click);
            // 
            // Addbutton1
            // 
            this.Addbutton1.BackgroundImage = global::Ass1.Properties.Resources.add;
            this.Addbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addbutton1.Location = new System.Drawing.Point(31, 14);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(85, 58);
            this.Addbutton1.TabIndex = 0;
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ULTradioButton8);
            this.panel2.Controls.Add(this.ECGradioButton7);
            this.panel2.Controls.Add(this.CPRradioButton6);
            this.panel2.Location = new System.Drawing.Point(169, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 36);
            this.panel2.TabIndex = 12;
            // 
            // ULTradioButton8
            // 
            this.ULTradioButton8.AutoSize = true;
            this.ULTradioButton8.Location = new System.Drawing.Point(169, 11);
            this.ULTradioButton8.Name = "ULTradioButton8";
            this.ULTradioButton8.Size = new System.Drawing.Size(100, 20);
            this.ULTradioButton8.TabIndex = 2;
            this.ULTradioButton8.TabStop = true;
            this.ULTradioButton8.Text = "Ultrasound";
            this.ULTradioButton8.UseVisualStyleBackColor = true;
            this.ULTradioButton8.CheckedChanged += new System.EventHandler(this.ULTradioButton8_CheckedChanged);
            // 
            // ECGradioButton7
            // 
            this.ECGradioButton7.AutoSize = true;
            this.ECGradioButton7.Location = new System.Drawing.Point(90, 11);
            this.ECGradioButton7.Name = "ECGradioButton7";
            this.ECGradioButton7.Size = new System.Drawing.Size(56, 20);
            this.ECGradioButton7.TabIndex = 1;
            this.ECGradioButton7.TabStop = true;
            this.ECGradioButton7.Text = "ECG";
            this.ECGradioButton7.UseVisualStyleBackColor = true;
            this.ECGradioButton7.CheckedChanged += new System.EventHandler(this.ECGradioButton7_CheckedChanged);
            // 
            // CPRradioButton6
            // 
            this.CPRradioButton6.AutoSize = true;
            this.CPRradioButton6.Location = new System.Drawing.Point(16, 11);
            this.CPRradioButton6.Name = "CPRradioButton6";
            this.CPRradioButton6.Size = new System.Drawing.Size(56, 20);
            this.CPRradioButton6.TabIndex = 0;
            this.CPRradioButton6.TabStop = true;
            this.CPRradioButton6.Text = "CPR";
            this.CPRradioButton6.UseVisualStyleBackColor = true;
            this.CPRradioButton6.CheckedChanged += new System.EventHandler(this.CPRradioButton6_CheckedChanged);
            // 
            // thirdradioButton5
            // 
            this.thirdradioButton5.AutoSize = true;
            this.thirdradioButton5.Location = new System.Drawing.Point(354, 161);
            this.thirdradioButton5.Name = "thirdradioButton5";
            this.thirdradioButton5.Size = new System.Drawing.Size(61, 20);
            this.thirdradioButton5.TabIndex = 11;
            this.thirdradioButton5.TabStop = true;
            this.thirdradioButton5.Text = "Third";
            this.thirdradioButton5.UseVisualStyleBackColor = true;
            this.thirdradioButton5.CheckedChanged += new System.EventHandler(this.thirdradioButton5_CheckedChanged);
            // 
            // SECradioButton4
            // 
            this.SECradioButton4.AutoSize = true;
            this.SECradioButton4.Location = new System.Drawing.Point(260, 161);
            this.SECradioButton4.Name = "SECradioButton4";
            this.SECradioButton4.Size = new System.Drawing.Size(78, 20);
            this.SECradioButton4.TabIndex = 10;
            this.SECradioButton4.TabStop = true;
            this.SECradioButton4.Text = "Second";
            this.SECradioButton4.UseVisualStyleBackColor = true;
            this.SECradioButton4.CheckedChanged += new System.EventHandler(this.SECradioButton4_CheckedChanged);
            // 
            // FIRSTradioButton3
            // 
            this.FIRSTradioButton3.AutoSize = true;
            this.FIRSTradioButton3.Location = new System.Drawing.Point(187, 161);
            this.FIRSTradioButton3.Name = "FIRSTradioButton3";
            this.FIRSTradioButton3.Size = new System.Drawing.Size(55, 20);
            this.FIRSTradioButton3.TabIndex = 9;
            this.FIRSTradioButton3.TabStop = true;
            this.FIRSTradioButton3.Text = "First";
            this.FIRSTradioButton3.UseVisualStyleBackColor = true;
            this.FIRSTradioButton3.CheckedChanged += new System.EventHandler(this.FIRSTradioButton3_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FradioButton2);
            this.panel1.Controls.Add(this.MradioButton1);
            this.panel1.Location = new System.Drawing.Point(106, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 54);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FradioButton2
            // 
            this.FradioButton2.AutoSize = true;
            this.FradioButton2.Location = new System.Drawing.Point(96, 19);
            this.FradioButton2.Name = "FradioButton2";
            this.FradioButton2.Size = new System.Drawing.Size(77, 20);
            this.FradioButton2.TabIndex = 1;
            this.FradioButton2.TabStop = true;
            this.FradioButton2.Text = "Female";
            this.FradioButton2.UseVisualStyleBackColor = true;
            this.FradioButton2.CheckedChanged += new System.EventHandler(this.FradioButton2_CheckedChanged);
            // 
            // MradioButton1
            // 
            this.MradioButton1.AutoSize = true;
            this.MradioButton1.Location = new System.Drawing.Point(16, 18);
            this.MradioButton1.Name = "MradioButton1";
            this.MradioButton1.Size = new System.Drawing.Size(59, 20);
            this.MradioButton1.TabIndex = 0;
            this.MradioButton1.TabStop = true;
            this.MradioButton1.Text = "Male";
            this.MradioButton1.UseVisualStyleBackColor = true;
            this.MradioButton1.CheckedChanged += new System.EventHandler(this.MradioButton1_CheckedChanged);
            // 
            // IDtextBox2
            // 
            this.IDtextBox2.Location = new System.Drawing.Point(132, 64);
            this.IDtextBox2.Name = "IDtextBox2";
            this.IDtextBox2.Size = new System.Drawing.Size(121, 22);
            this.IDtextBox2.TabIndex = 7;
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(132, 31);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(120, 22);
            this.NametextBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Medical Procedure Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Medical Procedure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Degree of Insurance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Patient Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(526, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Patient Report";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Properties";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Ass1.Properties.Resources.back;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(350, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 59);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(137, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "ReadOnly";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "MultiLine";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(21, 15);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(485, 240);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(562, 430);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IDtextBox2;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.RadioButton FIRSTradioButton3;
        private System.Windows.Forms.RadioButton FradioButton2;
        private System.Windows.Forms.RadioButton MradioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton ULTradioButton8;
        private System.Windows.Forms.RadioButton ECGradioButton7;
        private System.Windows.Forms.RadioButton CPRradioButton6;
        private System.Windows.Forms.RadioButton thirdradioButton5;
        private System.Windows.Forms.RadioButton SECradioButton4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Gobutton2;
        private System.Windows.Forms.Button Exitbutton4;
        private System.Windows.Forms.Button Clearbutton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label8;
    }
}

