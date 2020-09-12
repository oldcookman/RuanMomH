using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuanMouDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            CommMenthod commMenthod = new CommMenthod();
            CommMenthod.ShowInt(123);
            CommMenthod.ShowString("来吧，宝贝");
            DateTime dt = DateTime.Now;
            CommMenthod.ShowDateTime(dt);
            Console.ReadKey();
        }
    }
}
