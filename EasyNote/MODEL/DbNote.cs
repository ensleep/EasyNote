using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.OrmLite.Sqlite;
using ServiceStack.DataAnnotations;

namespace EasyNote.MODEL
{
    /// <summary>
    /// 帐目的记录规则为：用户借给伙伴Money元人民币。若Money为负，则视为欠。
    /// </summary>
    public class DbNote
    {
        /// <summary>
        /// 帐目id
        /// </summary>
        [AutoIncrement]
        public long NoteId { get; set; }
        public long UserId{get;set;}
        public long GuyId { get; set; }
        public double Money { get; set; }
        public String MakeDateTime { get; set; }
        public String AddDateTime { get; set; }
        
    }
}
