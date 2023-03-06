using WMPLib;

namespace Soundboard
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "Select Audio File";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                audioClipTB1.Text = ofd.FileName;
            }
        }

        private void playBtn1_Click(object sender, EventArgs e)
        {
            player.controls.play();
            player.URL = getAudioClipURL(audioClipTB1);
            player.settings.volume = volume1.Value;
        }

        private void stop1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void loadAudio2_Click(object sender, EventArgs e)
        {
            ofd.Title = "Select Audio File";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                audioClipTB2.Text = ofd.FileName;
            }
        }

        private void playBtn2_Click(object sender, EventArgs e)
        {
            player2.controls.play();
            player2.URL = getAudioClipURL(audioClipTB2);
            player2.settings.volume = volume2.Value;
        }

        private void stop2_Click(object sender, EventArgs e)
        {
            player2.controls.stop();
        }

        private string getAudioClipURL(TextBox textbox)
        {
            return textbox.Text;
        }
    }
}