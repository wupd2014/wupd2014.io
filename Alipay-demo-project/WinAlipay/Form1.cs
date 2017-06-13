using Com.Alipay;
using Com.Alipay.Business;
using Com.Alipay.Domain;
using Com.Alipay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace WinAlipay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string result = "";
        IAlipayTradeService serviceClient = F2FBiz.CreateClientInstance(Config.serverUrl, Config.appId, Config.merchant_private_key, Config.version,
                           Config.sign_type, Config.alipay_public_key, Config.charset);

        private void button1_Click(object sender, EventArgs e)
        {
            AlipayTradePayContentBuilder builder = BuildPayContent();
            string out_trade_no = builder.out_trade_no;
            AlipayF2FPayResult payResult = serviceClient.tradePay(builder);

            switch (payResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoSuccessProcess(payResult);
                    break;
                case ResultEnum.FAILED:
                    DoFailedProcess(payResult);
                    break;
                case ResultEnum.UNKNOWN:
                    result = "网络异常，请检查网络配置后，更换外部订单号重试";
                    MessageBox.Show(result);
                    break;
            }
        }
        private AlipayTradePayContentBuilder BuildPayContent()
        {
            //线上联调时，请输入真实的外部订单号。
            string out_trade_no = GuidTo16String();

            //扫码枪扫描到的用户手机钱包中的付款条码
            AlipayTradePayContentBuilder builder = new AlipayTradePayContentBuilder();

            builder.out_trade_no = out_trade_no;
            builder.scene = "bar_code";
            builder.auth_code = textBox1.Text;
            builder.total_amount = "0.01";
            builder.discountable_amount = "0.01";
            builder.undiscountable_amount = "0";
            builder.operator_id = "test";
            builder.subject = "条码支付";
            builder.timeout_express = "2m";
            builder.body = "订单描述";
            builder.store_id = "test store id";    //很重要的参数，可以用作之后的营销     
            builder.seller_id = Config.pid;       //可以是具体的收款账号。


            //传入商品信息详情
            List<GoodsInfo> gList = new List<GoodsInfo>();

            GoodsInfo goods = new GoodsInfo();
            goods.goods_id = "goods id";
            goods.goods_name = "goods name";
            goods.price = "0.01";
            goods.quantity = "1";
            gList.Add(goods);
            builder.goods_detail = gList;
            //扩展参数
            //系统商接入可以填此参数用作返佣
            //ExtendParams exParam = new ExtendParams();
            //exParam.sysServiceProviderId = Config.pid;
            //builder.extendParams = exParam;

            return builder;

        }


        /// <summary>
        /// 请添加支付成功后的处理
        /// </summary>
        private void DoSuccessProcess(AlipayF2FPayResult payResult)
        {

            //请添加支付成功后的处理
            System.Console.WriteLine("支付成功");
            result = payResult.response.Body;
            MessageBox.Show(result);
        }

        private void DoFailedProcess(AlipayF2FPayResult payResult)
        {
            //请添加支付失败后的处理
            System.Console.WriteLine("支付失败");
            result = payResult.response.Body;
            MessageBox.Show(result);
        }
        /// <summary>  
        /// 根据GUID获取16位的唯一字符串  
        /// </summary>  
        /// <param name=\"guid\"></param>  
        /// <returns></returns>  
        public static string GuidTo16String()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
                i *= ((int)b + 1);

            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
        //*********************************************退款************************************************
        private void button2_Click(object sender, EventArgs e)
        {
            AlipayTradeRefundContentBuilder builder = BuildContent();
            AlipayF2FRefundResult refundResult = serviceClient.tradeRefund(builder);

            //请在这里加上商户的业务逻辑程序代码
            //——请根据您的业务逻辑来编写程序（以下代码仅作参考）——
            switch (refundResult.Status)
            {
                case ResultEnum.SUCCESS:
                    //DoSuccessProcess(refundResult);
                    MessageBox.Show(refundResult.response.Body);
                    break;
                case ResultEnum.FAILED:
                    //DoFailedProcess(refundResult);
                    MessageBox.Show(refundResult.response.Body);
                    break;
                case ResultEnum.UNKNOWN:
                    if (refundResult.response == null)
                    {
                        result = "配置或网络异常，请检查";
                    }
                    else
                    {
                        result = "系统异常，请走人工退款流程";
                    }
                    MessageBox.Show(result);
                    break;
            }
        }
        private AlipayTradeRefundContentBuilder BuildContent()
        {
            AlipayTradeRefundContentBuilder builder = new AlipayTradeRefundContentBuilder();

            //商户订单号
            builder.out_trade_no = textBox2.Text;

            //交易号——退款请求单号保持唯一性。
            builder.out_request_no = textBox3.Text;

            //退款金额
            builder.refund_amount = "0.01";

            builder.refund_reason = "refund reason";

            return builder;

        }
        //*********************************************订单查询************************************************
        private void button3_Click(object sender, EventArgs e)
        {
            //商户订单号
            string out_trade_no = textBox4.Text.Trim();

            //商户网站订单系统中唯一订单号，必填
            AlipayF2FQueryResult queryResult = serviceClient.tradeQuery(out_trade_no);

            //请在这里加上商户的业务逻辑程序代码
            //——请根据您的业务逻辑来编写程序（以下代码仅作参考）——
            switch (queryResult.Status)
            {
                case ResultEnum.SUCCESS:
                    MessageBox.Show(queryResult.response.Body);
                    break;
                case ResultEnum.FAILED:
                    MessageBox.Show(queryResult.response.Body);
                    break;
                case ResultEnum.UNKNOWN:
                    if (queryResult.response == null)
                    {
                        //result = "网络异常，请检查网络配置";
                        result = "配置或网络异常，请检查";
                    }
                    else
                    {
                        result = "系统异常，请重试";
                    }
                    MessageBox.Show(result);
                    break;
            }
        }

        //*********************************************扫描二维码支付************************************************
        private void button4_Click(object sender, EventArgs e)
        {
            AlipayTradePrecreateContentBuilder builder = BuildPrecreateContent();
            string out_trade_no = builder.out_trade_no;
            AlipayF2FPrecreateResult precreateResult = serviceClient.tradePrecreate(builder);

            //如果需要接收扫码支付异步通知，请调用另外一个方法
            //string notify_url = "http://10.5.21.14/notify_url.aspx";  //商户接收异步通知的地址
            //AlipayF2FPrecreateResult precreateResult = serviceClient.tradePrecreate(builder, notify_url);

            //以下返回结果的处理供参考。
            //payResponse.QrCode即二维码对于的链接
            //将链接用二维码工具生成二维码打印出来，顾客可以用支付宝钱包扫码支付。
            string result = "";

            switch (precreateResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoWaitProcess(precreateResult);
                    break;
                case ResultEnum.FAILED:
                    result = precreateResult.response.Body;
                    MessageBox.Show(result);
                    break;

                case ResultEnum.UNKNOWN:
                    if (precreateResult.response == null)
                    {
                        result = "配置或网络异常，请检查后重试";
                    }
                    else
                    {
                        result = "系统异常，请更新外部订单后重新发起请求";
                    }
                    MessageBox.Show(result);
                    break;
            }

        }
        private AlipayTradePrecreateContentBuilder BuildPrecreateContent()
        {
            //线上联调时，请输入真实的外部订单号。
            string out_trade_no = GuidTo16String();

            AlipayTradePrecreateContentBuilder builder = new AlipayTradePrecreateContentBuilder();
            builder.out_trade_no = out_trade_no;
            builder.total_amount = "0.01";
            builder.undiscountable_amount = "0";
            builder.operator_id = "test";
            builder.subject = "扫码支付";
            builder.time_expire = System.DateTime.Now.AddHours(1).ToString("yyyy-MM-dd HH:mm:ss"); ;
            builder.body = "订单描述";
            builder.store_id = "test store id";    //很重要的参数，可以用作之后的营销     
            builder.seller_id = Config.pid;       //可以是具体的收款账号。

            //传入商品信息详情
            List<GoodsInfo> gList = new List<GoodsInfo>();
            GoodsInfo goods = new GoodsInfo();
            goods.goods_id = "goods id";
            goods.goods_name = "goods name";
            goods.price = "0.01";
            goods.quantity = "1";
            gList.Add(goods);
            builder.goods_detail = gList;
            //扩展参数
            //系统商接入可以填此参数用作返佣
            //ExtendParams exParam = new ExtendParams();
            //exParam.sysServiceProviderId = "20880000000000";
            //builder.extendParams = exParam;

            return builder;

        }
        private void DoWaitProcess(AlipayF2FPrecreateResult precreateResult)
        {
            string url2 = precreateResult.response.QrCode;
            //初始化二维码生成工具
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            qrCodeEncoder.QRCodeVersion = 0;
            qrCodeEncoder.QRCodeScale = 4;

            //将字符串生成二维码图片
            pictureBox1.Image = qrCodeEncoder.Encode(url2, Encoding.Default);


            //打印出 preResponse.QrCode 对应的条码
            //Bitmap bt;
            //string enCodeString = precreateResult.response.QrCode;
            //QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            //qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            //qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
            //qrCodeEncoder.QRCodeScale = 3;
            //qrCodeEncoder.QRCodeVersion = 8;
            //bt = qrCodeEncoder.Encode(enCodeString, Encoding.UTF8);
            //string filename = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "0000" + (new Random()).Next(1, 10000).ToString()
            // + ".jpg";
            //bt.Save(Server.MapPath("~/images/") + filename);
            //this.Image1.ImageUrl = "~/images/" + filename;

            //轮询订单结果
            //根据业务需要，选择是否新起线程进行轮询
            ParameterizedThreadStart ParStart = new ParameterizedThreadStart(LoopQuery);
            Thread myThread = new Thread(ParStart);
            object o = precreateResult.response.OutTradeNo;
            myThread.Start(o);

        }

        public void LoopQuery(object o)
        {
            AlipayF2FQueryResult queryResult = new AlipayF2FQueryResult();
            int count = 100;
            int interval = 10000;
            string out_trade_no = o.ToString();

            for (int i = 1; i <= count; i++)
            {
                Thread.Sleep(interval);
                queryResult = serviceClient.tradeQuery(out_trade_no);
                if (queryResult != null)
                {
                    if (queryResult.Status == ResultEnum.SUCCESS)
                    {
                        DoSuccessProcess1(queryResult);
                        return;
                    }
                }
            }
            DoFailedProcess1(queryResult);
        }
        private void DoSuccessProcess1(AlipayF2FQueryResult queryResult)
        {
            //支付成功，请更新相应单据
            MessageBox.Show("扫码支付成功：外部订单号" + queryResult.response.OutTradeNo);

        }


        private void DoFailedProcess1(AlipayF2FQueryResult queryResult)
        {
            //支付失败，请更新相应单据
        }


        //*********************************************End扫描二维码支付************************************************
    }
}
