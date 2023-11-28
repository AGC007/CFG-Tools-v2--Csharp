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
    public partial class CONFIG_RECAPTCHA_V3 : MetroForm
    {
        public CONFIG_RECAPTCHA_V3()
        {
            InitializeComponent();
        }
private void EXITBTN_Click(object sender, EventArgs e) //EXIT
     { this.Close();}
private void BUILDBTN_Click(object sender, EventArgs e) //CONFIG
{string CON = "v=" + TXTVcon.Text + "&reason=q&c=<" + TXTTOKENn.Text + ">&k=" + TXTKcon.Text + "&co=" + TXTCOcon.Text + "&hl=en&size=invisible&chr=%5B89%2C64%2C27%5D&vh=13599012192&bg=" + TXTBGcon.Text;

configCONFIG.Text = // GET TOKEN - POST
 "#CONECT REQUEST GET " + @"""" + TXTURLget.Text + @"""" +
     "HEADER " + @"""" + "User-Agent:" + @" " + TEXTUSER.Text + @"""" +
     "HEADER " + @"""" + "Pragma: no-cache" + @"""" +
     "HEADER " + @"""" + "Accept: */*" + @"""" + @"

" + "#" + TXTTOKENn.Text + " PARSE " + @"""" + "<SOURCE>" + @"""" + " LR " + @"""" + @"type=\" + @"""" + @"hidden\" + @"""" + @" " + @"id=\" + @"""" + @"recaptcha-token\" + @"""" + @" " + @"value=\" + @"""" + @"""" + @" " + @"""" + @"\" + @"""" + @"""" + @" " + "->" + "VAR" + @" " + @"""" + TXTTOKENn.Text + @"""" + @"

" + "#POST REQUEST POST " + @"""" + TXTURLpost.Text + @"""" +
      "CONTENT " + @"""" + CON + @""""+
      "HEADER " + @"""" + "User-Agent:" + @" " + TEXTUSER.Text + @"""" +
      "HEADER " + @"""" + "Pragma: no-cache" + @"""" +
      "HEADER " + @"""" + "Accept: */*" + @"""" +
      "HEADER " + @"""" + "accept-encoding: gzip, deflate, br" + @"""" +
      "HEADER " + @"""" + "accept-language: fa,en;q=0.9,en-GB;q=0.8,en-US;q=0.7" + @"""" +
      "HEADER " + @"""" + "content-length: 5628" + @"""" +
      "HEADER " + @"""" + "origin: https://www.google.com" + @"""" +
      "HEADER " + @"""" + "referer: <ADDRESS>" + @"""" +
      "HEADER " + @"""" + "sec-fetch-dest: empty" + @"""" +
      "HEADER " + @"""" + "sec-fetch-mode: cors" + @"""" +
      "HEADER " + @"""" + "sec-fetch-site: same-origin" + @"""" + @"

"+ "#" + TXTTOKENrn.Text + " PARSE " + @"""" + "<SOURCE>" + @"""" + " LR " + @"""" + @"[\"+@""""+ @"rresp\"+@""""+ @",\"+@""""+@""""+@" "+@""""+@"\"+@""""+@""""+ "->" + "VER" + @" " + @"""" + TXTTOKENrn.Text + @"""";
        }
private void CLRBTN_Click(object sender, EventArgs e) //CLR
     {TXTURLget.Text = "";TXTURLpost.Text = "";TXTVcon.Text = "";TXTKcon.Text = "";TXTCOcon.Text = "";}
private void CLRALLBTN_Click(object sender, EventArgs e) //CLR-ALL
     {TXTURLget.Text = ""; TXTURLpost.Text = ""; TXTVcon.Text = ""; TXTKcon.Text = ""; TXTCOcon.Text = "";configCONFIG.Text = "";}
    }
}
