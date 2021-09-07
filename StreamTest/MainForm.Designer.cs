namespace StreamTest
{
    partial class MainForm
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
            this.btnInitLibrary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.btnPlayMedia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitLibrary
            // 
            this.btnInitLibrary.Location = new System.Drawing.Point(12, 12);
            this.btnInitLibrary.Name = "btnInitLibrary";
            this.btnInitLibrary.Size = new System.Drawing.Size(75, 23);
            this.btnInitLibrary.TabIndex = 0;
            this.btnInitLibrary.Text = "Init library";
            this.btnInitLibrary.UseVisualStyleBackColor = true;
            this.btnInitLibrary.Click += new System.EventHandler(this.btnInitLibrary_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.videoView);
            this.panel1.Location = new System.Drawing.Point(93, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 293);
            this.panel1.TabIndex = 2;
            // 
            // videoView
            // 
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView.Location = new System.Drawing.Point(0, 0);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(794, 293);
            this.videoView.TabIndex = 2;
            // 
            // btnPlayMedia
            // 
            this.btnPlayMedia.Location = new System.Drawing.Point(12, 41);
            this.btnPlayMedia.Name = "btnPlayMedia";
            this.btnPlayMedia.Size = new System.Drawing.Size(75, 23);
            this.btnPlayMedia.TabIndex = 3;
            this.btnPlayMedia.Text = "Play media";
            this.btnPlayMedia.UseVisualStyleBackColor = true;
            this.btnPlayMedia.Click += new System.EventHandler(this.btnPlayMedia_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 317);
            this.Controls.Add(this.btnPlayMedia);
            this.Controls.Add(this.btnInitLibrary);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "VLCSharp tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInitLibrary;
        private System.Windows.Forms.Panel panel1;
        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.Button btnPlayMedia;
    }
}

