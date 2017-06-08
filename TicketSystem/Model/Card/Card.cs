using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Configuration;
namespace Model
{
    public class Card
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8)]
        public struct PERSONINFOW
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string sex;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string nation;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string birthday;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
            public string address;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string cardId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string police;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string validStart;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string validEnd;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string sexCode;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string nationCode;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
            public string appendMsg;
        }
        [DllImport("cardapi3.dll", EntryPoint = "OpenCardReader",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern Int32 OpenCardReader(Int32 lPort, UInt32 ulFlag, UInt32 ulBaudRate);
        [DllImport("cardapi3.dll", EntryPoint = "GetPersonMsgW",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern Int32 GetPersonMsgW(ref PERSONINFOW pInfo, string pszImageFile);
        [DllImport("cardapi3.dll", EntryPoint = "GetPersonMsgA",
        CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern Int32 GetPersonMsgA(ref PERSONINFOW pInfo, string pszImageFile);
        [DllImport("cardapi3.dll", EntryPoint = "CloseCardReader",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern Int32 CloseCardReader();
        [DllImport("cardapi3.dll", EntryPoint = "GetErrorTextW",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void GetErrorTextW(StringBuilder pszBuffer, UInt32 dwBufLen);
        [DllImport("cardapi3.dll", EntryPoint = "GetCardReaderStatus",
           CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern long GetCardReaderStatus(long lPort, ulong ulBaudRate);


    }
    public class CardMonitorService
    {
        #region Fields
        private Card.PERSONINFOW person;
        private int port = Convert.ToInt32(ConfigurationManager.AppSettings["port"].ToString());
        private UInt32 flag = Convert.ToUInt32(ConfigurationManager.AppSettings["flag"].ToString());
        private UInt32 BaudRate = Convert.ToUInt32(ConfigurationManager.AppSettings["BaudRate"].ToString());
        #endregion

        public void ServiceStart(ref Card.PERSONINFOW person, string imagePath)
        {
            ThreadInvoke(ref  person, imagePath);
        }

        private void ThreadInvoke(ref Card.PERSONINFOW person, string imagePath)
        {
            if (!OpenDevice())
                return;
            int result = Card.GetPersonMsgW(ref person, imagePath);
            if (result == 0)
            {
                //run = false;
                CloseDevice();
            }
        }
        //关闭设备
        private void CloseDevice()
        {
            Card.CloseCardReader();
        }

        //打开设备
        private bool OpenDevice()
        {
            int result = Card.OpenCardReader(port, flag, BaudRate);
            if (result == 0)
                return true;
            else
                return false;
        }

        public delegate void Elapsed(); //定义委托  
        public event Elapsed OnElapsed;

        private long _Interval = 1000;
        public long Interval
        {
            get { return _Interval; }
            set { _Interval = value; }
        }

        private bool _IsStart = false;
        private Thread _TimerThread;
        public void Start()
        {
            if (_IsStart)
                return;

            _IsStart = true;

            _TimerThread = new Thread(new ThreadStart(DoTimer));
            _TimerThread.Start();
        }


        public void Stop()
        {
            try
            {
                if (!_IsStart)
                    return;

                _IsStart = false;

                _TimerThread.Abort();
            }
            catch (Exception e)
            { }
        }

        private void DoTimer()
        {
            try
            {
                int last = Environment.TickCount;
                while (_IsStart)
                {
                    if (Environment.TickCount - last > _Interval)
                    {
                        if (OnElapsed != null)
                            OnElapsed();

                        last = Environment.TickCount;

                    }
                    Thread.Sleep(100);
                }


            }
            catch (Exception e)
            { }
        }

    }

}

//#region 第1步 初始化
//private void Init()
//{


//    this.timer1.Enabled = true;
//    this.timer1.Interval = 1000;
//    try
//    {
//        OpenDevice();
//        ReadCard();
//    }
//    catch (Exception ex)
//    {
//        LogHelper.WriteLog(typeof(CardForm), ex.Message);
//    }
//}
//#endregion
//#region 第2步 打开设备
//private void OpenDevice()
//{
//    Int32 result;
//    StringBuilder errorText = new StringBuilder(maxErrorTextLen);
//    /*参数1为端口号。1表示串口1，2表示串口2，依次类推。1001表示USB。0表示自动选择。
//      参数2为标志位。0x02表示启用重复读卡。0x04表示读卡后接着读取新地址。
//      各个数值可以用“按位或”运算符组合起来。
//      参数3为波特率。使用串口阅读器的程序应正确设置此参数。出厂机器的波特率一般为115200。
//    */
//    result = Card.OpenCardReader(port, flag, BaudRate);
//    Card.GetErrorTextW(errorText, maxErrorTextLen);
//    //LogHelper.WriteLog(typeof(CardForm), errorText.ToString());
//    //textResult.Text = Convert.ToString(result);
//    //textDescription.Text = errorText.ToString();
//}
//#endregion
//#region 第3步 读取卡信息
//private void ReadCard()
//{
//    Int32 result;
//    String imagePath;
//    StringBuilder errorText = new StringBuilder(maxErrorTextLen);

//    if (image != null)
//    {
//        image.Dispose();
//        image = null;
//    }
//    imagePath = Path.GetTempPath() + "image.bmp";
//    //当程序打开设备后，可以多次调用读取信息函数。
//    result = Card.GetPersonMsgW(ref person, imagePath);
//    if (0 == result)
//    {
//        birthday = ConvertDate(person.birthday, 1);
//        validDate = ConvertDate(person.validStart, 2) + "-";
//        validDate += ConvertDate(person.validEnd, 2);
//        image = new Bitmap(imagePath);
//        textName.Text = person.name;
//        textIDCard.Text = person.cardId;
//        textName.Enabled = false;
//        textIDCard.Enabled = false;
//        //this.timer1.Enabled = false;
//        //CloseDevice();
//        //HasRead = true;

//        ticketOrder.BuyerIDCard = person.cardId;
//        ticketOrder.BuyerName = person.name;

//        LogHelper.WriteLog(typeof(CardForm), "读卡成功");
//        list.Add(person);

//    }
//    else if (11 == result)
//    {
//        LogHelper.WriteLog(typeof(CardForm), "【result:无身份信息】");

//    }
//    else
//    {
//        Card.GetErrorTextW(errorText, maxErrorTextLen);
//        LogHelper.WriteLog(typeof(CardForm), errorText.ToString());

//        birthday = "";
//        validDate = "";
//        person.name = "";
//        person.sex = "";
//        person.nation = "";
//        person.birthday = "";
//        person.address = "";
//        person.cardId = "";
//        person.police = "";
//        person.validStart = "";
//        person.validEnd = "";
//        person.sexCode = "";
//        person.nationCode = "";
//        person.appendMsg = "";

//        //this.textIDCard.Text = "";
//        //this.textName.Text = "";
//    }

//    Invalidate();
//}
//#endregion
//#region 第4步 关闭设备
//private void CloseDevice()
//{
//    Int32 result;
//    StringBuilder errorText = new StringBuilder(maxErrorTextLen);
//    //读完卡后，必须关闭设备。
//    result = Card.CloseCardReader();
//    Card.GetErrorTextW(errorText, maxErrorTextLen);
//}
//#endregion
