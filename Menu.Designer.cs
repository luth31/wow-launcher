namespace wow_launcher_cs
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.frameBottom = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.launcherLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.frameLeft = new System.Windows.Forms.Panel();
            this.frameRight = new System.Windows.Forms.Panel();
            this.bottomBackground = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.topBackground = new System.Windows.Forms.Panel();
            this.titleBar.SuspendLayout();
            this.bottomBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // frameBottom
            // 
            this.frameBottom.BackgroundImage = global::wow_launcher_cs.Properties.Resources.FrameBottom;
            this.frameBottom.Location = new System.Drawing.Point(3, 629);
            this.frameBottom.Name = "frameBottom";
            this.frameBottom.Size = new System.Drawing.Size(803, 4);
            this.frameBottom.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Lime;
            this.titleBar.BackgroundImage = global::wow_launcher_cs.Properties.Resources.BorderMain;
            this.titleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.titleBar.Controls.Add(this.panel1);
            this.titleBar.Controls.Add(this.launcherLabel);
            this.titleBar.Controls.Add(this.minimizeButton);
            this.titleBar.Controls.Add(this.closeButton);
            this.titleBar.Location = new System.Drawing.Point(3, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(804, 29);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::wow_launcher_cs.Properties.Resources._128;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(22, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // launcherLabel
            // 
            this.launcherLabel.AutoSize = true;
            this.launcherLabel.BackColor = System.Drawing.Color.Transparent;
            this.launcherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launcherLabel.ForeColor = System.Drawing.Color.White;
            this.launcherLabel.Location = new System.Drawing.Point(48, 10);
            this.launcherLabel.Name = "launcherLabel";
            this.launcherLabel.Size = new System.Drawing.Size(141, 13);
            this.launcherLabel.TabIndex = 3;
            this.launcherLabel.Text = "World of Warcraft 4.3.4";
            this.launcherLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.launcherLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.launcherLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::wow_launcher_cs.Properties.Resources.MinimizeButtonBase;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(749, 6);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseDown);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::wow_launcher_cs.Properties.Resources.CloseButtonBase;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(778, 6);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseDown);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseUp);
            // 
            // frameLeft
            // 
            this.frameLeft.BackgroundImage = global::wow_launcher_cs.Properties.Resources.FrameLeft;
            this.frameLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frameLeft.Location = new System.Drawing.Point(3, 0);
            this.frameLeft.Name = "frameLeft";
            this.frameLeft.Size = new System.Drawing.Size(3, 633);
            this.frameLeft.TabIndex = 0;
            // 
            // frameRight
            // 
            this.frameRight.BackgroundImage = global::wow_launcher_cs.Properties.Resources.FrameRight;
            this.frameRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frameRight.Location = new System.Drawing.Point(804, 0);
            this.frameRight.Name = "frameRight";
            this.frameRight.Size = new System.Drawing.Size(3, 633);
            this.frameRight.TabIndex = 1;
            // 
            // bottomBackground
            // 
            this.bottomBackground.BackColor = System.Drawing.Color.White;
            this.bottomBackground.BackgroundImage = global::wow_launcher_cs.Properties.Resources.BottomUpdateLauncher;
            this.bottomBackground.Controls.Add(this.progressBar);
            this.bottomBackground.Controls.Add(this.playButton);
            this.bottomBackground.Location = new System.Drawing.Point(3, 509);
            this.bottomBackground.Name = "bottomBackground";
            this.bottomBackground.Size = new System.Drawing.Size(803, 120);
            this.bottomBackground.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.progressBar.Location = new System.Drawing.Point(22, 57);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(585, 10);
            this.progressBar.TabIndex = 0;
            this.progressBar.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::wow_launcher_cs.Properties.Resources.PlayButtonBase;
            this.playButton.Enabled = false;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(645, 20);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(140, 84);
            this.playButton.TabIndex = 0;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.EnabledChanged += new System.EventHandler(this.playButton_EnabledChanged);
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseDown);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            this.playButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseUp);
            // 
            // topBackground
            // 
            this.topBackground.BackgroundImage = global::wow_launcher_cs.Properties.Resources.MainWindowImagePatch;
            this.topBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topBackground.Location = new System.Drawing.Point(3, 29);
            this.topBackground.Name = "topBackground";
            this.topBackground.Size = new System.Drawing.Size(803, 480);
            this.topBackground.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(812, 639);
            this.ControlBox = false;
            this.Controls.Add(this.frameBottom);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.frameLeft);
            this.Controls.Add(this.frameRight);
            this.Controls.Add(this.bottomBackground);
            this.Controls.Add(this.topBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.bottomBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel topBackground;
        private System.Windows.Forms.Panel frameLeft;
        private System.Windows.Forms.Panel frameRight;
        private System.Windows.Forms.Panel bottomBackground;
        private System.Windows.Forms.Panel frameBottom;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label launcherLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox progressBar;
    }
}