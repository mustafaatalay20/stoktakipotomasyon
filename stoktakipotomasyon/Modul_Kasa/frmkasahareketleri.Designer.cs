namespace stoktakipotomasyon.Modul_Kasa
{
    partial class frmkasahareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkasahareketleri));
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtbakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtcikis = new DevExpress.XtraEditors.TextEdit();
            this.txtgiris = new DevExpress.XtraEditors.TextEdit();
            this.txtkasaadi = new DevExpress.XtraEditors.TextEdit();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKTURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtkasakodu = new DevExpress.XtraEditors.ButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DevirKartiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TahsilatOdemeDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtbakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasaadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasakodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SagTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 4;
            this.ACIKLAMA.Width = 605;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(222, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Bakiye :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(144, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Çıkış :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Giriş :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kasa Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kasa Kodu :";
            // 
            // txtbakiye
            // 
            this.txtbakiye.Location = new System.Drawing.Point(264, 75);
            this.txtbakiye.Name = "txtbakiye";
            this.txtbakiye.Properties.ReadOnly = true;
            this.txtbakiye.Size = new System.Drawing.Size(38, 20);
            this.txtbakiye.TabIndex = 0;
            // 
            // txtcikis
            // 
            this.txtcikis.Location = new System.Drawing.Point(178, 75);
            this.txtcikis.Name = "txtcikis";
            this.txtcikis.Properties.ReadOnly = true;
            this.txtcikis.Size = new System.Drawing.Size(38, 20);
            this.txtcikis.TabIndex = 0;
            // 
            // txtgiris
            // 
            this.txtgiris.Location = new System.Drawing.Point(99, 75);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.Properties.ReadOnly = true;
            this.txtgiris.Size = new System.Drawing.Size(38, 20);
            this.txtgiris.TabIndex = 0;
            // 
            // txtkasaadi
            // 
            this.txtkasaadi.Location = new System.Drawing.Point(99, 49);
            this.txtkasaadi.Name = "txtkasaadi";
            this.txtkasaadi.Properties.ReadOnly = true;
            this.txtkasaadi.Size = new System.Drawing.Size(203, 20);
            this.txtkasaadi.TabIndex = 0;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 2;
            // 
            // EVRAKID
            // 
            this.EVRAKID.Caption = "EVRAK ID";
            this.EVRAKID.FieldName = "EVRAKID";
            this.EVRAKID.Name = "EVRAKID";
            // 
            // EVRAKTURU
            // 
            this.EVRAKTURU.Caption = "EVRAK TÜRÜ";
            this.EVRAKTURU.FieldName = "EVRAKTURU";
            this.EVRAKTURU.Name = "EVRAKTURU";
            this.EVRAKTURU.OptionsColumn.AllowEdit = false;
            this.EVRAKTURU.OptionsColumn.AllowFocus = false;
            this.EVRAKTURU.OptionsColumn.FixedWidth = true;
            this.EVRAKTURU.Visible = true;
            this.EVRAKTURU.VisibleIndex = 1;
            this.EVRAKTURU.Width = 100;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGE NO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            this.BELGENO.Width = 100;
            // 
            // txtkasakodu
            // 
            this.txtkasakodu.Location = new System.Drawing.Point(99, 23);
            this.txtkasakodu.Name = "txtkasakodu";
            this.txtkasakodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtkasakodu.Properties.ReadOnly = true;
            this.txtkasakodu.Size = new System.Drawing.Size(203, 20);
            this.txtkasakodu.TabIndex = 0;
            this.txtkasakodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtkasakodu_ButtonClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BELGENO,
            this.EVRAKTURU,
            this.EVRAKID,
            this.GIRIS,
            this.CIKIS,
            this.ACIKLAMA});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 3;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(2, 20);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1025, 453);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 114);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1029, 475);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtbakiye);
            this.groupControl1.Controls.Add(this.txtcikis);
            this.groupControl1.Controls.Add(this.txtgiris);
            this.groupControl1.Controls.Add(this.txtkasaadi);
            this.groupControl1.Controls.Add(this.txtkasakodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1029, 114);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // SagTik
            // 
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DevirKartiDuzenle,
            this.TahsilatOdemeDuzenle});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(246, 70);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            // 
            // DevirKartiDuzenle
            // 
            this.DevirKartiDuzenle.Enabled = false;
            this.DevirKartiDuzenle.Name = "DevirKartiDuzenle";
            this.DevirKartiDuzenle.Size = new System.Drawing.Size(245, 22);
            this.DevirKartiDuzenle.Text = "Devir İşlem Kartını Düzenle";
            this.DevirKartiDuzenle.Click += new System.EventHandler(this.DevirKartiDuzenle_Click);
            // 
            // TahsilatOdemeDuzenle
            // 
            this.TahsilatOdemeDuzenle.Enabled = false;
            this.TahsilatOdemeDuzenle.Name = "TahsilatOdemeDuzenle";
            this.TahsilatOdemeDuzenle.Size = new System.Drawing.Size(245, 22);
            this.TahsilatOdemeDuzenle.Text = "Tahsilat Ödeme İşlemini Düzenle";
            // 
            // frmkasahareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 589);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmkasahareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.frmkasahareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtbakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasaadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasakodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.SagTik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtbakiye;
        private DevExpress.XtraEditors.TextEdit txtcikis;
        private DevExpress.XtraEditors.TextEdit txtgiris;
        private DevExpress.XtraEditors.TextEdit txtkasaadi;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKID;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKTURU;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraEditors.ButtonEdit txtkasakodu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem DevirKartiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TahsilatOdemeDuzenle;
    }
}