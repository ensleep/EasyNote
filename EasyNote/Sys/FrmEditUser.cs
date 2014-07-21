using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using EasyNote.MODEL;
using System.Reflection;

namespace EasyNote.Sys
{
    public partial class FrmEditGuys : DevExpress.XtraEditors.XtraForm
    {
        private List<DbUser> TempDbUser = null;
        private List<long> listEditedRowIndex = new List<long>();
        private List<long> listNewRowIndex = new List<long>();
        public FrmEditGuys()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            using(IDbConnection db=ComTool.DbFactory.OpenDbConnection())
            {
                gcUser.DataSource = TempDbUser = db.Select<DbUser>();
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            teDescription.Text = "";
            tePassword.Text = "";
            teTrueName.Text = "";
            teUserName.Text = "";
        }
        private void AddData()
        {
            DbUser newDbUser = new DbUser();
            newDbUser.TrueName = teTrueName.Text.Trim();
            newDbUser.UserName = teUserName.Text.Trim();
            newDbUser.Password = tePassword.Text.Trim();
            newDbUser.Description = teDescription.Text.Trim();
            using (IDbConnection db = ComTool.DbFactory.Open())
            {
                db.Insert<DbUser>(newDbUser);
            }
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(listEditedRowIndex.Count>0)
            {

                DialogResult dr = MessageBox.Show("有未保存的修改，是否先保存修改再进行添加？选是将保存之前修改再添加，选否则取消之前修改", "发现未保存修改", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    SaveEditedRow();
                    AddData();
                }
                else if (dr == DialogResult.No)
                {
                    AddData();
                }
                else if (dr == DialogResult.Cancel)
                {
                }
            }
            else
            {
                AddData();
            }
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEditedRow();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["UserName"], DateTime.Today);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int indexItem=e.RowHandle;
            typeof(DbUser).GetProperty(e.Column.FieldName).SetValue(TempDbUser[e.RowHandle], e.Value);
            listEditedRowIndex.Add(e.RowHandle);
            gcUser.DataSource = TempDbUser;
        }
        private void SaveEditedRow()
        {
            using (IDbConnection db = ComTool.DbFactory.Open())
            {
                foreach (long index in listEditedRowIndex)
                {
                    db.Update<DbUser>(TempDbUser[(int)index]);
                }
            }
            listEditedRowIndex = new List<long>();
        }

        private void btnFreshData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = ComTool.DbFactory.Open())
            {
                foreach (int index in gridView1.GetSelectedRows())
                {
                    db.DeleteById<DbUser>(gridView1.GetRowCellValue(index, UserId));
                }
                
            }
            LoadData();
        }
    }
}