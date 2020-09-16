using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Framework
{
    /// <summary>
    /// 静态常量的数据类
    /// </summary>
   public class StaticConstants
    {
        // 获取sql server 的数据库连接
        public static string SqlServerConn = ConfigurationManager.ConnectionStrings["ruanmou_libraries"].ConnectionString;
    }
}
