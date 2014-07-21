using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.OrmLite.Sqlite;
using ServiceStack.DataAnnotations;

namespace EasyNote.MODEL
{
    public class DbGuys
    {
        /// <summary>
        /// 伙伴id
        /// </summary>
        [AutoIncrement]
        public long GuyId { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public String CompanyName { get; set; }
        /// <summary>
        /// 负责人名称
        /// </summary>
        public String LeaderName { get; set; }
        /// <summary>
        /// 伙伴所属者，即只有此UserId指定的用户才拥有此伙伴
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 伙伴备注与描述
        /// </summary>
        public String Description { get; set; }
    }
}
