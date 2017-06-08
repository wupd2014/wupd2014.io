using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class PrintTicket
    {
        int x = Convert.ToInt32(ConfigurationManager.AppSettings["x"].ToString());
        int y = Convert.ToInt32(ConfigurationManager.AppSettings["y"].ToString());
        PrintDocument pdoc = null;
        private Panel panel1;
        public PrintTicket(Panel panel)
        {
            this.panel1 = panel;
        }
        public void Print(Panel panel1)
        {

            pdoc = new PrintDocument();
            PrintDialog pd = new PrintDialog();
            pd.Document = pdoc;
            /* PrinterSettings ps = new PrinterSettings();
             Font font = new Font("Courier New", 15);
             PaperSize psize = new PaperSize("Custom", 100, 200);
             pd.Document.DefaultPageSettings.PaperSize = psize;
             pdoc.DefaultPageSettings.PaperSize.Height = 820;
             pdoc.DefaultPageSettings.PaperSize.Width = 520;*/

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                /*PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();*/
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }
        }

        private void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("宋体", 12, GraphicsUnit.Pixel);
            Brush bru = Brushes.Black;
            Image bitmap = new Bitmap(panel1.BackgroundImage, panel1.Width, panel1.Height);
            Graphics g = e.Graphics;  //先建立画布


            List<Ticket> list = new List<Ticket>();

            list.Add(new Ticket
            {
                Cc = "K1008",
                CLLX = "高速快客1",
                FaCheRiQi = DateTime.Now,
                GH = "A108",
                JPK = "1号窗口",
                KPLX = "长途客票",
                TicketPassengerCardID = "34122619860901****",
                ZXPrice = "25",
                TicketStartTime = DateTime.Now,
                ZWH = "15号",
                ZFPrice = "25",
                TicketStartStation = "合肥火车站",
                TicketEndStation = "新桥机场"
            });
            list.Add(new Ticket
            {
                Cc = "K1008",
                CLLX = "高速快客1",
                FaCheRiQi = DateTime.Now,
                GH = "A108",
                JPK = "1号窗口",
                KPLX = "长途客票",
                TicketPassengerCardID = "34122619860901****",
                ZXPrice = "25",
                TicketStartTime = DateTime.Now,
                ZWH = "15号",
                ZFPrice = "25",
                TicketStartStation = "客运中心战",
                TicketEndStation = "新桥机场"
            });
            for (int i = 0; i < list.Count; i++)
            {
                int ny = panel1.Height * i + y;
                g.DrawImage(bitmap, x, ny, panel1.Width, panel1.Height);
                g.DrawString(list[i].GH, font, bru, 449, 193 + ny); //工号
                g.DrawString(list[i].GH, font, bru, 295, 193 + ny);
                g.DrawString(list[i].ZFPrice, font, bru, 497, 160 + ny);
                g.DrawString(list[i].CLLX, font, bru, 493, 127 + ny);
                g.DrawString(list[i].TicketEndStation, font, bru, 423, 127 + ny);
                g.DrawString(list[i].ZXPrice, font, bru, 306, 157 + ny);
                g.DrawString(list[i].KPLX, font, bru, 229, 157 + ny);
                g.DrawString(list[i].TicketPrice, font, bru, 138, 157 + ny);
                g.DrawString(list[i].CLLX, font, bru, 59, 157 + ny);
                g.DrawString(list[i].ZWH, font, bru, 335, 127 + ny);
                g.DrawString(list[i].JPK, font, bru, 282, 127 + ny);
                g.DrawString(list[i].Cc, font, bru, 229, 127 + ny);
                g.DrawString(list[i].TicketStartTime.ToString("yyyy-MM-dd"), font, bru, 138, 127 + ny); //发车时间
                g.DrawString(list[i].FaCheRiQi.ToString("yyyy-MM-dd"), font, bru, 46, 127 + ny);//发车日期 左
                g.DrawString(list[i].FaCheRiQi.ToString("yyyy-MM-dd"), font, bru, 416, 160 + ny);//发车日期 右
                g.DrawString(list[i].TicketPassengerCardID, font, bru, 87, 95 + ny);
                g.DrawString(list[i].TicketEndStation, font, bru, 255, 74 + ny);
                g.DrawString(list[i].TicketStartStation, font, bru, 77, 75 + ny);
            }

            /* string str = "";
             foreach (Control item in panel1.Controls)
             {
                 if (item is TextBox)
                 {

                     Control tx = (item as Control);
                     //str += tx.Name + "-" + tx.Left + "-" + tx.Top + "\n";
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
             }*/


            font.Dispose();
            g.Dispose();
        }

        public void PreView(System.Windows.Forms.Panel panel)
        {
            pdoc = new PrintDocument();
            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
            PrintPreviewDialog pp = new PrintPreviewDialog();

            //最大化
            pp.PrintPreviewControl.AutoZoom = false;
            pp.PrintPreviewControl.Zoom = 1;
            ((Form)pp).WindowState = FormWindowState.Maximized;

            pp.Document = pdoc;
            pp.ShowDialog();
        }
    }

}
