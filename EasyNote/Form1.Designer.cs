namespace EasyNote
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rbsys = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogon = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewNote = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewGuys = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddGuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopyRight = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditUser = new DevExpress.XtraBars.BarButtonItem();
            this.rbPageSys = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSysUser = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSysNote = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGuy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAbout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.frmMainMdiManage = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rbsys)).BeginInit();
            this.backstageViewClientControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainMdiManage)).BeginInit();
            this.SuspendLayout();
            // 
            // rbsys
            // 
            this.rbsys.ExpandCollapseItem.Id = 0;
            this.rbsys.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbsys.ExpandCollapseItem,
            this.btnLogon,
            this.btnChangePassword,
            this.btnLogout,
            this.btnViewNote,
            this.barButtonItem1,
            this.btnViewGuys,
            this.btnAddGuy,
            this.btnAbout,
            this.btnCopyRight,
            this.btnEditUser});
            this.rbsys.Location = new System.Drawing.Point(0, 0);
            this.rbsys.MaxItemId = 6;
            this.rbsys.Name = "rbsys";
            this.rbsys.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPageSys});
            this.rbsys.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.rbsys.Size = new System.Drawing.Size(966, 147);
            this.rbsys.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnLogon
            // 
            this.btnLogon.Caption = "登陆";
            this.btnLogon.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnLogon.Id = 6;
            this.btnLogon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogon.LargeGlyph")));
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogon_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "修改密码";
            this.btnChangePassword.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnChangePassword.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Glyph")));
            this.btnChangePassword.Id = 7;
            this.btnChangePassword.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.LargeGlyph")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "退出";
            this.btnLogout.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.Glyph")));
            this.btnLogout.Id = 8;
            this.btnLogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.LargeGlyph")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnViewNote
            // 
            this.btnViewNote.Caption = "帐目查看";
            this.btnViewNote.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnViewNote.Id = 9;
            this.btnViewNote.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnViewNote.LargeGlyph")));
            this.btnViewNote.Name = "btnViewNote";
            this.btnViewNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewNote_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "添加帐目";
            this.barButtonItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnViewGuys
            // 
            this.btnViewGuys.Caption = "查看伙伴";
            this.btnViewGuys.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnViewGuys.Id = 1;
            this.btnViewGuys.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnViewGuys.LargeGlyph")));
            this.btnViewGuys.Name = "btnViewGuys";
            this.btnViewGuys.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewGuys_ItemClick);
            // 
            // btnAddGuy
            // 
            this.btnAddGuy.Caption = "添加伙伴";
            this.btnAddGuy.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnAddGuy.Id = 2;
            this.btnAddGuy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddGuy.LargeGlyph")));
            this.btnAddGuy.Name = "btnAddGuy";
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "作者";
            this.btnAbout.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnAbout.Id = 3;
            this.btnAbout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAbout.LargeGlyph")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // btnCopyRight
            // 
            this.btnCopyRight.Caption = "版权";
            this.btnCopyRight.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnCopyRight.Id = 4;
            this.btnCopyRight.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCopyRight.LargeGlyph")));
            this.btnCopyRight.Name = "btnCopyRight";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Caption = "用户管理";
            this.btnEditUser.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnEditUser.Id = 5;
            this.btnEditUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditUser.LargeGlyph")));
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewUser_ItemClick);
            // 
            // rbPageSys
            // 
            this.rbPageSys.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSysUser,
            this.rpgSysNote,
            this.rpgGuy,
            this.rpgAbout});
            this.rbPageSys.Name = "rbPageSys";
            this.rbPageSys.Text = "系统";
            // 
            // rpgSysUser
            // 
            this.rpgSysUser.ItemLinks.Add(this.btnLogon);
            this.rpgSysUser.ItemLinks.Add(this.btnLogout);
            this.rpgSysUser.ItemLinks.Add(this.btnChangePassword);
            this.rpgSysUser.ItemLinks.Add(this.btnEditUser);
            this.rpgSysUser.Name = "rpgSysUser";
            this.rpgSysUser.Text = "帐号";
            // 
            // rpgSysNote
            // 
            this.rpgSysNote.ItemLinks.Add(this.barButtonItem1);
            this.rpgSysNote.ItemLinks.Add(this.btnViewNote);
            this.rpgSysNote.Name = "rpgSysNote";
            this.rpgSysNote.Text = "帐目管理";
            // 
            // rpgGuy
            // 
            this.rpgGuy.ItemLinks.Add(this.btnViewGuys);
            this.rpgGuy.ItemLinks.Add(this.btnAddGuy);
            this.rpgGuy.Name = "rpgGuy";
            this.rpgGuy.Text = "伙伴";
            // 
            // rpgAbout
            // 
            this.rpgAbout.ItemLinks.Add(this.btnAbout);
            this.rpgAbout.ItemLinks.Add(this.btnCopyRight);
            this.rpgAbout.Name = "rpgAbout";
            this.rpgAbout.Text = "关于";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "版权：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "labelControl2";
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Controls.Add(this.labelControl2);
            this.backstageViewClientControl1.Controls.Add(this.labelControl1);
            this.backstageViewClientControl1.Location = new System.Drawing.Point(192, 0);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(774, 360);
            this.backstageViewClientControl1.TabIndex = 0;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "关于";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = false;
            // 
            // frmMainMdiManage
            // 
            this.frmMainMdiManage.MdiParent = this;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 507);
            this.Controls.Add(this.rbsys);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.rbsys;
            this.Text = "EasyNote";
            ((System.ComponentModel.ISupportInitialize)(this.rbsys)).EndInit();
            this.backstageViewClientControl1.ResumeLayout(false);
            this.backstageViewClientControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainMdiManage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbsys;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageSys;
        private DevExpress.XtraBars.BarButtonItem btnLogon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnViewNote;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSysUser;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSysNote;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.BarButtonItem btnViewGuys;
        private DevExpress.XtraBars.BarButtonItem btnAddGuy;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraBars.BarButtonItem btnCopyRight;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGuy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAbout;
        private DevExpress.XtraBars.BarButtonItem btnEditUser;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager frmMainMdiManage;
    }
}

