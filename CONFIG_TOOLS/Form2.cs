using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace CONFIG_TOOLS
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void EXIT_BTN_Click(object sender, EventArgs e) //EXIT
        { Application.Exit(); }
        private void Github_BTN_Click(object sender, EventArgs e) //Github_BTN_Click
        {
            Process.Start("https://Github.Com/AGC007");
        }
        private void CONFIG_BTN_Click(object sender, EventArgs e)//CONFIG MAKER
        { CONFIG_MAKER f1 = new CONFIG_MAKER(); f1.Show(); }
        private void CONFIG_LEN_BTN_Click(object sender, EventArgs e)//CONFIG MAKER+LENGTH
        { Config_LEN f1 = new Config_LEN(); f1.Show(); }
        private void RV3_BTN_Click(object sender, EventArgs e)//CONFIG_RECAPTCHA_V3
        { CONFIG_RECAPTCHA_V3 f1 = new CONFIG_RECAPTCHA_V3(); f1.Show(); }
        private void Find_HitSender_BTN_Click(object sender, EventArgs e)//FIND_HIT_SENDER
        { FIND_HIT_SENDER f1 = new FIND_HIT_SENDER(); f1.Show(); }
        private void Find_HitSender_About_BTN_Click(object sender, EventArgs e)//ABOUT_HIT_SENDER
        { ABOUT_HIT_SENDER f1 = new ABOUT_HIT_SENDER(); f1.Show(); }
        private void H_CAPTCHA_BTN_Click(object sender, EventArgs e)//CONFIG_H_CAPTCHA
        { Bypass_H_CAPTCHA f1 = new Bypass_H_CAPTCHA(); f1.Show(); }
        private void CONFIG_SETTINGS_BTN_Click(object sender, EventArgs e)//CONFIG_SETTINGS_EDIT
        { Config_SETTINGS_EDIT f1 = new Config_SETTINGS_EDIT(); f1.Show(); }
        private void Change_Theme_BTN_Click(object sender, EventArgs e)//CHANGE_COLOR
        {
            MetroFramework.MetroThemeStyle TC = new MetroFramework.MetroThemeStyle();
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark || this.Theme == MetroFramework.MetroThemeStyle.Default)
            {
                TC = MetroFramework.MetroThemeStyle.Light;
            }
            else
            {
                TC = MetroFramework.MetroThemeStyle.Dark;
            }

                this.metroTabPage5.Theme = TC;    
                this.EXIT_BTN.Theme = TC; 
                this.Github_BTN.Theme = TC; 
                this.Change_Theme_BTN.Theme = TC; 
                this.metroTabPage4.Theme = TC;
                this.Open_Bullet_DL_BTN.Theme = TC; 
                this.Silver_Bullet_DL_BTN.Theme = TC; 
                this.metroTabPage3.Theme = TC;
                this.Find_HitSender_BTN.Theme = TC; 
                this.Find_HitSender_About_BTN.Theme = TC;
                this.metroTabPage2.Theme = TC; 
                this.RECAPTCHA_V3_BY_btn.Theme = TC;
                this.H_CAPTCHA_BTN.Theme = TC; 
                this.metroTabPage1.Theme = TC;
                this.CONFIG_LEN_BTN.Theme = TC; 
                this.CONFIG_BTN.Theme = TC; 
                this.CONFIG_SETTINGS_BTN.Theme = TC; 
                this.metroTabControl1.Theme = TC; 
                this.metroTabPage6.Theme = TC; 
                this.Theme = TC;

                this.Refresh();
            }
        private void Open_Bullet_DL_BTN_Click(object sender, EventArgs e)//Open_Bullet_DL_BTN
        {
            Process.Start("https://github.com/OpenBulletAnomaly/OpenBullet-Anomaly/releases/");
        }
        private void Silver_Bullet_DL_BTN_Click(object sender, EventArgs e)//Silver_Bullet_DL_BTN
        {
            Process.Start("https://t.me/SilverBullet_Soft/6");
        }
        private void Full_Screen_BTN_Click(object sender, EventArgs e)//Full_Screen_BTN_Click
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void TRX_BTN_Click(object sender, EventArgs e)//TRX_BTN_Click
        {
            MessageBox.Show("TNQT3pdbs7Jo3qxARGLv3NSQgi8t9ozgD7","TRX Wallet");
        }
        private void IRR_BTN_Click(object sender, EventArgs e)//IRR_BTN_Click
        {
            Process.Start("https://t.me/AGC007");
        }
        private void Change_Color_BTN_Click(object sender, EventArgs e)//Change_Color_BTN_Click
        {
            var Random1 = new Random();
            int ColorNext = Random1.Next(0, 13);


            metroTabControl1.Style = (MetroColorStyle)ColorNext;
            this.Style = (MetroColorStyle)ColorNext;
            this.Refresh();
        }
    }
}

