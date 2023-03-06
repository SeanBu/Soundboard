using WMPLib;

namespace Soundboard
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        String filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Audio File";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = ofd.FileName;
                audioClipTB1.Text = filePath;
            }
        }

        private void playBtn1_Click(object sender, EventArgs e)
        {
            player.controls.play();
            player.URL = filePath;
            player.settings.volume = volume1.Value;
        }

        private void stop1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
    }
}