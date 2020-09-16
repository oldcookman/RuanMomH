using Ruanmou.Libraries.DAL;
using Ruanmou.Libraries.IDAL;
using Ruanmou.Libraries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Libraries.Project
{
    /// <summary>
    /// 1  项目的基本结构搭建
    /// 2  基础查询封装
    /// 3  mapping映射处理
    /// 4  增删改实现
    /// 5  特性通用验证
    /// 6  泛型缓存
    /// 
    /// 不是为大家写一个大而全，无懈可击的项目？  
    /// 做不到,走着瞧~~
    /// 
    /// 1 压缩文件不要搞密码。。命名也注意下规范，邮件名称也是如此
    /// 2 别搞微云、百度云啥的，，直接附件吧
    /// 3 最好不要重复交作业，做好一次性交哦。。。
    /// 4 作业写一半儿等指导的，，这个就没有了。。看我写吧
    /// 5 qq421446968 是谁呀。。还交了作业
    /// 
    /// 1 UI层必须把异常catch住
    /// 2 底层出了问题，不要隐瞒，第一时间终止运行
    /// 3 除非你能容忍某个异常，那么自己try catch  然后日志 剩下的继续
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is Homework Lesson");
                BaseDAL baseDAL = new BaseDAL();
                // Company 经测试没有问题
                // 
                Company company = baseDAL.Find<Company>(4);
                //User user = baseDAL.Find<User>(1);
                Console.WriteLine(company.ToString()); 
               
            }
            catch (Exception ex)//UI层必须把异常catch住
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        /// <summary>
        /// 自己完成
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        private static void Show<T>(T t)
        {
            // 就是又要增加一个中文名称的特性
        }
    }
}
