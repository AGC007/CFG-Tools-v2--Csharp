namespace CONFIG_TOOLS
{
    partial class FIND_HIT_SENDER
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
            this.FIND_CONFIGbtn = new MetroFramework.Controls.MetroButton();
            this.EXITbtn = new MetroFramework.Controls.MetroButton();
            this.OPEN_CONFIGbtn = new MetroFramework.Controls.MetroButton();
            this.TEXT_BOX_LED = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // FIND_CONFIGbtn
            // 
            this.FIND_CONFIGbtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.FIND_CONFIGbtn.Location = new System.Drawing.Point(352, 78);
            this.FIND_CONFIGbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FIND_CONFIGbtn.Name = "FIND_CONFIGbtn";
            this.FIND_CONFIGbtn.Size = new System.Drawing.Size(331, 44);
            this.FIND_CONFIGbtn.TabIndex = 33;
            this.FIND_CONFIGbtn.Text = "FIND";
            this.FIND_CONFIGbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FIND_CONFIGbtn.UseSelectable = true;
            this.FIND_CONFIGbtn.Click += new System.EventHandler(this.FIND_CONFIGbtn_Click);
            // 
            // EXITbtn
            // 
            this.EXITbtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.EXITbtn.Location = new System.Drawing.Point(15, 314);
            this.EXITbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EXITbtn.Name = "EXITbtn";
            this.EXITbtn.Size = new System.Drawing.Size(669, 44);
            this.EXITbtn.TabIndex = 32;
            this.EXITbtn.Text = "EXIT";
            this.EXITbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EXITbtn.UseSelectable = true;
            this.EXITbtn.Click += new System.EventHandler(this.EXITbtn_Click);
            // 
            // OPEN_CONFIGbtn
            // 
            this.OPEN_CONFIGbtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.OPEN_CONFIGbtn.Location = new System.Drawing.Point(15, 78);
            this.OPEN_CONFIGbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OPEN_CONFIGbtn.Name = "OPEN_CONFIGbtn";
            this.OPEN_CONFIGbtn.Size = new System.Drawing.Size(331, 44);
            this.OPEN_CONFIGbtn.TabIndex = 31;
            this.OPEN_CONFIGbtn.Text = "OPEN CONFIG";
            this.OPEN_CONFIGbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OPEN_CONFIGbtn.UseSelectable = true;
            this.OPEN_CONFIGbtn.Click += new System.EventHandler(this.OPEN_CONFIGbtn_Click);
            // 
            // TEXT_BOX_LED
            // 
            this.TEXT_BOX_LED.BackColor = System.Drawing.SystemColors.MenuText;
            this.TEXT_BOX_LED.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_BOX_LED.ForeColor = System.Drawing.SystemColors.Menu;
            this.TEXT_BOX_LED.Location = new System.Drawing.Point(15, 129);
            this.TEXT_BOX_LED.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TEXT_BOX_LED.Multiline = true;
            this.TEXT_BOX_LED.Name = "TEXT_BOX_LED";
            this.TEXT_BOX_LED.Size = new System.Drawing.Size(668, 177);
            this.TEXT_BOX_LED.TabIndex = 34;
            this.TEXT_BOX_LED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FIND_HIT_SENDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 384);
            this.Controls.Add(this.TEXT_BOX_LED);
            this.Controls.Add(this.FIND_CONFIGbtn);
            this.Controls.Add(this.EXITbtn);
            this.Controls.Add(this.OPEN_CONFIGbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FIND_HIT_SENDER";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "FIND[HIT-SENDER]~AGC007";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FIND_HIT_SENDER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton FIND_CONFIGbtn;
        private MetroFramework.Controls.MetroButton EXITbtn;
        private MetroFramework.Controls.MetroButton OPEN_CONFIGbtn;
        private System.Windows.Forms.TextBox TEXT_BOX_LED;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}