using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            String StudentName = nameBox.Text.Trim();

            if (!double.TryParse(englishBox.Text, out double englishtext) ||
                !double.TryParse(mathBox.Text, out double mathtext) ||
                !double.TryParse(scienceBox.Text, out double sciencetext) ||
                !double.TryParse(filipinoBox.Text, out double filipinotext) ||
                !double.TryParse(historyBox.Text, out double historytext))
            {
                MessageBox.Show($"Parsed value: ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            double average = (englishtext + mathtext + sciencetext + filipinotext + historytext) / 5;

            String result = average >= 75 ? "The student passed The general average of " + StudentName + " is " + average :
                "The student failed The general average of " + StudentName + " is " + average;

            output.Text = result;

            output.Visible = true;
        }
    }
}
