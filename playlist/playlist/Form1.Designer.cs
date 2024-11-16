namespace playlist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxSongs = new ListBox();
            btn_play = new Button();
            btn_previous = new Button();
            btn_next = new Button();
            btn_add = new Button();
            btn_remove = new Button();
            axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            lblCurrentSong = new Label();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(560, 23);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(228, 324);
            listBoxSongs.TabIndex = 0;
            // 
            // btn_play
            // 
            btn_play.Location = new Point(151, 391);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(94, 29);
            btn_play.TabIndex = 1;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += btn_play_Click;
            // 
            // btn_previous
            // 
            btn_previous.Location = new Point(251, 391);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(94, 29);
            btn_previous.TabIndex = 1;
            btn_previous.Text = "Previous";
            btn_previous.UseVisualStyleBackColor = true;
            btn_previous.Click += btn_previous_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(351, 391);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(94, 29);
            btn_next.TabIndex = 1;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(451, 391);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(551, 391);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(94, 29);
            btn_remove.TabIndex = 1;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(12, 23);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(523, 324);
            axWindowsMediaPlayer.TabIndex = 2;
            // 
            // lblCurrentSong
            // 
            lblCurrentSong.AutoSize = true;
            lblCurrentSong.Location = new Point(28, 363);
            lblCurrentSong.Name = "lblCurrentSong";
            lblCurrentSong.Size = new Size(50, 20);
            lblCurrentSong.TabIndex = 3;
            lblCurrentSong.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrentSong);
            Controls.Add(axWindowsMediaPlayer);
            Controls.Add(btn_remove);
            Controls.Add(btn_add);
            Controls.Add(btn_next);
            Controls.Add(btn_previous);
            Controls.Add(btn_play);
            Controls.Add(listBoxSongs);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSongs;
        private Button btn_play;
        private Button btn_previous;
        private Button btn_next;
        private Button btn_add;
        private Button btn_remove;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private Label lblCurrentSong;
    }
}
