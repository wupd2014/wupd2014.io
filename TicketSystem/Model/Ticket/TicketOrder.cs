using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TicketOrder
    {
        public DateTime OrderDateTime { get; set; }     //订单时间
        public string BuyerName { get; set; }           //购买者
        public string BuyerIDCard { get; set; }         //购买者Card ID
        public string SellerName { get; set; }          //订单完成人
        public List<Ticket> tickets { get; set; }       //订单票据信息
    }
}
