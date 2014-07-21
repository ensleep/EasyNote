using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using EasyNote.MODEL;

namespace EasyNote
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 初始化数据
            using(IDbConnection db=ComTool.DbFactory.Open())
            {
                foreach(Type type in Assembly.GetExecutingAssembly().GetTypes())
                {
                    if (type.Name.Length>2&&type.Name.Substring(0, 2).ToUpper() == "DB")
                    {
                        if (type.Namespace.IndexOf('.') > 0 && type.Namespace.Split('.')[1].ToUpper() == "MODEL")
                        {
                            db.CreateTableIfNotExists(type);
                        }
                    }
                }
            }
            #endregion
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
