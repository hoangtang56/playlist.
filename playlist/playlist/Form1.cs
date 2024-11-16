using AxWMPLib;

namespace playlist
{
    public partial class Form1 : Form
    {
        LinkedList<Song> playlist = new LinkedList<Song>();
        LinkedListNode<Song> currentSong = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MP3 Files|*.mp3|All Files|*.*";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        string title = Path.GetFileNameWithoutExtension(filePath);

                        Song song = new Song { Title = title, FilePath = filePath };
                        playlist.AddLast(song);
                        listBoxSongs.Items.Add(song);
                    }
                }
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem is Song selectedSong)
            {
                LinkedListNode<Song> node = playlist.Find(selectedSong);
                if (node != null)
                {
                    playlist.Remove(node);
                    listBoxSongs.Items.Remove(selectedSong);
                }
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem is Song selectedSong)
            {
                currentSong = playlist.Find(selectedSong);
                PlaySong(selectedSong);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentSong?.Next != null)
            {
                currentSong = currentSong.Next;
                PlaySong(currentSong.Value);
            }
            else
            {
                MessageBox.Show("Đây là bài hát cuối cùng trong danh sách.");
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (currentSong?.Previous != null)
            {
                currentSong = currentSong.Previous;
                PlaySong(currentSong.Value);
            }
            else
            {
                MessageBox.Show("Đây là bài hát đầu tiên trong danh sách.");
            }
        }
        private void PlaySong(Song song)
        {
            if (song != null)
            {
                axWindowsMediaPlayer.URL = song.FilePath;
                axWindowsMediaPlayer.Ctlcontrols.play();
                lblCurrentSong.Text = $"Đang chơi: {song.Title}";
            }
        }
    }
}
