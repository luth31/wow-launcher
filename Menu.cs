using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace wow_launcher_cs
{
    public partial class Menu : Form
    {
        string locale;

        public Menu()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        static public void UpdateWow()
        {
            if (Updater.data.disabled)
                return;
            if (File.Exists("Wow.exe"))
            {
                if (Updater.CalculateMD5("Wow.exe").CompareTo(Updater.data.Wow.md5) == 0)
                {
                    PlayWow();
                    return;
                }
                if (File.Exists("Wow.exe.old"))
                    File.Delete("Wow.exe.old");
                File.Move("Wow.exe", "Wow.exe.old");
            }
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += ((sender, args) =>
                {
                    PlayWow();
                });
                wc.DownloadFileAsync(new System.Uri(Updater.data.Wow.link), "Wow.exe");
            }
        }

        static private void PlayWow()
        {
            Process.Start("Wow.exe");
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            UpdatePlayButton(playButton);
            this.Text = "Launcher";
            if (File.Exists("Launcher.exe.old"))
                File.Delete("Launcher.exe.old");
            if (Directory.Exists("Data/enUS"))
                locale = "enUS";
            else if (Directory.Exists("Data/enGB"))
                locale = "enGB";
            else
            {
                var result = MessageBox.Show("Wow folder not detected! Move the launcher to a proper location.", "Error", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            if (Directory.Exists("Cache"))
                Directory.Delete("Cache", true);
        }

        public void UpdatePatches()
        {
            Thread thread = new Thread(() =>
            {
                if (Updater.data.disabled)
                    return;
                foreach (Updater.PatchData patch in Updater.data.Patches)
                {
                    bool dlCpt = false;

                    if (File.Exists("Data/" + patch.name) && Updater.CalculateMD5("Data/" + patch.name).CompareTo(patch.md5) == 0)
                        continue;
                    if (File.Exists("Data/" + patch.name))
                        File.Delete("Data/" + patch.name);
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(UpdateProgress);
                        wc.DownloadFileCompleted += ((sender, args) =>
                        {
                            dlCpt = true;
                        });
                        wc.DownloadFileAsync(new System.Uri(patch.link), "Data/" + patch.name);
                    }
                    while (!dlCpt)
                    {
                        Application.DoEvents();
                    }
                }
                playButton.Enabled = true;
                UpdatePlayButton(playButton);
            });
            thread.Start();
        }

        public void UpdateProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            SetProgressBarPct(Convert.ToInt32(percentage));
        }

        public void SetProgressBarPct(int pct)
        {
            Bitmap bmp = new Bitmap(Properties.Resources.dl_bar_green);
            for (int Xcount = (pct*bmp.Width)/100; Xcount < bmp.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < bmp.Height; Ycount++)
                {
                    bmp.SetPixel(Xcount, Ycount, Color.Transparent);
                }
            }

            progressBar.BackgroundImage = bmp;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playButton_MouseDown(object sender, MouseEventArgs e)
        {
            playButton.BackgroundImage = Properties.Resources.PlayButtonDown;
        }

        private void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            playButton.BackgroundImage = Properties.Resources.PlayButtonBase;
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            playButton.BackgroundImage = Properties.Resources.PlayButtonHover;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackgroundImage = Properties.Resources.PlayButtonBase;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackgroundImage = Properties.Resources.MinimizeButtonHover;
        }

        private void minimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            minimizeButton.BackgroundImage = Properties.Resources.MinimizeButtonDown;
        }

        private void minimizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            minimizeButton.BackgroundImage = Properties.Resources.MinimizeButtonBase;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackgroundImage = Properties.Resources.MinimizeButtonBase;
        }

        private void closeButton_MouseDown(object sender, MouseEventArgs e)
        {
            closeButton.BackgroundImage = Properties.Resources.CloseButtonDown;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = Properties.Resources.CloseButtonHover;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = Properties.Resources.CloseButtonBase;
        }

        private void closeButton_MouseUp(object sender, MouseEventArgs e)
        {
            closeButton.BackgroundImage = Properties.Resources.CloseButtonBase;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void playButton_EnabledChanged(object sender, EventArgs e)
        {
            UpdatePlayButton(sender);
        }

        private void UpdatePlayButton(object b)
        {
            if (playButton.Enabled)
                playButton.BackgroundImage = Properties.Resources.PlayButtonBase;
            else
                playButton.BackgroundImage = Properties.Resources.PlayButtonDisabled;
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            string wtfpath = "Data/" + locale + "/realmlist.wtf";
            if (File.Exists(wtfpath))
            {
                FileAttributes attributes = File.GetAttributes(wtfpath);

                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    File.SetAttributes(wtfpath, FileAttributes.Normal);
                    if (System.IO.File.ReadAllText(wtfpath).CompareTo("set realmlist localhost") != 0)
                {
                    FileStream fs = new FileStream(wtfpath, FileMode.OpenOrCreate);
                    byte[] rlm = new UTF8Encoding(true).GetBytes("set realmlist localhost");
                    fs.Write(rlm, 0, rlm.Length);
                    fs.Close();
                }
            }
            UpdatePatches();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            UpdateWow();
        }
    }
}
