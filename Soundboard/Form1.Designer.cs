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
            button1 = new Button();
            audioClipTB1 = new TextBox();
            playBtn1 = new Button();
            volume1 = new TrackBar();
            stop1 = new Button();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)volume1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(271, 12);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Audio File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "No audio clip selected (.mp3)";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 121);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(253, 45);
            trackBar1.TabIndex = 6;
            trackBar1.Value = 75;
            // 
            // button2
            // 
            button2.Location = new Point(271, 92);
            button2.Name = "button2";
            button2.Size = new Size(139, 23);
            button2.TabIndex = 7;
            button2.Text = "Load Audio File";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(271, 121);
            button3.Name = "button3";
            button3.Size = new Size(65, 23);
            button3.TabIndex = 8;
            button3.Text = "Play";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(342, 121);
            button4.Name = "button4";
            button4.Size = new Size(68, 23);
            button4.TabIndex = 9;
            button4.Text = "Stop";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(trackBar1);
            Controls.Add(textBox1);
            Controls.Add(stop1);
            Controls.Add(volume1);
            Controls.Add(playBtn1);
            Controls.Add(audioClipTB1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)volume1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox audioClipTB1;
        private Button playBtn1;
        private TrackBar volume1;
        private Button stop1;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}