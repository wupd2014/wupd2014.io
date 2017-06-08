using Common;
using MaterialSkin;
using MaterialSkin.Controls;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMain
{
    public partial class Login : MaterialForm
    {
        public static User CurrentUser = new User();
        public TicketOrder ticketOrder = new TicketOrder();
        public Login()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            Skin.SetSkin(this);



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidateUser();
            //this.Close();
        }

        private void ValidateUser()
        {
            string UserName = this.txtUserName.Text.Trim();
            string PassWord = this.txtPassWord.Text.Trim();
            if (string.IsNullOrWhiteSpace(UserName))
            {
                this.lblUserNameTip.Text = "请输入用户名！";
                this.lblUserNameTip.Visible = true;
                this.lblUserNameTip.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(PassWord))
            {
                this.lblPassWordTips.Text = "请输入密码！";
                this.lblPassWordTips.Visible = true;
                this.lblPassWordTips.Focus();
                return;
            }
            if (UserName == "admin" && PassWord == "admin")
            {
                //MessageUtil.ShowTips("登录成功！");
                CurrentUser.UserName = "admin";
                CurrentUser.PassWord = "admin";
                ticketOrder.SellerName = "admin";
                this.txtUserName.Text = "";
                this.txtPassWord.Text = "";
                this.txtUserName.Focus();


                if (Application.OpenForms["Main"] == null)
                {
                   // this.Hide();
                    MainNew main = new MainNew(CurrentUser);
                   // main.CurrentUser = CurrentUser;
                    main.Show();
                }
                else
                {
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Visible == true)
                            item.Hide();
                        else
                            item.Show();
                    }
                }
            }
            else
            {
                lblLoginResult.Visible = true;
                return;
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.btnSubmit_Click(sender, e);//触发button事件
            }
        }

        private void ChangeTips(object sender, EventArgs e)
        {
            this.lblLoginResult.Visible = false;
            this.lblPassWordTips.Visible = false;
            this.lblUserNameTip.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.skinEngine1.SkinFile = @"\RealOne.ssk";
            this.txtPassWord.TextChanged += ChangeTips;
            this.txtUserName.TextChanged += ChangeTips;
            this.Icon = WinMain.Properties.Resources.print_driver1;
        }
    }
}
