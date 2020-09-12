using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuanMouDemo01
{
    public class GenericMethod
    {
        public static void show<T>(T tParamter)
        {
            Console.WriteLine("This is {0},paramter={1},type={2}",
              typeof(GenericMethod).Name, tParamter.GetType().Name, tParamter);
        }
    }
}
