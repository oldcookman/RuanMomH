using Ruanmou.Framework.AttributeExtend;
using Ruanmou.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ruanmou.Libraries.Model
{
    /// <summary>
    /// 自己去做    可空类型
    /// </summary>
    public class User : BaseModel
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        //public int State { get; set; }

        [Column("State")]
        public int Status { get; set; }

        public int UserType { get; set; }

        public DateTime LastLoginTime { get; set; }

        public int CreatorId { get; set; }//非空没有完成

        public DateTime CreateTime { get; set; }

        public int LastModifierId { get; set; }

        public DateTime LastModifyTime { get; set; }
    }
}
