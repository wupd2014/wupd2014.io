using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace WinMain
{
    public partial class Form3 : PrintPreviewDialog
    {
        //作为正式打印标志
        private bool is_Print;
        private Model.TicketOrder ticketOrder;

        public Form3(Model.TicketOrder ticketOrder)
        {
            // TODO: Complete member initialization
            this.ticketOrder = ticketOrder;
        }



        public Form3()
        {
            // TODO: Complete member initialization
        }
        public bool isPrint
        {
            get { return is_Print; }
            set { is_Print = value; }
        }
        public void Add()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(ToolStrip))
                {
                    ToolStrip ts = c as ToolStrip;

                    /* ToolStripButton page_setup = new ToolStripButton("页面设置");
                     page_setup.Size = new Size(23, 22);
                     page_setup.ImageTransparentColor = System.Drawing.Color.Magenta;
                     ts.Items.Insert(0, page_setup);
                     ts.Items[0].Click += new System.EventHandler(page_setup_Click);//添加对应按钮的单击是事件

                     ToolStripButton print_setup = new ToolStripButton("打印机设置");
                     Bitmap back_bmp = new Bitmap(打印合格证.Properties.Resources.print_driver1);//调用资源文件图片
                     print_setup.Image = back_bmp;
                     print_setup.DisplayStyle = ToolStripItemDisplayStyle.Image;
                     print_setup.Size = new Size(23, 22);
                     print_setup.ImageTransparentColor = System.Drawing.Color.Magenta;
                     ts.Items.Insert(1, print_setup);
                     ts.Items[1].Click += new System.EventHandler(print_setup_Click);//添加对应按钮的单击是事件
                     */
                    ToolStripButton my_setup = new ToolStripButton("打印");
                    my_setup.Size = new Size(23, 22);
                    my_setup.ImageTransparentColor = System.Drawing.Color.Magenta;
                    ts.Items.Insert(2, my_setup);
                    ts.Items[2].Click += new System.EventHandler(my_setup_Click);//添加对应按钮的单击是事件 
                }
            }
        }
        private void my_setup_Click(object sender, EventArgs e)
        {
            is_Print = true;//说明是正式打印，用于通知printDocument1_PrintPage哪些打印，哪些只是预览

            using (PrintDialog diag = new PrintDialog())
            {
                diag.Document = base.Document;//base 关键字用于从派生类中访问基类的成员：调用基类上已被其他方法重写的方法。
                //diag.Document.DefaultPageSettings.PaperSize = new PaperSize("Custum", 820, 1151);
                //diag.Document.DefaultPageSettings.PaperSize = new PaperSize("Custum", 612, 842);


                if (diag.ShowDialog() == DialogResult.OK)
                {


                    this.Document.Print();
                }
            }

        }

        private void page_setup_Click(object sender, EventArgs e)
        {
            using (PageSetupDialog psd = new PageSetupDialog())
            {

                psd.Document = base.Document;
                if (psd.ShowDialog() == DialogResult.OK)
                {
                    is_Print = false;
                    this.PrintPreviewControl.InvalidatePreview();//刷新预览内容
                }
            }
        }

        private void print_setup_Click(object sender, EventArgs e)
        {

            using (PrintDialog diag = new PrintDialog())
            {
                diag.Document = base.Document;//base 关键字用于从派生类中访问基类的成员：调用基类上已被其他方法重写的方法。
                //diag.Document.DefaultPageSettings.PaperSize = new PaperSize("Custum", 612, 842);


                if (diag.ShowDialog() == DialogResult.OK)
                {
                    is_Print = false;

                    this.PrintPreviewControl.InvalidatePreview();//刷新预览内容                    
                }
            }


        }

        public void Del()
        {
            int bnt = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(ToolStrip))
                {
                    ToolStrip ts = c as ToolStrip;
                    ts.Items.RemoveAt(bnt);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "打印预览";
            this.Icon = WinMain.Properties.Resources.print_driver1;
        }





    }
}
