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
    public partial class Bypass_H_CAPTCHA : MetroForm
    {
        public Bypass_H_CAPTCHA()
        {
            InitializeComponent();
        }
private void EXITBTN_Click(object sender, EventArgs e)//EXIT
        {
            this.Close();
        }
private void BUILDBTN_Click(object sender, EventArgs e)//CONFIG
        {
            configCONFIG.Text = // GET TOKEN - POST
               "#WEB REQUEST OPTIONS " + @"""" + TXTURLget.Text + @"""" +
                  "HEADER " + @"""" + "User-Agent:" + @" " + TEXTUSER.Text + @"""" +
                  "HEADER " + @"""" + "Pragma: no-cache" + @"""" +
                  "HEADER " + @"""" + "Accept: */*" + @"""" + @"

" + "#GET REQUEST GET " + @"""" + TXTURLget.Text + @"""" +
                    "HEADER " + @"""" + "User-Agent:" + @" " + TEXTUSER.Text + @"""" +
                    "HEADER " + @"""" + "Pragma: no-cache" + @"""" +
                    "HEADER " + @"""" + "Accept: */*" + @"""" + @"

" + "#" + TXTTOKENn.Text + " PARSE " + @"""" + "<SOURCE>" + @"""" + " LR " + @"""" + @"req\" + @"""" + @":\" + @"""" + @"""" + @" " + @"""" + @"\" + @"""" + @"""" + @" " + "->" + @" " + "VAR" + @" " + @"""" + TXTTOKENn.Text + @"""" + @"

" + "#POST REQUEST POST " + @"""" + "https://hcaptcha.com/getcaptcha" + @"""" +
                  "CONTENT " + @"""" + TXTCONTENTcon.Text + @"""" +
                  "CONTENTTYPE " + @"""" + "application/x-www-form-urlencoded" + @"""" +
                  "HEADER " + @"""" + "User-Agent:" + @" " + TEXTUSER.Text + @"""" +
                  "HEADER " + @"""" + "Pragma: no-cache" + @"""" +
                  "HEADER " + @"""" + "Accept: */*" + @"""" +
                  "HEADER " + @"""" + "Accept: application/json" + @"""" +
                  "HEADER " + @"""" + "accept-encoding: gzip, deflate, br" + @"""" +
                  "HEADER " + @"""" + "accept-language: fa,en;q=0.9,en-GB;q=0.8,en-US;q=0.7" + @"""" +
                  "HEADER " + @"""" + "content-length: 6376" + @"""" +
                  "HEADER " + @"""" + "origin: https://assets.hcaptcha.com" + @"""" +
                  "HEADER " + @"""" + "referer: https://assets.hcaptcha.com/" + @"""" +
                  "HEADER " + @"""" + "sec-fetch-dest: empty" + @"""" +
                  "HEADER " + @"""" + "sec-fetch-mode: cors" + @"""" +
                  "HEADER " + @"""" + "sec-fetch-site: same-origin" + @"""" + @"

" + "#" + TXTTOKENrn.Text + " PARSE " + @"""" + "<SOURCE>" + @"""" + " LR " + @"""" + @"generated_pass_UUID\" + @"""" + @":\" + @"""" + @"""" + @" " + @"""" + @"\" + @"""" + @"""" + @" " + "->" + @" " + "VAR" + @" " + @"""" + TXTTOKENrn.Text + @"""";
        }
private void CLRBTN_Click(object sender, EventArgs e)//CLR-BTN
        {
            TXTURLget.Text = "";TXTCONTENTcon.Text = "";
        }
private void CLRALLBTN_Click(object sender, EventArgs e)//CLR-ALL-BTN
        {
            TXTURLget.Text = ""; TXTCONTENTcon.Text = "";configCONFIG.Text = "";
        }
    }
}
