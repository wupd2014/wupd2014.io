using Aop.Api.Response;
using Com.Alipay.Business;
using Com.Alipay.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Com.Alipay
{
    /// <summary>
    /// IAlipayTrade 的摘要说明
    /// </summary>
    public interface IAlipayTradeService
    {
        //当面付条码支付
         AlipayF2FPayResult tradePay(AlipayTradePayContentBuilder builder);
        //重载-增加商户授权 20160601 hongxm
         AlipayF2FPayResult tradePay(AlipayTradePayContentBuilder builder,string tolen);

        // 当面付2.0交易查询
         AlipayF2FQueryResult tradeQuery(string outTradeNo);
         //重载-增加商户授权 20160601 hongxm
         AlipayF2FQueryResult tradeQuery(string outTradeNo, string tolen);

        // 当面付2.0交易退货
         AlipayF2FRefundResult tradeRefund(AlipayTradeRefundContentBuilder builder);
         //重载-增加商户授权 20160601 hongxm
         AlipayF2FRefundResult tradeRefund(AlipayTradeRefundContentBuilder builder, string tolen);
       
        // 当面付2.0预下单
         AlipayF2FPrecreateResult tradePrecreate(AlipayTradePrecreateContentBuilder builder);
         //重载-增加商户授权 20160601 hongxm
         AlipayF2FPrecreateResult tradePrecreate(AlipayTradePrecreateContentBuilder builder,string session,string token);
        //暂不加重载
        AlipayF2FPrecreateResult tradePrecreate(AlipayTradePrecreateContentBuilder builder, string notify_url);

        //云监控接口
         //AlipayF2FMonitorResult mcloudMonitor(AlipayMonitorContentBuilder builder);
    }

}