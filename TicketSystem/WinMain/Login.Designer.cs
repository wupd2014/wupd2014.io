namespace WinMain
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblUserNameTip = new System.Windows.Forms.Label();
            this.lblPassWordTips = new System.Windows.Forms.Label();
            this.lblLoginResult = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(122, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(122, 116);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(100, 21);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(86, 167);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(63, 29);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "登录";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // lblUserNameTip
            // 
            this.lblUserNameTip.AutoSize = true;
            this.lblUserNameTip.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameTip.Location = new System.Drawing.Point(231, 45);
            this.lblUserNameTip.Name = "lblUserNameTip";
            this.lblUserNameTip.Size = new System.Drawing.Size(0, 12);
            this.lblUserNameTip.TabIndex = 5;
            // 
            // lblPassWordTips
            // 
            this.lblPassWordTips.AutoSize = true;
            this.lblPassWordTips.ForeColor = System.Drawing.Color.Red;
            this.lblPassWordTips.Location = new System.Drawing.Point(228, 86);
            this.lblPassWordTips.Name = "lblPassWordTips";
            this.lblPassWordTips.Size = new System.Drawing.Size(0, 12);
            this.lblPassWordTips.TabIndex = 6;
            // 
            // lblLoginResult
            // 
            this.lblLoginResult.AutoSize = true;
            this.lblLoginResult.ForeColor = System.Drawing.Color.Red;
            this.lblLoginResult.Location = new System.Drawing.Point(122, 144);
            this.lblLoginResult.Name = "lblLoginResult";
            this.lblLoginResult.Size = new System.Drawing.Size(113, 12);
            this.lblLoginResult.TabIndex = 7;
            this.lblLoginResult.Text = "用户名或密码错误！";
            this.lblLoginResult.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 228);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLoginResult);
            this.Controls.Add(this.lblPassWordTips);
            this.Controls.Add(this.lblUserNameTip);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblUserNameTip;
        private System.Windows.Forms.Label lblPassWordTips;
        private System.Windows.Forms.Label lblLoginResult;
        private System.Windows.Forms.Button btnCancel;
    }
}