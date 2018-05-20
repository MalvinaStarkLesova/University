using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using WMPLib;

namespace Player
{
    public partial class browseForm : Form
    {
        public browseForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            string song = playerForm.listB.Text;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string fileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "All Files(*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                fileName = openFileDialog1.FileName;    
            }
            StreamReader insert = new StreamReader(fileName);
            try
            {
                playerForm.listB.Text = insert.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no chosen song!", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            playerForm.listB.Text = song;
            this.DialogResult = DialogResult.OK;
        }
    }
}
