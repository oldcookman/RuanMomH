using System;
using System.Text.RegularExpressions;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 需求 比如直接输入 4+2，5+2， 能得到结果
            Console.WriteLine("请输入要计算的数值：");
            string str = Console.ReadLine();
            //string str = "4+2,2*3,8/2";
            // 然后将逗号拆分出来
           string[] vs = str.Split(',', StringSplitOptions.RemoveEmptyEntries);
           string result = "";
            foreach (var item in vs)
            {
                result += compute(item) + ",";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }


    public static string compute(string input)
        {//各项正则表达式
            string num = @"[\-]?([0-9]{1,}\.?[0-9]*)";  //匹配数字
            string exp1 = @"(?<NUM1>" + num + ")" + @"(?<OP>[\*\/\^])" + @"(?<NUM2>" + num + ")"; //匹配乘法、除法、幂运算
            string exp2 = @"(?<NUM1>" + num + ")" + @"(?<OP>[\+\-])" + @"(?<NUM2>" + num + ")"; //匹配加法、加法

            //定义声明正则表达式
            Regex isExp1 = new Regex(exp1); //乘法、除法、幂运算
            Regex isExp2 = new Regex(exp2); //加法、减法

            //创建匹配对象
            Match mExp1, mExp2;

            //先处理表达式中的乘、除法、幂运算
            mExp1 = isExp1.Match(input);
            while (mExp1.Success)
            {
                GroupCollection gc = mExp1.Groups;  //组匹配
                decimal num1 = Convert.ToDecimal(gc["NUM1"].Value);   //取操作数NUM1
                decimal num2 = Convert.ToDecimal(gc["NUM2"].Value);   //取操作数NUM2 
                switch (gc["OP"].Value) //取运算符OP,并判断运算
                {
                    case "*":
                        num1 *= num2; break;
                    case "/":
                        if (num2 == 0)  //判断除数是否为0
                        {
                            return "DivNumZero";    //返回除数为0标志字符串
                        }
                        else
                        {
                            num1 /= num2;
                            break;
                        }
                }
                input = input.Replace(mExp1.Value, string.Format("{0:f0}", num1));  //把计算结果替换进表达式
                mExp1 = isExp1.Match(input);    //重新匹配乘法、除法
            }

            //再处理加减法
            mExp2 = isExp2.Match(input);
            while (mExp2.Success)
            {
                GroupCollection gc = mExp2.Groups;  //组匹配
                decimal num1 = Convert.ToDecimal(gc["NUM1"].Value);   //取操作数NUM1
                decimal num2 = Convert.ToDecimal(gc["NUM2"].Value);   //取操作数NUM2
                switch (gc["OP"].Value) //取运算符OP,并判断运算
                {
                    case "+": num1 += num2; break;
                    case "-": num1 -= num2; break;
                }
                input = input.Replace(mExp2.Value, string.Format("{0:f0}", num1));  //把计算结果替换进表达式
                mExp2 = isExp2.Match(input);    //重新匹配加法、减法
            }

            //把运算结果返回上一级
            return input;
        }
    }
}
