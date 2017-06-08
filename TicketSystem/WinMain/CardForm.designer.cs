namespace WinMain
{
    partial class CardForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (image != null)
            {
                image.Dispose();
                image = null;
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValidationInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textIDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.xx = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValidationInfo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textIDCard);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.xx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 261);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(514, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入身份证信息";
            // 
            // lblValidationInfo
            // 
            this.lblValidationInfo.AutoSize = true;
            this.lblValidationInfo.ForeColor = System.Drawing.Color.Red;
            this.lblValidationInfo.Location = new System.Drawing.Point(213, 66);
            this.lblValidationInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidationInfo.Name = "lblValidationInfo";
            this.lblValidationInfo.Size = new System.Drawing.Size(101, 12);
            this.lblValidationInfo.TabIndex = 20;
            this.lblValidationInfo.Text = "请验二代身份证！";
            this.lblValidationInfo.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "打印车票";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textIDCard
            // 
            this.textIDCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textIDCard.Location = new System.Drawing.Point(273, 26);
            this.textIDCard.Name = "textIDCard";
            this.textIDCard.Size = new System.Drawing.Size(185, 21);
            this.textIDCard.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "身份证号：";
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textName.Location = new System.Drawing.Point(83, 26);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(102, 21);
            this.textName.TabIndex = 16;
            // 
            // xx
            // 
            this.xx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xx.AutoSize = true;
            this.xx.Location = new System.Drawing.Point(37, 28);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(41, 12);
            this.xx.TabIndex = 15;
            this.xx.Text = "姓名：";
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(514, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二代身份证识别";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardForm_FormClosed);
            this.Load += new System.EventHandler(this.CardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textIDCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label xx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblValidationInfo;
    }
}

