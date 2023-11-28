using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CONFIG_TOOLS
{
    public partial class FIND_HIT_SENDER : MetroForm
    {
        string fn;
        string file;
        public FIND_HIT_SENDER()
        {
            InitializeComponent();
        }
        private void EXITbtn_Click(object sender, EventArgs e) //EXIT
        {this.Close();}

        private void OPEN_CONFIGbtn_Click(object sender, EventArgs e) //OPEN CONFIG
        {
            openFileDialog1.Filter = "All Files |*.*|Config File anom|*.anom|Config File loli|*.loli|Text File|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fn = openFileDialog1.FileName;
            file = System.IO.File.ReadAllText(fn);
            TEXT_BOX_LED.ForeColor = Color.Red;
            TEXT_BOX_LED.Text = "Please Click The Find Button.";
            FIND_CONFIGbtn.Enabled = true;
        }

        private void FIND_CONFIGbtn_Click(object sender, EventArgs e) //FIND
        {
            Find_Hit_Sender_FUN(file);

        }
      Boolean Find_Hit_Sender_FUN(string s)//FIND DISORD
        {
      int D,T;
      D = file.IndexOf("discord.com/api/");
      T = file.IndexOf("api.telegram.org");

      if (D == -1 || T == -1)
       {
                TEXT_BOX_LED.ForeColor = Color.Green;
                TEXT_BOX_LED.Text = "This Configuration is Safe."; 
                MessageBox.Show("This Configuration is Safe.");
                return false;
      }
      else
       {
                TEXT_BOX_LED.SelectionStart = D;
                TEXT_BOX_LED.SelectionLength = s.Length;
                TEXT_BOX_LED.ForeColor = Color.Red;
                TEXT_BOX_LED.Text = "This Configuration is Not Secure.";
                MessageBox.Show("Warning .. This Configuration is Not Secure.");
                TEXT_BOX_LED.Focus();return true;}
       }

        private void FIND_HIT_SENDER_Load(object sender, EventArgs e) //OPEN FORM
        {
            TEXT_BOX_LED.ForeColor = Color.Red;
            TEXT_BOX_LED.Text = "Use The Open Option To Add a Config";
            FIND_CONFIGbtn.Enabled = false;
        }
    }
}
