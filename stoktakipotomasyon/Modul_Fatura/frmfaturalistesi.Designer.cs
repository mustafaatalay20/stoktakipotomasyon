namespace stoktakipotomasyon.Modul_Fatura
{
    partial class frmfaturalistesi
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
            this.BARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STOKADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtstokadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtstokkodu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtbarkod = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokadi.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarkod.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarkod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BARKOD
            // 
            this.BARKOD.Caption = "BARKOD";
            this.BARKOD.FieldName = "BARKOD";
            this.BARKOD.Name = "BARKOD";
            this.BARKOD.OptionsColumn.AllowEdit = false;
            this.BARKOD.OptionsColumn.AllowFocus = false;
            this.BARKOD.OptionsColumn.FixedWidth = true;
            this.BARKOD.Visible = true;
            this.BARKOD.VisibleIndex = 2;
            // 
            // STOKKODU
            // 
            this.STOKKODU.Caption = "STOK KODU";
            this.STOKKODU.FieldName = "STOKKODU";
            this.STOKKODU.Name = "STOKKODU";
            this.STOKKODU.OptionsColumn.AllowEdit = false;
            this.STOKKODU.OptionsColumn.AllowFocus = false;
            this.STOKKODU.OptionsColumn.FixedWidth = true;
            this.STOKKODU.Visible = true;
            this.STOKKODU.VisibleIndex = 0;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STOKKODU,
            this.STOKADI,
            this.BARKOD});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // STOKADI
            // 
            this.STOKADI.Caption = "STOK ADI";
            this.STOKADI.FieldName = "STOKADI";
            this.STOKADI.Name = "STOKADI";
            this.STOKADI.OptionsColumn.AllowEdit = false;
            this.STOKADI.OptionsColumn.AllowFocus = false;
            this.STOKADI.OptionsColumn.FixedWidth = true;
            this.STOKADI.Visible = true;
            this.STOKADI.VisibleIndex = 1;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(949, 625);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnsil
            // 
            this.btnsil.Image = global::stoktakipotomasyon.Properties.Resources.Sil32x32;
            this.btnsil.Location = new System.Drawing.Point(114, 168);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(83, 45);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Temizle";
            // 
            // btnara
            // 
            this.btnara.Image = global::stoktakipotomasyon.Properties.Resources.Ara32x32;
            this.btnara.Location = new System.Drawing.Point(11, 168);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(83, 45);
            this.btnara.TabIndex = 2;
            this.btnara.Text = "Ara";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tarih";
            // 
            // txtstokadi
            // 
            this.txtstokadi.Location = new System.Drawing.Point(11, 83);
            this.txtstokadi.Name = "txtstokadi";
            this.txtstokadi.Size = new System.Drawing.Size(148, 20);
            this.txtstokadi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Fatura No";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fatura Türü";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnsil);
            this.xtraTabPage1.Controls.Add(this.btnara);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtstokadi);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtstokkodu);
            this.xtraTabPage1.Controls.Add(this.txtbarkod);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(214, 597);
            this.xtraTabPage1.Text = "Arama";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(220, 625);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1174, 625);
            this.splitContainerControl1.SplitterPosition = 220;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // txtstokkodu
            // 
            this.txtstokkodu.EditValue = "Satış Faturası";
            this.txtstokkodu.Location = new System.Drawing.Point(11, 38);
            this.txtstokkodu.Name = "txtstokkodu";
            this.txtstokkodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtstokkodu.Properties.Items.AddRange(new object[] {
            "Satış Faturası",
            "Satış İade Faturası",
            "Alış Faturası",
            "Alış İade Faturası"});
            this.txtstokkodu.Size = new System.Drawing.Size(148, 20);
            this.txtstokkodu.TabIndex = 1;
            // 
            // txtbarkod
            // 
            this.txtbarkod.EditValue = null;
            this.txtbarkod.Location = new System.Drawing.Point(11, 129);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtbarkod.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtbarkod.Properties.DisplayFormat.FormatString = "";
            this.txtbarkod.Properties.EditFormat.FormatString = "";
            this.txtbarkod.Properties.Mask.EditMask = "";
            this.txtbarkod.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtbarkod.Size = new System.Drawing.Size(148, 20);
            this.txtbarkod.TabIndex = 1;
            // 
            // frmfaturalistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 625);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmfaturalistesi";
            this.Text = "frmfaturalistesi";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokadi.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtstokkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarkod.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarkod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn BARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtstokadi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.ComboBoxEdit txtstokkodu;
        private DevExpress.XtraEditors.DateEdit txtbarkod;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}