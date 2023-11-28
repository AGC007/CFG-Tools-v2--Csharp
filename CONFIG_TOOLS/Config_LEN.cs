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
    public partial class Config_LEN : MetroForm
    {
        public Config_LEN()
        {
            InitializeComponent();
        }
private void EXITBTN_Click(object sender, EventArgs e) // CLOSE
      {this.Close();}
private void CLRBTN_Click(object sender, EventArgs e) //CLR
    { TXTfalse.Text = ""; TXTsuccess.Text = ""; TXTURL.Text = ""; TXTUSER.Text = ""; TXTFORMDB.Text = ""; TXTFORMType.Text = ""; }
private void BUILDBTN_Click(object sender, EventArgs e) // CONFIG
        { //URL
            configURL.Text = "#" + TXTNAME.Text + @"" + " REQUEST " + TXTMETOD.Text + " " + @"""" + TXTURL.Text + @"""";
            //FORMDB
            configFORMDB.Text = "CONTENT " + @"""" + TXTFORMDB.Text + @"""";
            //FORMTYPE
            configFORMTYPE.Text = "CONTENTTYPE " + @"""" + TXTFORMType.Text + @"""";
            //USER
            configUSER.Text = "HEADER " + @"""" + "User-Agent:" + @" " + TXTUSER.Text + @"""";
            //H1
            H1.Text = "HEADER " + @"""" + "Pragma: no-cache" + @"""";
            //H2
            H2.Text = "HEADER " + @"""" + "Accept: */*" + @"""";
            //LEN
     String LEN = "HEADER " + @"""" + "content-length: <LEN>" + @"""";
            //USERLEN
            configUSERLEN.Text= "#US FUNCTION URLEncode " + @"""" + "<USER>" + @"""" + " -> VAR " + @"""" + "US" + @"""";
            //PASSLEN
            configPASSLEN.Text = "#PS FUNCTION URLEncode " + @"""" + "<PASS>" + @"""" + " -> VAR " + @"""" + "PS" + @"""";
            //LENGH-LEN
            configLEN.Text= "#LEN FUNCTION Length " + @"""" + TXTFORMDB.Text + @"""" + " -> VAR " + @"""" + "LEN" + @"""";
            //KEyCheck
            configKeyCheck.Text = "KEYCHECK KEYCHAIN Failure OR KEY " + @"""" + TXTfalse.Text + @"""" + "KEYCHAIN Success OR KEY " + @"""" + TXTsuccess.Text + @"""";
           //CONFIG
configCONFIG.Text = configUSERLEN.Text+@"
"+ configPASSLEN.Text+@"
"+ configLEN.Text+@"
"+ configURL.Text + configFORMDB.Text + configFORMTYPE.Text + configUSER.Text + H1.Text + H2.Text +LEN+ @"
"+ configKeyCheck.Text;
        }
private void CLRALLBTN_Click(object sender, EventArgs e) //CLRALL
        {
      TXTfalse.Text = ""; TXTsuccess.Text = ""; TXTURL.Text = ""; TXTUSER.Text = ""; TXTFORMDB.Text = ""; TXTFORMType.Text = ""; H1.Text = ""; H2.Text = "";
         configCONFIG.Text = ""; configFORMDB.Text = ""; configFORMTYPE.Text = ""; configKeyCheck.Text = ""; configURL.Text = ""; configUSER.Text = "";configUSERLEN.Text = "";configPASSLEN.Text = ""; configLEN.Text = "";
            }
        }
   }


