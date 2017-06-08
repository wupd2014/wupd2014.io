namespace WinMain
{
    partial class DaYin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaYin));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textGH2 = new System.Windows.Forms.TextBox();
            this.textGH1 = new System.Windows.Forms.TextBox();
            this.txtZXPrice1 = new System.Windows.Forms.TextBox();
            this.txtDate1 = new System.Windows.Forms.TextBox();
            this.txtCc1 = new System.Windows.Forms.TextBox();
            this.txtEndStation1 = new System.Windows.Forms.TextBox();
            this.txtZXPrice = new System.Windows.Forms.TextBox();
            this.txtKPLX = new System.Windows.Forms.TextBox();
            this.txtZFPrice = new System.Windows.Forms.TextBox();
            this.txtCLLX = new System.Windows.Forms.TextBox();
            this.txtZWH = new System.Windows.Forms.TextBox();
            this.txtJPK = new System.Windows.Forms.TextBox();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.txtEndStation = new System.Windows.Forms.TextBox();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "打 印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(670, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "预 览";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textGH2);
            this.panel1.Controls.Add(this.textGH1);
            this.panel1.Controls.Add(this.txtZXPrice1);
            this.panel1.Controls.Add(this.txtDate1);
            this.panel1.Controls.Add(this.txtCc1);
            this.panel1.Controls.Add(this.txtEndStation1);
            this.panel1.Controls.Add(this.txtZXPrice);
            this.panel1.Controls.Add(this.txtKPLX);
            this.panel1.Controls.Add(this.txtZFPrice);
            this.panel1.Controls.Add(this.txtCLLX);
            this.panel1.Controls.Add(this.txtZWH);
            this.panel1.Controls.Add(this.txtJPK);
            this.panel1.Controls.Add(this.txtCc);
            this.panel1.Controls.Add(this.txtDateTime);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtPerson);
            this.panel1.Controls.Add(this.txtEndStation);
            this.panel1.Controls.Add(this.txtStartStation);
            this.panel1.Location = new System.Drawing.Point(31, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 214);
            this.panel1.TabIndex = 9;
            // 
            // textGH2
            // 
            this.textGH2.Location = new System.Drawing.Point(449, 193);
            this.textGH2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textGH2.Name = "textGH2";
            this.textGH2.Size = new System.Drawing.Size(51, 21);
            this.textGH2.TabIndex = 26;
            this.textGH2.Text = "25";
            // 
            // textGH1
            // 
            this.textGH1.Location = new System.Drawing.Point(295, 193);
            this.textGH1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textGH1.Name = "textGH1";
            this.textGH1.Size = new System.Drawing.Size(51, 21);
            this.textGH1.TabIndex = 25;
            this.textGH1.Text = "25";
            // 
            // txtZXPrice1
            // 
            this.txtZXPrice1.Location = new System.Drawing.Point(497, 160);
            this.txtZXPrice1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZXPrice1.Name = "txtZXPrice1";
            this.txtZXPrice1.Size = new System.Drawing.Size(39, 21);
            this.txtZXPrice1.TabIndex = 24;
            this.txtZXPrice1.Text = "25";
            // 
            // txtDate1
            // 
            this.txtDate1.Location = new System.Drawing.Point(416, 160);
            this.txtDate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(74, 21);
            this.txtDate1.TabIndex = 23;
            this.txtDate1.Text = "2017-05-27";
            // 
            // txtCc1
            // 
            this.txtCc1.Location = new System.Drawing.Point(493, 127);
            this.txtCc1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCc1.Name = "txtCc1";
            this.txtCc1.Size = new System.Drawing.Size(51, 21);
            this.txtCc1.TabIndex = 22;
            this.txtCc1.Text = "K1109";
            // 
            // txtEndStation1
            // 
            this.txtEndStation1.Location = new System.Drawing.Point(423, 127);
            this.txtEndStation1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndStation1.Name = "txtEndStation1";
            this.txtEndStation1.Size = new System.Drawing.Size(67, 21);
            this.txtEndStation1.TabIndex = 21;
            this.txtEndStation1.Text = "新桥机场";
            // 
            // txtZXPrice
            // 
            this.txtZXPrice.Location = new System.Drawing.Point(306, 157);
            this.txtZXPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZXPrice.Name = "txtZXPrice";
            this.txtZXPrice.Size = new System.Drawing.Size(51, 21);
            this.txtZXPrice.TabIndex = 18;
            this.txtZXPrice.Text = "25";
            // 
            // txtKPLX
            // 
            this.txtKPLX.Location = new System.Drawing.Point(229, 157);
            this.txtKPLX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKPLX.Name = "txtKPLX";
            this.txtKPLX.Size = new System.Drawing.Size(51, 21);
            this.txtKPLX.TabIndex = 17;
            this.txtKPLX.Text = "合客";
            // 
            // txtZFPrice
            // 
            this.txtZFPrice.Location = new System.Drawing.Point(138, 157);
            this.txtZFPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZFPrice.Name = "txtZFPrice";
            this.txtZFPrice.Size = new System.Drawing.Size(67, 21);
            this.txtZFPrice.TabIndex = 16;
            this.txtZFPrice.Text = "25";
            // 
            // txtCLLX
            // 
            this.txtCLLX.Location = new System.Drawing.Point(59, 157);
            this.txtCLLX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCLLX.Name = "txtCLLX";
            this.txtCLLX.Size = new System.Drawing.Size(61, 21);
            this.txtCLLX.TabIndex = 15;
            this.txtCLLX.Text = "机场快线";
            // 
            // txtZWH
            // 
            this.txtZWH.Location = new System.Drawing.Point(335, 127);
            this.txtZWH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZWH.Name = "txtZWH";
            this.txtZWH.Size = new System.Drawing.Size(51, 21);
            this.txtZWH.TabIndex = 15;
            this.txtZWH.Text = "/";
            // 
            // txtJPK
            // 
            this.txtJPK.Location = new System.Drawing.Point(282, 127);
            this.txtJPK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJPK.Name = "txtJPK";
            this.txtJPK.Size = new System.Drawing.Size(51, 21);
            this.txtJPK.TabIndex = 14;
            this.txtJPK.Text = "/";
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(229, 127);
            this.txtCc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(50, 21);
            this.txtCc.TabIndex = 13;
            this.txtCc.Text = "K1109";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(138, 127);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(89, 21);
            this.txtDateTime.TabIndex = 12;
            this.txtDateTime.Text = "08:30";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(46, 127);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(83, 21);
            this.txtDate.TabIndex = 11;
            this.txtDate.Text = "2017-05-27";
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(87, 95);
            this.txtPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(289, 21);
            this.txtPerson.TabIndex = 10;
            this.txtPerson.Text = "吴培德 341226198609015****";
            // 
            // txtEndStation
            // 
            this.txtEndStation.Location = new System.Drawing.Point(255, 74);
            this.txtEndStation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndStation.Name = "txtEndStation";
            this.txtEndStation.Size = new System.Drawing.Size(68, 21);
            this.txtEndStation.TabIndex = 10;
            this.txtEndStation.Text = "新桥机场";
            // 
            // txtStartStation
            // 
            this.txtStartStation.Location = new System.Drawing.Point(77, 75);
            this.txtStartStation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(68, 21);
            this.txtStartStation.TabIndex = 0;
            this.txtStartStation.Text = "合肥火车站";
            // 
            // DaYin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(748, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(763, 561);
            this.Name = "DaYin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印车票";
            this.Load += new System.EventHandler(this.DaYin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtZXPrice1;
        private System.Windows.Forms.TextBox txtDate1;
        private System.Windows.Forms.TextBox txtCc1;
        private System.Windows.Forms.TextBox txtEndStation1;
        private System.Windows.Forms.TextBox txtGH2;
        private System.Windows.Forms.TextBox txtGH1;
        private System.Windows.Forms.TextBox txtZXPrice;
        private System.Windows.Forms.TextBox txtKPLX;
        private System.Windows.Forms.TextBox txtZFPrice;
        private System.Windows.Forms.TextBox txtCLLX;
        private System.Windows.Forms.TextBox txtZWH;
        private System.Windows.Forms.TextBox txtJPK;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtEndStation;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.TextBox textGH2;
        private System.Windows.Forms.TextBox textGH1;
    }
}