﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Left += 50;
            this.Top += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Left -= 50;
            this.Top -= 10;
        }
    }
}
