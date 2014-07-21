using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.OrmLite.Sqlite;
using ServiceStack.DataAnnotations;

namespace EasyNote.MODEL
{
    public class DbUser
    {
        [AutoIncrement]
        public long UserId { get; set; }
        public String UserName { get; set; }
        public String TrueName { get; set; }
        public String Password { get; set; }
        public String Description { get; set; }
    }
}
