namespace Soundboard
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
            loadAudio1 = new Button();
            audioClipTB1 = new TextBox();
            playBtn1 = new Button();
            volume1 = new TrackBar();
            stop1 = new Button();
            audioClipTB2 = new TextBox();
            volume2 = new TrackBar();
            loadAudio2 = new Button();
            playBtn2 = new Button();
            stop2 = new Button();
            ((System.ComponentModel.ISupportInitialize)volume1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volume2).BeginInit();
            SuspendLayout();
            // 
            // loadAudio1
            // 
            loadAudio1.Location = new Point(271, 12);
            loadAudio1.Name = "loadAudio1";
            loadAudio1.Size = new Size(139, 23);
            loadAudio1.TabIndex = 0;
            loadAudio1.Text = "Load Audio File";
            loadAudio1.UseVisualStyleBackColor = true;
            loadAudio1.Click += button1_Click;
            // 
            // audioClipTB1
            // 
            audioClipTB1.Enabled = false;
            audioClipTB1.Location = new Point(12, 12);
            audioClipTB1.Name = "audioClipTB1";
            audioClipTB1.Size = new Size(253, 23);
            audioClipTB1.TabIndex = 1;
            audioClipTB1.Text = "No audio clip selected (.mp3)";
            // 
            // playBtn1
            // 
            playBtn1.Location = new Point(271, 41);
            playBtn1.Name = "playBtn1";
            playBtn1.Size = new Size(65, 23);
            playBtn1.TabIndex = 2;
            playBtn1.Text = "Play";
            playBtn1.UseVisualStyleBackColor = true;
            playBtn1.Click += playBtn1_Click;
            // 
            // volume1
            // 
            volume1.Location = new Point(12, 41);
            volume1.Maximum = 100;
            volume1.Name = "volume1";
            volume1.Size = new Size(253, 45);
            volume1.TabIndex = 3;
            volume1.Value = 75;
            // 
            // stop1
            // 
            stop1.Location = new Point(342, 41);
            stop1.Name = "stop1";
            stop1.Size = new Size(68, 23);
            stop1.TabIndex = 4;
            stop1.Text = "Stop";
            stop1.UseVisualStyleBackColor = true;
            stop1.Click += stop1_Click;
            // 
            // audioClipTB2
            // 
            audioClipTB2.Enabled = false;
            audioClipTB2.Location = new Point(12, 92);
            audioClipTB2.Name = "audioClipTB2";
            audioClipTB2.Size = new Size(253, 23);
            audioClipTB2.TabIndex = 5;
            audioClipTB2.Text = "No audio clip selected (.mp3)";
            // 
            // volume2
            // 
            volume2.Location = new Point(12, 121);
            volume2.Maximum = 100;
            volume2.Name = "volume2";
            volume2.Size = new Size(253, 45);
            volume2.TabIndex = 6;
            volume2.Value = 75;
            // 
            // loadAudio2
            // 
            loadAudio2.Location = new Point(271, 92);
            loadAudio2.Name = "loadAudio2";
            loadAudio2.Size = new Size(139, 23);
            loadAudio2.TabIndex = 7;
            loadAudio2.Text = "Load Audio File";
            loadAudio2.UseVisualStyleBackColor = true;
            loadAudio2.Click += loadAudio2_Click;
            // 
            // playBtn2
            // 
            playBtn2.Location = new Point(271, 121);
            playBtn2.Name = "playBtn2";
            playBtn2.Size = new Size(65, 23);
            playBtn2.TabIndex = 8;
            playBtn2.Text = "Play";
            playBtn2.UseVisualStyleBackColor = true;
            playBtn2.Click += playBtn2_Click;
            // 
            // stop2
            // 
            stop2.Location = new Point(342, 121);
            stop2.Name = "stop2";
            stop2.Size = new Size(68, 23);
            stop2.TabIndex = 9;
            stop2.Text = "Stop";
            stop2.UseVisualStyleBackColor = true;
            stop2.Click += stop2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 450);
            Controls.Add(stop2);
            Controls.Add(playBtn2);
            Controls.Add(loadAudio2);
            Controls.Add(volume2);
            Controls.Add(audioClipTB2);
            Controls.Add(stop1);
            Controls.Add(volume1);
            Controls.Add(playBtn1);
            Controls.Add(audioClipTB1);
            Controls.Add(loadAudio1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)volume1).EndInit();
            ((System.ComponentModel.ISupportInitialize)volume2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAudio1;
        private TextBox audioClipTB1;
        private Button playBtn1;
        private TrackBar volume1;
        private Button stop1;
        private TextBox audioClipTB2;
        private TrackBar volume2;
        private Button loadAudio2;
        private Button playBtn2;
        private Button stop2;
    }
}