namespace Player
{
    partial class playerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerForm));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.textBoxSongs = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(1, 26);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(475, 352);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.maToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mediaToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maToolStripMenuItem
            // 
            this.maToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreanToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.playToolStripMenuItem,
            this.muteToolStripMenuItem,
            this.muteOffToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.nextSongToolStripMenuItem});
            this.maToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maToolStripMenuItem.Name = "maToolStripMenuItem";
            this.maToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.maToolStripMenuItem.Text = "Options";
            // 
            // fullScreanToolStripMenuItem
            // 
            this.fullScreanToolStripMenuItem.Name = "fullScreanToolStripMenuItem";
            this.fullScreanToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.fullScreanToolStripMenuItem.Text = "Full screen";
            this.fullScreanToolStripMenuItem.Click += new System.EventHandler(this.fullScreanToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.muteToolStripMenuItem.Text = "Mute on";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
            // 
            // muteOffToolStripMenuItem
            // 
            this.muteOffToolStripMenuItem.Name = "muteOffToolStripMenuItem";
            this.muteOffToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.muteOffToolStripMenuItem.Text = "Mute off";
            this.muteOffToolStripMenuItem.Click += new System.EventHandler(this.muteOffToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.previousToolStripMenuItem.Text = "Previous Song";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // nextSongToolStripMenuItem
            // 
            this.nextSongToolStripMenuItem.Name = "nextSongToolStripMenuItem";
            this.nextSongToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.nextSongToolStripMenuItem.Text = "Next Song";
            this.nextSongToolStripMenuItem.Click += new System.EventHandler(this.nextSongToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPlaylistToolStripMenuItem});
            this.playlistToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // playPlaylistToolStripMenuItem
            // 
            this.playPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchPlaylistToolStripMenuItem,
            this.newPlaylistToolStripMenuItem});
            this.playPlaylistToolStripMenuItem.Name = "playPlaylistToolStripMenuItem";
            this.playPlaylistToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.playPlaylistToolStripMenuItem.Text = "Play playlist";
            // 
            // searchPlaylistToolStripMenuItem
            // 
            this.searchPlaylistToolStripMenuItem.Name = "searchPlaylistToolStripMenuItem";
            this.searchPlaylistToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.searchPlaylistToolStripMenuItem.Text = "Search playlist";
            this.searchPlaylistToolStripMenuItem.Click += new System.EventHandler(this.searchPlaylistToolStripMenuItem_Click);
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(482, 90);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(247, 238);
            this.listBoxSongs.TabIndex = 2;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // textBoxSongs
            // 
            this.textBoxSongs.Location = new System.Drawing.Point(482, 27);
            this.textBoxSongs.Multiline = true;
            this.textBoxSongs.Name = "textBoxSongs";
            this.textBoxSongs.Size = new System.Drawing.Size(247, 20);
            this.textBoxSongs.TabIndex = 4;
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.insertButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertButton.Location = new System.Drawing.Point(482, 54);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(74, 30);
            this.insertButton.TabIndex = 5;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSave.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(629, 53);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 31);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save PlayList";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(645, 336);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // playerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 379);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.textBoxSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "playerForm";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.playerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPlaylistToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSongs;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextSongToolStripMenuItem;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}

