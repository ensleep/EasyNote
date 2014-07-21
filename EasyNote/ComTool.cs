using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyNote
{
    public class ComTool
    {
        public static string SqliteMemoryDb = ":memory:";
        public static string SqliteFileDb = "DAL/EasyNote.db";
        public static OrmLiteConnectionFactory DbFactory = new OrmLiteConnectionFactory(SqliteFileDb, SqliteDialect.Provider, true);
    }
}
