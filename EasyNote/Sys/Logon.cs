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

namespace EasyNote.Sys
{
    public partial class Logon : Form
    {
        frmMain fmParent = null;
        public Logon(frmMain frmmain)
        {
            InitializeComponent();
            fmParent = frmmain;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = ComTool.DbFactory.Open())
            {
                DbUser u=db.Select<DbUser>().Where<DbUser>(m => m.UserName == teUserName.Text.Trim() && m.Password == tePassword.Text.Trim()).FirstOrDefault();
                if (u != null)
                {
                    StateClass.CurrentUser = u;
                    this.Close();
                    fmParent.Text = "EasyNote    欢迎你，" + u.UserName + "["+u.TrueName+"]";
                }
                else
                {
                    MessageBox.Show("帐号不存在或密码错误！");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
