﻿using RIGProjeck.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Register : Form
    {
        
        User user = new User();
        public Register()
        {
            InitializeComponent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            user.Register(textBox2.Text, textBox3.Text, textBox1.Text);
            this.Hide();

        }
    }
}
