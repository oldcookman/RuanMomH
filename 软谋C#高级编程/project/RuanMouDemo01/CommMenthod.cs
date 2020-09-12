using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuanMouDemo01
{
   public class CommMenthod
    {
        /// <summary>
        /// 打印个int类型
        /// </summary>
        /// <param name="iParameter"></param>
        public static void ShowInt(int iParameter)
        {
            Console.WriteLine("This is {0},paramter={1},type={2}",
                typeof(CommMenthod).Name,iParameter.GetType().Name,iParameter);
        }
        /// <summary>
        /// 打印个string类型
        /// </summary>
        /// <param name="sParameter"></param>
        public static void ShowString(string sParameter)
        {
            Console.WriteLine("This is {0},paramter={1},type={2}",
                typeof(CommMenthod).Name, sParameter.GetType().Name, sParameter);
        }
        /// <summary>
        /// 打印个DateTime类型
        /// </summary>
        /// <param name="dtParameter"></param>
        public static void ShowDateTime(DateTime dtParameter)
        {
            Console.WriteLine("This is {0},paramter={1},type={2}",
                typeof(CommMenthod).Name, dtParameter.GetType().Name, dtParameter);
        }

        /// <summary>
        /// 打印个Object类型
        /// 1.object是一切类型的父类
        /// 2.通过继承，子类拥有父类的一切属性和行为；任何父类出现的地方，都可以用子类代替。
        /// </summary>
        /// <param name="oParameter"></param>
        public static void ShowObject(int oParameter)
        {
            Console.WriteLine("This is {0},paramter={1},type={2}",
                typeof(CommMenthod).Name, oParameter.GetType().Name, oParameter);
        }
    }
}
