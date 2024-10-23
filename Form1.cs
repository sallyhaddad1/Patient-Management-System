using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gender;
        string degree;
        string medical;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = "Patient Name:\r\nPatient Id:\r\nGender:\r\nDegree of Insurance:\r\nMedical Procedure:\r\nMedical Procedure Date:";
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NametextBox1.Clear();
            IDtextBox2.Clear();

            MradioButton1.Checked = false;
            FradioButton2.Checked = false;

            FIRSTradioButton3.Checked = false;
            SECradioButton4.Checked = false;
            thirdradioButton5.Checked = false;

            CPRradioButton6.Checked = false;
            ECGradioButton7.Checked = false;
            ULTradioButton8.Checked = false;

            label8.Visible = false;

            dateTimePicker1.Value = DateTime.Now;
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
           textBox3.Text= "Patient Name : " + NametextBox1.Text + "\r\nPatient Id : " + IDtextBox2.Text + "\r\nGender : "
                          + gender + "\r\nDegree of Insurance : " + degree + "\r\nMedical Procedure "
                          + medical +"( "+ CalculateInsuranceCost(degree) + "% of the cost )"+ "\r\nMedical Procedure Date : " + dateTimePicker1.Value.ToShortDateString() +
                          "\r\n"+  label8.Text;
        }

        private void Exitbutton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Gobutton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (CPRradioButton6.Checked)
            {

                label8.Visible = true; 
            }
            else  if (ECGradioButton7.Checked)
                {
                    DateTime resultDate = dateTimePicker1.Value.AddDays(2);

                    label8.Text = $"ECG Result Date: {resultDate.ToShortDateString()}";
                }
            else if (ULTradioButton8.Checked)
            {
                DateTime resultDate = dateTimePicker1.Value.AddDays(3);

                label8.Text = $"Ultrasound Result Date: {resultDate.ToShortDateString()}";
            }
        }
        private void MradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void FradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void FIRSTradioButton3_CheckedChanged(object sender, EventArgs e)
        {
            degree = "First";
        }

        private void SECradioButton4_CheckedChanged(object sender, EventArgs e)
        {
            degree = "Second";

        }

        private void thirdradioButton5_CheckedChanged(object sender, EventArgs e)
        {
            degree = "Third";

        }
        private double CalculateInsuranceCost(string degree)
        {
            switch (degree)
            {
                case "First": return 15;
                case "Second": return 10;
                case "Third": return 5;
                default: return 0;
            }
        }

        private void CPRradioButton6_CheckedChanged(object sender, EventArgs e)
        {
            medical = "CPR";

        }

        private void ECGradioButton7_CheckedChanged(object sender, EventArgs e)
        {
            medical = "ECG";
        }

        private void ULTradioButton8_CheckedChanged(object sender, EventArgs e)
        {
            medical = "Ultrasound";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Multiline = false;

            }
            else
            {
                textBox3.Multiline = true;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox3.ReadOnly = true;

            }
            else
            {
                textBox3.ReadOnly = false;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
