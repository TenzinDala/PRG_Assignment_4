﻿using Seneca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Assignment_4.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" |  textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "")
            {
                MessageBox.Show("Empty Inputs Detected!");
            }
            else
            {
                User user = new User();
                bool status = user.CreateUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

                if(status)
                {
                    MessageBox.Show("User has been Successfully created!!!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("Validation Error! Please Input again!!!");
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
