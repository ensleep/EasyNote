using EasyNote.MODEL;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyNote.Sys;

namespace EasyNote
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int count = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        public T CreateMdiForm<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(T))
                {
                    f.Activate();
                    return f as T;
                }
            }
            T frm = new T();
            frm.MdiParent = this;
            return frm;
        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Sys.Logon lgn = new Sys.Logon(this);
            lgn.ShowDialog();
        }

        private void btnNewUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (StateClass.CurrentUser == null)
            {
                MessageBox.Show("请登陆！");
                return;
            }
            FrmEditGuys fcu = CreateMdiForm<FrmEditGuys>();
            fcu.Text = DateTime.Now.ToString("hhmmss");
            fcu.Show();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (StateClass.CurrentUser == null)
            {
                MessageBox.Show("请登陆！");
                return;
            }
            StateClass.CurrentUser = null;
            this.Text = "EasyNote";
        }

        private void btnViewNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (StateClass.CurrentUser == null)
            {
                MessageBox.Show("请登陆！");
                return;
            }
            Note.frmViewNote fvn = CreateMdiForm<Note.frmViewNote>();
            fvn.Text = "查看帐目";
            fvn.Show();
        }

        private void btnViewGuys_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(StateClass.CurrentUser==null)
            {
                MessageBox.Show("请登陆！");
                return;
            }
            Guys.FrmEditGuys fvn = CreateMdiForm<Guys.FrmEditGuys>();
            fvn.Text = "伙伴管理";
            fvn.Show();
        }
    }
}
