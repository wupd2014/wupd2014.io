using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceTest
{
    /// <summary>
    /// WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        public bool CheckUser(string uid, string password)
        {
            return true;
        }

        public DataSet QueryTicketDataSet(string startStation, string endStation, string Date, string line, string Bc)
        {
            DataSet ds = new DataSet();
            return ds;
        }

        public DataSet GetLockTickets(string Date,string Bc,string)
        {

            DataSet ds = new DataSet();
            return ds;
        }
    }
}
