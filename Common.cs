using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Online_Money_Transaction
{
    public class Common
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MoneyTransactionDBConnectionString"].ConnectionString;
        }
    }
}