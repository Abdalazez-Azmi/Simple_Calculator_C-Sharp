using System.Diagnostics;
using System.Security;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        double first_number;
        double second_number;
        double result;

        public Form1()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num_f.Text.Length == 0 || num_s.Text.Length == 0)
            {
                label1.Text = Convert.ToString("Please Enter a Number");
                label1.Font = new Font("Segoe UI", 15);

            }
            else
            {
                label1.Font = new Font("Segoe UI", 25);

                first_number = Convert.ToDouble(num_f.Text);
                second_number = Convert.ToDouble(num_s.Text);
                // if the type of inout not a Number
                /*   if (typeof() != "double")
                   {

                  } /*/

                result = first_number + second_number;
                label1.Text = Convert.ToString(result);


            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num_f.Text.Length == 0 || num_s.Text.Length == 0)
            {
                label1.Text = Convert.ToString("Please Enter a Number");
                label1.Font = new Font("Segoe UI", 15);

            }
            else
            {
                label1.Font = new Font("Segoe UI", 25);

                first_number = Convert.ToDouble(num_f.Text);
                second_number = Convert.ToDouble(num_s.Text);
                result = first_number - second_number;
                label1.Text = Convert.ToString(result);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num_f.Text.Length == 0 || num_s.Text.Length == 0)
            {
                label1.Text = Convert.ToString("Please Enter a Number");
                label1.Font = new Font("Segoe UI", 15);

            }
            else
            {
                label1.Font = new Font("Segoe UI", 25);

                first_number = Convert.ToDouble(num_f.Text);
                second_number = Convert.ToDouble(num_s.Text);
                result = first_number * second_number;
                label1.Text = Convert.ToString(result);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num_f.Text.Length == 0 || num_s.Text.Length == 0)
            {
                label1.Text = Convert.ToString("Please Enter a Number");
                label1.Font = new Font("Segoe UI", 15);

            }
            else {
                label1.Font = new Font("Segoe UI", 25);

                first_number = Convert.ToDouble(num_f.Text);
                second_number = Convert.ToDouble(num_s.Text);
                result = first_number / second_number;
                label1.Text = Convert.ToString(result);

            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Git(object sender, EventArgs e)
        {
            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, "https://github.com/Abdalazez-Azmi");
        }
    }
}