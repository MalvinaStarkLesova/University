﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            MessageBox.Show("The author is Malvina Lesova - Bachelor of Science, Software Technologies and Design at Plovdiv University. " +
                "Faculty № 1701681002.", 
                "Information.",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}