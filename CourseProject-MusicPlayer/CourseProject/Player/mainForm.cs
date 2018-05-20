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
using WMPLib;
using System.IO;

namespace Player
{
    public partial class playerForm : Form
    {
        OpenFileDialog openFileDialogAdd = new OpenFileDialog();
        OpenFileDialog openFileDialogPlayer;
        List<string> files, paths;
        int index = 0;

        public playerForm()
        {
            InitializeComponent();
            files = new List<string>();
            paths = new List<string>();

        }
        string[] file, path;
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = paths[index];
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.settings.mute = true;
        }

        private void muteOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.settings.mute = false;
        }

        private void fullScreanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer.fullScreen = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = paths[listBoxSongs.SelectedIndex];
            index = listBoxSongs.SelectedIndex;
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information childForm = new Information();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index - 1 >= 0)
            {
                index--;
                axWindowsMediaPlayer.URL = paths[index];
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }
        private void insertButton_Click(object sender, EventArgs e)
        {

            openFileDialogAdd.FileName = String.Empty;
            openFileDialogAdd.InitialDirectory = "C:\\";
            openFileDialogAdd.Filter = "MP3 files(*.mp3)|*.mp3";
            openFileDialogAdd.FilterIndex = 2;
            openFileDialogAdd.Multiselect = true;
            openFileDialogAdd.RestoreDirectory = true;
            if (openFileDialogAdd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!paths.Contains(openFileDialogAdd.FileName) && !listBoxSongs.Items.Contains(openFileDialogAdd.SafeFileName))
                    {
                        files.Add(openFileDialogAdd.SafeFileName + "--" + openFileDialogAdd.FileName);
                        paths.Add(openFileDialogAdd.FileName);
                        listBoxSongs.Items.Add(openFileDialogAdd.SafeFileName);
                        axWindowsMediaPlayer.Ctlcontrols.play();
                    }
                    else
                    {
                        MessageBox.Show("Error!", "The song is already added.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("Error!", " The file cannot be played.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }

        }

        private void searchPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogSelect = new OpenFileDialog();
            openFileDialogSelect.FileName = String.Empty;
            openFileDialogSelect.InitialDirectory = @"C:\\";
            openFileDialogSelect.Title = "Select playlist";
            if (openFileDialogSelect.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openFileDialogSelect.FileName))
            {
                string searchedFile = openFileDialogSelect.FileName;
                axWindowsMediaPlayer.Ctlcontrols.stop();
                files.Clear();
                paths.Clear();
                listBoxSongs.Items.Clear();
                files = File.ReadAllLines(searchedFile).ToList();
                for (int len = 0; len < files.Count; len++)
                {
                    string[] temp = files[len].Split(new string[] { "--" }, StringSplitOptions.RemoveEmptyEntries);
                    listBoxSongs.Items.Add(temp[0]);
                    paths.Add(temp[1]);
                }
                index = 0;
            }

        }

        private void nextSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (index + 1 <= paths.Count - 1)
            {
                index++;
                axWindowsMediaPlayer.URL = paths[index];
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {           
            listBoxSongs.Items.Clear();
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogList = new SaveFileDialog();
            string filename = "";
            saveFileDialogList.InitialDirectory = @"C:\\";
            saveFileDialogList.FileName = "";
            saveFileDialogList.Title = "Save playlist";
            saveFileDialogList.ShowDialog();
            if (!string.IsNullOrEmpty(saveFileDialogList.FileName))
            {
                filename = saveFileDialogList.FileName;
                File.WriteAllLines(Path.GetFullPath(filename + ".txt"), files);

            }
        }

        private void playerForm_Load(object sender, EventArgs e)
        {
            // creating links between main and sub form
            openFileDialogPlayer = new OpenFileDialog();
            this.Text = "Media Player, version = " + axWindowsMediaPlayer.versionInfo;
        }
    }
}

