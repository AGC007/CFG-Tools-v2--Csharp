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
    public partial class CONFIG_MAKER : MetroForm
    {
        public CONFIG_MAKER()
        {
            InitializeComponent();
        }
private void EXITBTN_Click(object sender, EventArgs e) //CLOSE
    {this.Close();}
private void BUILDBTN_Click(object sender, EventArgs e) //CONFIG
       { //URL
       configURL.Text = "#"+TXTNAME.Text+ @""+" REQUEST " + TXTMETOD.Text + " " + @"""" + TXTURL.Text + @"""";
            //FORMDB
       configFORMDB.Text = "CONTENT " + @"""" + TXTFORMDB.Text + @"""";
            //FORMTYPE
       configFORMTYPE.Text = "CONTENTTYPE " + @"""" + TXTFORMType.Text + @"""";
            //USER
            configUSER.Text = "HEADER " + @"""" + "User-Agent:" + @" "+ TXTUSER.Text + @"""";
            //H1
       H1.Text = "HEADER " + @"""" + "Pragma: no-cache" + @"""";
            //H2
       H2.Text = "HEADER " + @"""" + "Accept: */*" + @"""";
            //KEyCheck
       configKeyCheck.Text = "KEYCHECK KEYCHAIN Failure OR KEY " + @"""" + TXTfalse.Text + @"""" + "KEYCHAIN Success OR KEY " + @"""" + TXTsuccess.Text + @"""";
            //CONFIG
       configCONFIG.Text = configURL.Text + configFORMDB.Text + configFORMTYPE.Text + configUSER.Text + H1.Text + H2.Text + @"
" + configKeyCheck.Text;
        }
private void CLRBTN_Click(object sender, EventArgs e) //CLR All
    {
     TXTfalse.Text = ""; TXTsuccess.Text = ""; TXTURL.Text = ""; TXTUSER.Text = ""; TXTFORMDB.Text = ""; TXTFORMType.Text = ""; H1.Text = "";H2.Text = "";
        configCONFIG.Text = ""; configFORMDB.Text = ""; configFORMTYPE.Text = ""; configKeyCheck.Text = ""; configURL.Text = ""; configUSER.Text = "";
    }
private void CLRBTN_Click_1(object sender, EventArgs e) //CLR
    {TXTfalse.Text = ""; TXTsuccess.Text = ""; TXTURL.Text = ""; TXTUSER.Text = ""; TXTFORMDB.Text = ""; TXTFORMType.Text = "";}

        private void CONFIG_MAKER_Load(object sender, EventArgs e)
        {
            Form2 f1 = new Form2(); f1.Close();
        }
    }
}
