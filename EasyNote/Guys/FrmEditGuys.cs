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

namespace EasyNote.Guys
{
    public partial class FrmEditGuys : DevExpress.XtraEditors.XtraForm
    {
        private List<DbGuys> TempDbGuys = null;
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
                gcGuys.DataSource = TempDbGuys = db.Select<DbGuys>().Where(m=>m.UserId==StateClass.CurrentUser.UserId).ToList();
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            teCompanyName.Text = "";
            teDescription.Text = "";
            teLeaderName.Text = "";

        }
        public void AddData()
        {

            DbGuys guy = new DbGuys();
            guy.UserId = StateClass.CurrentUser.UserId;
            guy.CompanyName = teCompanyName.Text;
            guy.LeaderName = teLeaderName.Text;
            guy.Description = teDescription.Text;

            using (IDbConnection db = ComTool.DbFactory.Open())
            {
                db.Insert<DbGuys>(guy);
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
                    listEditedRowIndex = new List<long>();
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEditedRow();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int indexItem=e.RowHandle;
            typeof(DbGuys).GetProperty(e.Column.FieldName).SetValue(TempDbGuys[e.RowHandle],e.Value);
            listEditedRowIndex.Add(e.RowHandle);
            gcGuys.DataSource = TempDbGuys;
        }
        private void SaveEditedRow()
        {
            using (IDbConnection db = ComTool.DbFactory.Open())
            {
                foreach (long index in listEditedRowIndex)
                {
                    db.Update<DbGuys>(TempDbGuys[(int)index]);
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
                    db.DeleteById<DbGuys>(gridView1.GetRowCellValue(index, colGuyId));
                }
                
            }
            LoadData();
        }
    }
}