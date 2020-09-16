using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ruanmou.Libraries.Model
{
    public class Company : BaseModel
    {
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 数据库中的字段要与实体类对应 包括是否是可空值
        /// </summary>
        public int? LastModifierId { get; set; }
        public DateTime? LastModifyTime { get; set; }
    }
}
