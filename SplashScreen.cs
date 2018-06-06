using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace wow_launcher_cs
{
    public partial class SplashScreen : Form
    {
        private Menu menu;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            string productVersion = Application.ProductVersion;
            versionLabel.Text = "Version: " + productVersion;
            Updater.Init();
            Updater.UpdateLauncher();
        }

        private Timer tmr;

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (Updater.GetStatus() == 0)
            {
                tmr.Stop();
                this.Hide();
                menu = new Menu();
                menu.Show();
                return;
            }
            tmr.Start();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 3 * 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }

        public void PauseSplash()
        {
            tmr.Stop();
        }
    
        public void ResumeSplash()
        {
            tmr.Start();
        }
    }
}
