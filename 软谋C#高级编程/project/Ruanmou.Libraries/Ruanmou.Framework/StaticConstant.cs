using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Framework
{
    public class StaticConstant
    {
        /// <summary>
        /// sqlserver数据库连接
        /// </summary>
        public static string SqlServerConnString = ConfigurationManager.ConnectionStrings["Customers"].ConnectionString;

        private static string DALTypeDll = ConfigurationManager.AppSettings["DALTypeDll"];
        public static string DALDllName = DALTypeDll.Split(',')[1];
        public static string DALTypeName = DALTypeDll.Split(',')[0];
    }
}
