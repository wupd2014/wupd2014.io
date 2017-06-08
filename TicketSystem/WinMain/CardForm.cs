using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Model;
using System.Configuration;
using Common;
using BLL;
using MaterialSkin.Controls;
using System.Threading;
using System.Threading.Tasks;

namespace WinMain
{
    public partial class CardForm : MaterialForm
    {
        Card.PERSONINFOW person;
        string birthday = "";
        string validDate = "";
        Image image = null;
        private TicketOrder ticketOrder;
        public List<Card.PERSONINFOW> list = new List<Card.PERSONINFOW>();

        public CardForm()
        {
            InitializeComponent();
            //Init();

        }

        public CardForm(TicketOrder ticketOrder)
        {
            // TODO: Complete member initialization
            this.ticketOrder = ticketOrder;
            InitializeComponent();
            person = new Card.PERSONINFOW();
        }



        void SetRect(ref RectangleF rect, float x, float y, float width, float height)
        {
            rect.X = x;
            rect.Y = y;
            rect.Width = width;
            rect.Height = height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Font font = new Font("宋体", 12, FontStyle.Regular);
            Brush brush = new SolidBrush(Color.FromArgb(192, 128, 128));
            RectangleF rect = new RectangleF();
            SetRect(ref rect, 10, 70, 90, 16);
            g.DrawString("姓名", font, brush, rect);
            SetRect(ref rect, 10, 90, 90, 16);
            g.DrawString("性别", font, brush, rect);
            SetRect(ref rect, 10, 110, 90, 16);
            g.DrawString("民族", font, brush, rect);
            SetRect(ref rect, 10, 130, 90, 16);
            g.DrawString("出生日期", font, brush, rect);
            SetRect(ref rect, 10, 150, 90, 16);
            g.DrawString("地址", font, brush, rect);
            SetRect(ref rect, 10, 190, 90, 16);
            g.DrawString("身份证号码", font, brush, rect);
            SetRect(ref rect, 10, 210, 90, 16);
            g.DrawString("签发机关", font, brush, rect);
            SetRect(ref rect, 10, 230, 90, 16);
            g.DrawString("有效期限", font, brush, rect);
            brush.Dispose();

            if (person.name != null)
            {
                brush = new SolidBrush(Color.Black);
                SetRect(ref rect, 100, 70, 300, 16);
                g.DrawString(person.name, font, brush, rect);
                SetRect(ref rect, 100, 90, 100, 16);
                g.DrawString(person.sex, font, brush, rect);
                SetRect(ref rect, 100, 110, 150, 16);
                g.DrawString(person.nation, font, brush, rect);
                SetRect(ref rect, 100, 130, 300, 16);
                g.DrawString(birthday, font, brush, rect);
                SetRect(ref rect, 100, 150, 300, 34);
                g.DrawString(person.address, font, brush, rect);
                SetRect(ref rect, 100, 190, 300, 16);
                g.DrawString(person.cardId, font, brush, rect);
                SetRect(ref rect, 100, 210, 300, 16);
                g.DrawString(person.police, font, brush, rect);
                SetRect(ref rect, 100, 230, 300, 16);
                g.DrawString(validDate, font, brush, rect);
                brush.Dispose();
            }
            font.Dispose();
            if (image != null)
                g.DrawImage(image, 400, 70);
            // g.Dispose();
        }

        string ConvertDate(string str, int mode)
        {
            string year;
            string month;
            string day;
            if (1 == mode)
            {
                if (str.Length >= 8)
                {
                    year = str.Substring(0, 4);
                    month = str.Substring(4, 2);
                    day = str.Substring(6, 2);
                    return string.Format("{0}年{1}月{2}日", year, month, day);
                }
            }
            else if (2 == mode)
            {
                if (str.Equals("长期"))
                {
                    return "长期";
                }
                else
                {
                    if (str.Length >= 8)
                    {
                        year = str.Substring(0, 4);
                        month = str.Substring(4, 2);
                        day = str.Substring(6, 2);
                        return string.Format("{0}.{1}.{2}", year, month, day);
                    }
                }
            }
            return "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ReadCard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textName.Text.Trim()) && string.IsNullOrEmpty(this.textIDCard.Text.Trim()))
            {
                this.lblValidationInfo.Visible = true;
                return;
            }
            /*方式一 弹出框进行打印*/
            DaYin DyForm = new DaYin(ticketOrder);
            DyForm.Show();

            //方式二 直接进行打印
            /*
                        Panel pnl = PanelInit();
                        PrintTicket priTic = new PrintTicket(pnl);
                        priTic.Print(pnl);

            */

            this.Dispose();
        }

        private Panel PanelInit()
        {
            Form dyform = new Form();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaYin));
            Panel panel1 = new Panel();
            panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Location = new System.Drawing.Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(892, 321);
            panel1.TabIndex = 9;
            dyform.Controls.Add(panel1);

            dyform.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            dyform.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            dyform.BackColor = System.Drawing.SystemColors.Control;
            dyform.ClientSize = new System.Drawing.Size(1122, 786);
            dyform.HelpButton = true;
            dyform.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            dyform.Margin = new System.Windows.Forms.Padding(4);
            dyform.MaximumSize = new System.Drawing.Size(1144, 842);
            dyform.Name = "DaYin";
            dyform.Text = "打印车票";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            dyform.ResumeLayout(false);

            return panel1;
        }
        private const int _Interval = 1000;
        private CardMonitorService _Timer;
        private void CardForm_Load(object sender, EventArgs e)
        {
            //Init();
            _Timer = new CardMonitorService();
            _Timer.Interval = _Interval;
            _Timer.Start(); //开始
            _Timer.OnElapsed += Timer_OnElapsed;
        }

        private void Timer_OnElapsed()
        {
            String imagePath;
            imagePath = Path.GetTempPath() + "image.bmp";
            person = new Card.PERSONINFOW();
            if (image != null)
            {
                image.Dispose();
                image = null;
            }

            Invoke(new Action(() =>
            {
                // Console.WriteLine("1");
                CardMonitorService cms = new CardMonitorService();
                cms.ServiceStart(ref person, imagePath);
                if (!string.IsNullOrEmpty(person.cardId.Trim()))
                {
                    birthday = ConvertDate(person.birthday, 1);
                    validDate = ConvertDate(person.validStart, 2) + "-";
                    validDate += ConvertDate(person.validEnd, 2);
                    image = new Bitmap(imagePath);
                    textName.Text = person.name;
                    textIDCard.Text = person.cardId;
                    textName.Enabled = false;
                    textIDCard.Enabled = false;
                    //this.timer1.Enabled = false;
                    //CloseDevice();
                    //HasRead = true;

                    ticketOrder.BuyerIDCard = person.cardId;
                    ticketOrder.BuyerName = person.name;

                    LogHelper.WriteLog(typeof(CardForm), "读卡成功");
                    list.Add(person);
                }
                else
                {
                    LogHelper.WriteLog(typeof(CardForm), "读卡失败");

                    birthday = "";
                    validDate = "";
                    person.name = "";
                    person.sex = "";
                    person.nation = "";
                    person.birthday = "";
                    person.address = "";
                    person.cardId = "";
                    person.police = "";
                    person.validStart = "";
                    person.validEnd = "";
                    person.sexCode = "";
                    person.nationCode = "";
                    person.appendMsg = "";
                }
                Invalidate();
            }));

        }

        private void CardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_Timer != null)
            {
                _Timer.OnElapsed -= Timer_OnElapsed;
                _Timer.Stop();

            }
        }


    }



}
