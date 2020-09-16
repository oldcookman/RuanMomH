using Ruanmou.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Framework.AttributeExtend
{
    public static class AttributeHelper
    {
        public static string GetColumnName(this PropertyInfo prop)
        {
            if (prop.IsDefined(typeof(ColumnAttribute), true))
            {
                ColumnAttribute attribute = (ColumnAttribute)prop.GetCustomAttribute(typeof(ColumnAttribute), true);
                return attribute.GetColumnName();
            }
            else
            {
                return prop.Name;
            }
        }



        public static bool Validate<T>(this T tModel) where T : BaseModel
        {
            Type type = tModel.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (prop.IsDefined(typeof(AbstractValidateAttribute), true))
                {
                    object[] attributeArray = prop.GetCustomAttributes(typeof(AbstractValidateAttribute), true);
                    foreach (AbstractValidateAttribute attribute in attributeArray)
                    {
                        if (!attribute.Validate(prop.GetValue(tModel)))
                        {
                            return false;//表示终止
                            //throw new Exception($"{prop.Name}的值{prop.GetValue(tModel)}不对");
                        }
                    }
                }
            }
            return true;
        }
    }
}
