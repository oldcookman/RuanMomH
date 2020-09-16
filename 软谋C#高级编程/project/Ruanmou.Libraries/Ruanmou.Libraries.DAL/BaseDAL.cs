using Ruanmou.Framework;
using Ruanmou.Libraries.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Libraries.DAL
{
    public class BaseDAL
    {
        /// <summary>
        /// 通过ID查询出所对应的实体值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Id"></param>
        public T Find<T>(int Id) where T : BaseModel 
        {
            Type type = typeof(T);
            // 获取当前对象的属性,并且进行拼接
            string columString = string.Join(",", type.GetProperties().Select(p => $"[{p.Name}]"));
            // 拼接sql
            string sql = $"SELECT {columString} From [{type.Name}] Where Id = {Id}";
            // 通过反射给对象赋值
            T t =  (T)Activator.CreateInstance(type);
            using (SqlConnection conn = new SqlConnection(StaticConstants.SqlServerConn))
            {
                conn.Open();
                // SqlCommand("执行的sql语句","连接的字符串对象");
                SqlCommand comm = new SqlCommand(sql,conn);

                SqlDataReader sqlDataReader = comm.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    foreach (var prop in type.GetProperties())
                    {
                        // 在这里没有考虑数据库中的数据为空的情况 
                        // 解决办法 1. 实体类 加上可为 ？ 2. 赋值时进行空值判断
                        // dbnull 是指数据库中的数据为空  null 是指对象没有引用空  ""和String.Empty 这两个都是表示空字符串

                        prop.SetValue(t,sqlDataReader[prop.Name] is DBNull ? null : sqlDataReader[prop.Name]);
                    }
                }
            }
            return t;

        }
    }
}
