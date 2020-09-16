using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ruanmou.Framework.AttributeExtend
{
    /// <summary>
    /// 数据验证特性基类
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MobileAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object oValue)
        {
            if (oValue == null)
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(oValue.ToString(), @"^[1]+[3,5]+\d{9}");
            }
        }
    }
}
