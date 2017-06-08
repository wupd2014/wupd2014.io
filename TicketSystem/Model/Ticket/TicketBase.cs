using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TicketBase
    {
        public int TicketID { get; set; }                   //主键ID
        public string TicketNo { get; set; }                //票号
        public string TicketStartStation { get; set; }      //出发站
        public string TicketEndStation { get; set; }        //到达站
        public DateTime TicketStartTime { get; set; }       //出发时间
        public DateTime TicketEndTime { get; set; }         //达到时间
        public string TicketPrice { get; set; }             //票价
        public string TicketBuyerCardID { get; set; }       //买票人ID
        public string TicketPassengerCardID { get; set; }   //乘车人ID
        public double discount { get; set; }                //折扣
        public string LineNo { get; set; }                  //线路
        public string LicenseCardID { get; set; }           //车牌号
        public DateTime FaCheRiQi { get; set; }               //发车日期
        public string Cc { get; set; }//车次
        public string JPK { get; set; }//检票口
        public string ZWH { get; set; }//座位号
        public string CLLX { get; set; }//车辆类型
        public string ZFPrice { get; set; }//政府指导价
        public string KPLX { get; set; }//客票类型
        public string ZXPrice { get; set; }//执行票价
        public string GH { get; set; }//工号
    }
}
