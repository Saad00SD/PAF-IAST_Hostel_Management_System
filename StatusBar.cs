﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databaseproject
{
    public partial class StatusBar : Form
    {
        public StatusBar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value += 1;
                label2.Text = guna2ProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
               // MessageBox.Show("Your Login Loaded..");
            }
        }

        private void StatusBar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
