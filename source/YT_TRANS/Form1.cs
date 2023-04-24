using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using YoutubeExtractor;
using static System.Windows.Forms.LinkLabel;


namespace YT_TRANS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void URL_TextChanged(object sender, EventArgs e)
        {

        }

        private void Install_Click(object sender, EventArgs e)
        {
            InstallVoid();
        }

        public void InstallVoid()
        {

            WebClient client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            client.DownloadFileAsync(new Uri(text_url.Text), path_text.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File Download Complete!");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Find_Path_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.* |Png (*.png)|*.png|jpg (*.jpg)|*.jpg|mp4 (*.mp4)|*.mp4";
            sfd.ShowDialog();
            path_text.Text = sfd.FileName;
        }
    }
}