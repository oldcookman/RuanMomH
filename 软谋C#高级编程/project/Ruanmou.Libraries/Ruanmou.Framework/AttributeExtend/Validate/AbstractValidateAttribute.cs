using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Framework.AttributeExtend
{
    /// <summary>
    /// 数据验证特性基类
    /// </summary>
    public abstract class AbstractValidateAttribute : Attribute
    {
        public abstract bool Validate(object value);
    }
}
