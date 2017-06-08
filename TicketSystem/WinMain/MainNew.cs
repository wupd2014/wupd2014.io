using Common;
using MaterialSkin;
using MaterialSkin.Controls;
using Model;
using NPinyin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinMain
{
    public partial class MainNew : MaterialForm
    {
        #region Fields
        Dictionary<string, string> tabMap = new Dictionary<string, string>();
        public string weekstr = string.Empty;
        public User CurrentUser { get; set; }
        #endregion

        #region MainNew() Main(Model.User CurrentUser) 构造函数
        public MainNew()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            Skin.SetSkin(this);
        }

        public MainNew(Model.User CurrentUser)
        {
            // TODO: Complete member initialization
            this.CurrentUser = CurrentUser;
            InitializeComponent();
            // Initialize MaterialSkinManager
            Skin.SetSkin(this);
        }
        #endregion

        #region timer1_Tick(object sender, EventArgs e) 时间自动更新

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss") + " " + weekstr;
        }
        #endregion

        #region Main_Load(object sender, EventArgs e)  初始化界面
        private void Main_Load(object sender, EventArgs e)
        {

            this.txtTicketNo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            this.timer1.Start();
            //把得到的星期转换成中文
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": weekstr = "星期一"; break;
                case "Tuesday": weekstr = "星期二"; break;
                case "Wednesday": weekstr = "星期三"; break;
                case "Thursday": weekstr = "星期四"; break;
                case "Friday": weekstr = "星期五"; break;
                case "Saturday": weekstr = "星期六"; break;
                case "Sunday": weekstr = "星期日"; break;
            }
            //列表
            BindData(null, null);
            //默认出发站
            this.txtStartStation.Text = System.Configuration.ConfigurationManager.AppSettings["DefaultStation"].ToString();
            //自动计算
            this.txtFullCount.TextChanged += new System.EventHandler(this.Cal);
            this.txtYHCount.TextChanged += new System.EventHandler(this.Cal);
            this.txtPayMoney.TextChanged += new System.EventHandler(this.Cal);
            this.txtPreDay.TextChanged += new System.EventHandler(this.BindData);
            this.txtEndStation.TextChanged += new System.EventHandler(this.BindData);
            this.txtStartStation.TextChanged += new System.EventHandler(this.BindData);

            InitTabMap();

            //光标定位
            txtEndStation.Focus();

            //  
            this.txtEndStation.AutoCompleteCustomSource.AddRange(new string[] { "中心站1", "中心站2", "中心站3", "中心站4", "机场1", "机场2", "机场3", "机场4" });

            //
            TextBoxSelectAll();
            groupBox1.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            groupBox2.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            groupBox3.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            groupBox2.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - groupBox2.Height - groupBox2.Height;


            dgvMain.Width = Convert.ToInt32(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - 2);
            dgvMain.Height = groupBox2.Height;

            //
            btnDaYin.MouseState = MouseState.DOWN;

        }

        private void TextBoxSelectAll()
        {
            TextBoxEvent evnt = new TextBoxEvent();
            txtRQ.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            txtTicketNo.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            lblCurrentTime.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            lblCurrentTime.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            txtRQ.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            txtEndStation.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            txtPreDay.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            txtStartStation.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            txtFullCount.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            txtYHCount.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            txtPayMoney.GotFocus += new EventHandler(evnt.textBox_GotFocus);
            btnDaYin.GotFocus += new EventHandler(evnt.textBox_GotFocus);

            txtRQ.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            txtTicketNo.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            lblCurrentTime.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            lblCurrentTime.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            txtRQ.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            txtEndStation.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            txtPreDay.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            txtStartStation.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            txtFullCount.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            txtYHCount.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            txtPayMoney.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
            btnDaYin.MouseUp += new MouseEventHandler(evnt.textBox_MouseUp);
        }



        #endregion

        #region InitTabMap() Tab顺序初始化
        private void InitTabMap()
        {
            Dictionary<string, string> tmp = new Dictionary<string, string>();
            XmlDocument doc = new XmlDocument();
            doc.Load("TabOrder.xml");
            XmlNodeList list = doc.SelectSingleNode("Dics").ChildNodes;

            foreach (XmlNode node in list)
            {
                tabMap.Add(node.Attributes["FROM"].Value, node.Attributes["TO"].Value);
            }
        }
        #endregion

        #region  BindData(object sender, EventArgs e) 数据绑定
        private void BindData(object sender, EventArgs e)
        {
            string PreDays = string.IsNullOrEmpty(this.txtPreDay.Text.Trim()) ? "0" : this.txtPreDay.Text.Trim();
            txtRQ.Text = DateTime.Now.AddDays(Convert.ToInt32(PreDays)).ToString("MM-dd");
            //使用List<>泛型集合填充DataGridView  
            List<Ticket> ticList = new List<Ticket>() { };
            List<Ticket> ticListFilter = new List<Ticket>() { };

            ticList.AddRange(new List<Ticket> { 
 new Ticket { LineNo = "1号线", TicketStartStation = "中心站1", TicketEndStation = "机场1", TicketStartTime = Convert.ToDateTime("15:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "2号线", TicketStartStation = "中心站2", TicketEndStation = "机场2", TicketStartTime = Convert.ToDateTime("15:56"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "中心站3", TicketEndStation = "机场3", TicketStartTime = Convert.ToDateTime("17:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "4号线", TicketStartStation = "中心站4", TicketEndStation = "机场1", TicketStartTime = Convert.ToDateTime("15:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "5号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场2", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "1号线", TicketStartStation = "火车站2", TicketEndStation = "新桥机场3", TicketStartTime = Convert.ToDateTime("10:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "2号线", TicketStartStation = "火车站3", TicketEndStation = "新桥机场1", TicketStartTime = Convert.ToDateTime("11:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站4", TicketEndStation = "新桥机场2", TicketStartTime = Convert.ToDateTime("23:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "4号线", TicketStartStation = "火车站5", TicketEndStation = "新桥机场3", TicketStartTime = Convert.ToDateTime("12:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "5号线", TicketStartStation = "火车站4", TicketEndStation = "新桥机场4", TicketStartTime = Convert.ToDateTime("23:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "1号线", TicketStartStation = "火车站3", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("03:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "2号线", TicketStartStation = "火车站2", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("05:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},
 new Ticket { LineNo = "3号线", TicketStartStation = "火车站1", TicketEndStation = "新桥机场", TicketStartTime = Convert.ToDateTime("09:34"),LicenseCardID="晥A33456",TicketPrice="25"},

          });
            Encoding gb2312 = Encoding.GetEncoding("GB2312");


            ticListFilter = (from tic in ticList
                             where (tic.TicketEndStation.Contains(this.txtEndStation.Text.Trim()) ||
                                    Pinyin.GetInitials(Pinyin.ConvertEncoding(tic.TicketEndStation, Encoding.UTF8, gb2312), gb2312).Contains(txtEndStation.Text.ToUpper()))
                                    && (tic.TicketStartStation.Contains(this.txtStartStation.Text.Trim()))
                             select tic).ToList<Ticket>();

            this.dgvMain.DataSource = ticListFilter;

            this.dgvMain.Columns["TicketNo"].Visible = false;
            this.dgvMain.Columns["TicketID"].Visible = false;
            this.dgvMain.Columns["discount"].Visible = false;
            this.dgvMain.Columns["TicketBuyerCardID"].Visible = false;
            this.dgvMain.Columns["TicketPassengerCardID"].Visible = false;
            this.dgvMain.Columns["TicketEndTime"].Visible = false;
            this.dgvMain.Columns["FaCheRiQi"].Visible = false;
            this.dgvMain.Columns["Cc"].Visible = false;
            this.dgvMain.Columns["JPK"].Visible = false;
            this.dgvMain.Columns["ZWH"].Visible = false;
            this.dgvMain.Columns["CLLX"].Visible = false;
            this.dgvMain.Columns["ZFPrice"].Visible = false;
            this.dgvMain.Columns["KPLX"].Visible = false;
            this.dgvMain.Columns["ZXPrice"].Visible = false;
            this.dgvMain.Columns["GH"].Visible = false;

            this.dgvMain.Columns["TicketStartStation"].HeaderCell.Value = "出发站";
            this.dgvMain.Columns["TicketEndStation"].HeaderCell.Value = "到达站";
            this.dgvMain.Columns["TicketStartTime"].HeaderCell.Value = "发车时间";
            this.dgvMain.Columns["TicketPrice"].HeaderCell.Value = "满额票价";
            this.dgvMain.Columns["LineNo"].HeaderCell.Value = "线路";
            this.dgvMain.Columns["LicenseCardID"].HeaderCell.Value = "车牌号";

            if (this.dgvMain.Rows.Count > 0)
                this.dgvMain.Rows[0].Selected = true;
            Cal(null, null);
        }
        #endregion

        #region dgvMain_CellClick(object sender, DataGridViewCellEventArgs e) 单击单元格选中一整行
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dgvMain.Rows[e.RowIndex].Selected = true;
            }
            this.Cal(null, null);
        }
        #endregion

        #region  txtEndStation_TextChanged(object sender, EventArgs e) 根据到达站查询班次
        private void txtEndStation_TextChanged(object sender, EventArgs e)
        {
            BindData(null, null);
        }
        #endregion

        #region Cal(object sender, EventArgs e)  计算购票费用 找零等
        private void Cal(object sender, EventArgs e)
        {
            //校验数据正确性
            string tFullCount = this.txtFullCount.Text.Trim();
            string tHalfCount = this.txtYHCount.Text.Trim();
            string tPayMoney = this.txtPayMoney.Text.Trim();
            if (!Validator.IsNumber(tFullCount))
            {
                StyleSet.SetErrorStyle(txtFullCount);
                return;
            }
            else
            {
                StyleSet.ClearErrorStyle(txtFullCount);
            }
            if (!Validator.IsNumber(tHalfCount))
            {
                StyleSet.SetErrorStyle(txtYHCount);
                return;
            }
            else
            {
                StyleSet.ClearErrorStyle(txtYHCount);
            }
            if (!Validator.CheckMoney(tPayMoney))
            {
                StyleSet.SetErrorStyle(txtPayMoney);
                return;
            }
            else
            {
                StyleSet.ClearErrorStyle(txtPayMoney);

            }

            double totalPrice = 0.00,
                    Price = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["DefaultPrice"].ToString()),
                    FullDisCount = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["FullDisCount"].ToString()),
                    YhDisCount = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["YhDisCount"].ToString());

            int total = 0,
                fullCount = Convert.ToInt32(tFullCount),
                YhCount = Convert.ToInt32(tHalfCount);

            totalPrice = fullCount * Price * FullDisCount + YhCount * Price * YhDisCount;
            total = fullCount + YhCount;

            this.lblTicketTotalPrice.Text = totalPrice.ToString("0.00");

            //this.txtFullPrice.Text = (fullCount * Price * FullDisCount).ToString("0.00");
            //this.txtYHPrice.Text = (YhCount * Price * YhDisCount).ToString("0.00");

            lblReturnMoney.Text = (Convert.ToDouble(string.IsNullOrWhiteSpace(txtPayMoney.Text.Trim()) ? "0" : txtPayMoney.Text.Trim()) - totalPrice).ToString("0.00");

            //乘车信息
            if (dgvMain.SelectedRows.Count > 0)
                ccInfo.Text = dgvMain.SelectedRows[0].Cells["TicketStartStation"].Value.ToString() +
                              "=>" + dgvMain.SelectedRows[0].Cells["TicketEndStation"].Value.ToString() +
                              "    时间：" + dgvMain.SelectedRows[0].Cells["TicketStartTime"].Value.ToString();
            else
                ccInfo.Text = "";
            //找零
            zhaoling.Text = lblReturnMoney.Text;
            //票数
            lblTicketCount.Text = total.ToString();

        }
        #endregion

        #region 快捷键
        /// <summary>
        /// 这个重载函数里可以预先捕捉到一些按键，比如被系统默认捕获了的Tab键
        /// 如果要改写Tab键的默认动作，要返回true，表示你已经处理过这个按键了
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        
        {


            Control ctl = this.ActiveControl;
            if (string.IsNullOrEmpty(ctl.Name))
                ctl = this.ActiveControl.Parent;
            if (keyData == Keys.Enter)
            {

                if (ctl != null && tabMap.Keys.Contains(ctl.Name))
                {
                    var toCtrls = this.Controls.Find(tabMap[ctl.Name], true);
                    if (toCtrls.Length > 0)
                    {
                        /* if (toCtrls[0].Text == "打印（Enter）")
                         {
                             TicketOrder ticketOrder = new TicketOrder();
                             ticketOrder.SellerName = CurrentUser.UserName;
                             ticketOrder.OrderDateTime = DateTime.Now;
                             ticketOrder.tickets = GetTickets();//索票
                             CardForm cfm = new CardForm(ticketOrder);
                             cfm.Show();
                         }
                         else
                         {
                             //检查父容器是否是隐藏的
                             ActivieParentContainerIfNeeded(toCtrls[0]);
                             SetFocus(toCtrls[0]);
                             //确实获得了焦点，再吞噬这个按键动作
                             if (toCtrls[0].Focused)
                             {
                                 return true;
                             }
                         }*/
                        //检查父容器是否是隐藏的
                        ActivieParentContainerIfNeeded(toCtrls[0]);
                        SetFocus(toCtrls[0]);
                        //确实获得了焦点，再吞噬这个按键动作
                        if (toCtrls[0].Focused)
                        {
                            return true;
                        }
                    }
                }
            }
            else
                if (keyData == Keys.Y)
                {
                    btnDaYin_Click(null, null);
                }
                else if (keyData == Keys.Up)
                {
                    //↑键
                    DirectionKey(ctl, Keys.Up);
                }
                else if (keyData == Keys.Down)
                {
                    //↓键
                    DirectionKey(ctl, Keys.Down);
                }
                else if (keyData == Keys.Left)
                {
                    //←键
                    DirectionKey(ctl, Keys.Left);
                }
                else if (keyData == Keys.Right)
                {
                    //→键

                    DirectionKey(ctl, Keys.Right);
                }
                else
                    if (keyData == Keys.F7)
                    {
                        button1_Click(null, null);
                    }
                    else
                        if (keyData == Keys.F6)
                        {
                            button2_Click(null, null);
                        }
            /*else if (keyData == Keys.F6) { button2_Click(null, null); }
            else if (keyData == Keys.F5) { button3_Click(null, null); }*/
            bool ret = base.ProcessCmdKey(ref msg, keyData);
            return ret;
        }



        private void DirectionKey(Control CurrentControl, Keys keys)
        {
            if (CurrentControl != null)
            {
                Control[,] TextBoxArr = new Control[,] { 
                /*{ txtRQ, txtTicketNo, lblCurrentTime, lblCurrentTime, txtRQ }, 
                {txtEndStation,txtPreDay,txtPreDay,txtPreDay,txtPreDay},
                {txtStartStation,txtStartStation,txtStartStation,txtStartStation,txtStartStation},
                {txtFullCount,txtFullCount,txtFullCount,txtFullCount,txtFullCount},
                {txtYHCount,txtYHCount,txtYHCount,txtYHCount,txtYHCount},
                {txtPayMoney,txtPayMoney,txtPayMoney,txtPayMoney,txtPayMoney},
                {btnDaYin,btnDaYin,btnDaYin,btnDaYin,btnDaYin}*/
                {txtRQ,lblCurrentTime,txtLine,txtTicketNo,txtBc},
                {txtEndStation,txtStartStation,txtStartStation,txtStartStation,txtStartStation                    },
                {txtPreDay ,txtPreDay,txtPreDay,txtPreDay,txtPreDay                                        },
                { txtFullCount,txtYHCount     ,txtYHCount,txtYHCount,txtYHCount                   },
                //{lblTicketTotalPrice ,lblTicketTotalPrice,lblTicketTotalPrice,lblTicketTotalPrice,lblTicketTotalPrice                          },
                {txtPayMoney,txtPayMoney,txtPayMoney,txtPayMoney,txtPayMoney},
                {btnDaYin,btnDaYin,btnDaYin,btnDaYin,btnDaYin}
            };
                Metrix mex = new Metrix(TextBoxArr);
                List<Metrix> mlist = mex.list.Distinct(new Compare<Metrix>((x, y) => (x != null && y != null) && (x.ctrl.Name == y.ctrl.Name))).ToList();


                foreach (Metrix item in mlist)
                {
                    Control FindCtrl = null;
                    if (item.ctrl.Name == CurrentControl.Name)
                    {
                        switch (keys)
                        {
                            case Keys.Up:
                                Control UpBox = BLL.Matrix.FindControl(item.row - 1, item.col, mlist);
                                if (UpBox != null)
                                    SetFocus(UpBox);
                                else
                                    FindCtrl = BLL.Matrix.FindControlMaxCol(item.row - 1, mlist);
                                break;
                            case Keys.Down:
                                Control DownBox = BLL.Matrix.FindControl(item.row + 1, item.col, mlist);
                                if (DownBox != null)

                                    SetFocus(DownBox);
                                else
                                    FindCtrl = BLL.Matrix.FindControlMaxCol(item.row + 1, mlist);

                                break;
                            case Keys.Left:
                                Control LeftBox = BLL.Matrix.FindControl(item.row, item.col - 1, mlist);
                                if (LeftBox != null)
                                    SetFocus(LeftBox);
                                else
                                    FindCtrl = BLL.Matrix.FindControlMaxCol(item.row - 1, mlist);
                                break;
                            case Keys.Right:
                                Control RightBox = BLL.Matrix.FindControl(item.row, item.col + 1, mlist);
                                if (RightBox != null)
                                    SetFocus(RightBox);
                                else
                                    FindCtrl = BLL.Matrix.FindControl(item.row + 1, 0, mlist);
                                break;
                            default:
                                break;
                        }
                        if (FindCtrl != null)
                            //FindCtrl.Focus();
                            SetFocus(FindCtrl);
                    }
                }


            }


        }

        private void SetFocus(Control control)
        {
            if (control.GetType().FullName == "MaterialSkin.Controls.MaterialSingleLineTextField")
            {
                MaterialSkin.Controls.MaterialSingleLineTextField f = control as MaterialSkin.Controls.MaterialSingleLineTextField;
                f.SelectAll();
            }
            else
            {
                control.Focus();
            }
        }





        private List<Ticket> GetTickets()
        {
            return null;
        }
        /// <summary>
        /// 有一些控件隐藏在了TabControl的后面，造成Focus不成功。
        /// 因为这些控件的Visible为False，必须先使他们的父控件TabPage先选中
        /// </summary>
        /// <param name="child"></param>
        private void ActivieParentContainerIfNeeded(Control child)
        {
            if (child.Visible)
            {
                return;
            }
            Control parent = child.Parent;
            while (parent != null)
            {
                if (parent is TabPage)
                {
                    break;
                }
                parent = parent.Parent;
            }

            if (parent is TabPage)
            {
                TabControl tabCtrl = (TabControl)parent.Parent;
                tabCtrl.SelectedTab = (parent as TabPage);
            }
        }
        #endregion



        #region 售票查询
        private void button2_Click(object sender, EventArgs e)
        {

            SellForm SellForm = new SellForm();
            SellForm.Show();

        }
        #endregion

        #region 退票
        private void button1_Click(object sender, EventArgs e)
        {

            ReSellForm RsellForm = new ReSellForm();
            RsellForm.Show();

        }
        #endregion
        private void btnDaYin_Click(object sender, EventArgs e)
        {
            try
            {
                TicketOrder ticketOrder = new TicketOrder();
                ticketOrder.SellerName = CurrentUser.UserName;
                ticketOrder.OrderDateTime = DateTime.Now;
                ticketOrder.tickets = GetTickets();//索票
                CardForm cfm = new CardForm(ticketOrder);
                cfm.Show();
            }
            catch (Exception ex) { }
        }
    }
}
