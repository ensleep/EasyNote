using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using EasyNote.MODEL;

namespace EasyNote.Note
{
    public partial class frmViewNote : DevExpress.XtraEditors.XtraForm
    {
        public frmViewNote()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            using(IDbConnection db=ComTool.DbFactory.Open())
            {
                lueGuyName.Properties.DataSource = db.Select<DbGuys>().Where(x =>x.UserId == StateClass.CurrentUser.UserId).ToList();
            }
            
        }
    }
}
