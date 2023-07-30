using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using YoutubeExplode;
using YoutubeExplode.Videos;
using System.IO;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Exceptions;


namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        bool cancelIsRequired;
        public Form1()
        {
            InitializeComponent();
        }

        public async void Download()
        {
            if (
                String.IsNullOrEmpty(txUrl.Text) ||
                String.IsNullOrEmpty(txTitle.Text) ||
                String.IsNullOrEmpty(txSaveTo.Text))
            {
                MessageBox.Show("Please fill all the lines");
                return;
            }

            string url = txUrl.Text.Substring(0, 43);

            YoutubeClient client = new();

            try
            {

                var streamManifest = await client.Videos.Streams.GetManifestAsync(url);

                // Handle Video and Audio both..
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                /// ProgressBar Value will change..
                var progress = new Progress<double>();
                progress.ProgressChanged += (p, report) =>
                {
                    var percent = (report * 100).ToString().Split(',');
                    lblProgressState.Text = string.Format("Processing..{0}%", Convert.ToInt32(percent[0]));
                    progressBar1.Value = Convert.ToInt32(percent[0]);
                    progressBar1.Update();
                };

                // Download Video
                await client.Videos.Streams.DownloadAsync(
                    streamInfo, $"{txSaveTo.Text}\\{txTitle.Text}.{streamInfo.Container}", progress);

            }
            catch
            {
                MessageBox.Show("Problems:\n1. Reconnect internet provider.\n        or\n2. Url is wrong.");
            }

            //Reset ProgressBar.Value

            DownloadFinished();
        }

        //public CancellationToken CancelToken()
        //{
        //    //CancellationTokenSource source = new();
        //    //CancellationToken cancel = source.Token;
        //    //source.Cancel();

        //    //if (cancelIsRequired == true)
        //    //{
        //    //    cancelIsRequired = default;
        //    //    return cancel;
        //    //}
        //    //else
        //    //return default;

        //}

        public void DownloadFinished()
        {
            MessageBox.Show("Download has been successfully");
            progressBar1.Value = 0;
            lblProgressState.Text = "Process..0%";
            txUrl.Text = "";
            txSaveTo.Text = "";
            txTitle.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txSaveTo.Text = folderBrowserDialog.SelectedPath;
            }
            else
                MessageBox.Show("You didn`t select any path");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cancelIsRequired = true;
        }
    }
}