﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            richTextBox2.AppendText(d1.ToString() + "\n");
            richTextBox2.AppendText(d1.ToString("N") + "\n");
            richTextBox2.AppendText(d1.ToString("N3") + "\n");
            richTextBox2.AppendText(d1.ToString("N0") + "\n");
            richTextBox2.AppendText(d1.ToString("0") + "\n");
            richTextBox2.AppendText(d1.ToString("0.0") + "\n");
            richTextBox2.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox2.AppendText(d1.ToString("0.00E00") + "\n");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
