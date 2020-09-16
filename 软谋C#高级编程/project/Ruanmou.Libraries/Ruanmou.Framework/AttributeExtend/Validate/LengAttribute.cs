using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Framework.AttributeExtend
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class LengAttribute : AbstractValidateAttribute
    {
        private int _Min = 0;
        private int _Max = 0;
        public LengAttribute(int min, int max)
        {
            this._Min = min;
            this._Max = max;
        }
        public override bool Validate(object value)//" "
        {
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                int length = value.ToString().Length;
                if (length > this._Min && length < this._Max)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
