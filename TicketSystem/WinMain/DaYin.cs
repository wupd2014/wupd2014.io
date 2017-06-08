using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Configuration;
using BLL;
using MaterialSkin.Controls;
using Common;

namespace WinMain
{
    public partial class DaYin : MaterialForm
    {
        private Model.TicketOrder ticketOrder;

        public DaYin()
        {
            InitializeComponent();//实例化控件

            Skin.SetSkin(this);
            this.printDialog1.Document = this.printDocument1;//必要的 
            this.printPreviewDialog1.Document = this.printDocument1;
            this.pageSetupDialog1.Document = this.printDocument1;
        }

        public DaYin(Model.TicketOrder ticketOrder)
        {
            // TODO: Complete member initialization
            InitializeComponent();//实例化控件
            this.ticketOrder = ticketOrder;
            this.printDialog1.Document = this.printDocument1;//必要的 
            this.printPreviewDialog1.Document = this.printDocument1;
            this.pageSetupDialog1.Document = this.printDocument1;
            Skin.SetSkin(this);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ////注意指定其Document(获取或设置要预览的文档)属性
            //this.printPreviewDialog1.Document = this.printDocument1;
            ////ShowDialog方法：将窗体显示为模式对话框，并将当前活动窗口设置为它的所有者
            //this.printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
            ////将打印按钮重新设置
            //ToolStrip tool = this.printPreviewDialog1.Controls["toolStrip1"] as ToolStrip;
            //if (tool != null)
            //{
            //    int indexPrint = tool.Items.IndexOfKey("printToolStripButton");
            //    if (indexPrint != -1)
            //    {
            //        tool.Items[indexPrint].Visible = false;
            //    }
            //}
            //this.printPreviewDialog1.ShowDialog();

            PrintTicket priTic = new PrintTicket(this.panel1);
            priTic.PreView(this.panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*PrintDialog pdia = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            pdoc.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            if (pdia.ShowDialog() == DialogResult.OK)
            {
                pdoc.Print();
            }*/
            PrintTicket priTic = new PrintTicket(this.panel1);
            priTic.Print(this.panel1);
        }

        /*  int x = Convert.ToInt32(ConfigurationManager.AppSettings["x"].ToString());
          int y = Convert.ToInt32(ConfigurationManager.AppSettings["y"].ToString());
          private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
          {
              Font font = new Font("宋体", 10);
              Brush bru = Brushes.Black;
              Image bitmap = new Bitmap(panel1.BackgroundImage, panel1.Width, panel1.Height);
              Graphics g = e.Graphics;  //先建立画布
              g.DrawImage(bitmap, 0, 0, panel1.Width, panel1.Height);

              foreach (Control item in panel1.Controls)
              {
                  if (item is TextBox)
                  {
                      Control tx = (item as Control);
                      g.DrawString(tx.Text, font, bru, tx.Left + x, tx.Top + y);
                  }
              }

              y = panel1.Height;
              g.DrawImage(bitmap, 0, panel1.Height, panel1.Width, panel1.Height);
              foreach (Control item in panel1.Controls)
              {
                  if (item is TextBox)
                  {
                      Control tx = (item as Control);
                      g.DrawString(tx.Text, font, bru, tx.Left + x, tx.Top + y);
                  }
              }

          }*/

        /*private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("宋体", 12);
            Brush bru = Brushes.Black;
            Graphics g = e.Graphics;  //先建立画布

            g.DrawImage(panel1.BackgroundImage, 0, 0, panel1.Width, panel1.Height);
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    Control tx = (item as Control);
                    //g.DrawString(tx.Text, font, bru, tx.Left + x, tx.Top + y);
                }
            }
        }*/

        private void DaYin_Load(object sender, EventArgs e)
        {

            //Graphics g = e.Graphics;

        }



    }
}
