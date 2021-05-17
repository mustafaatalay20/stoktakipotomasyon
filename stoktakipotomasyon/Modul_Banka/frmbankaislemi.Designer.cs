namespace stoktakipotomasyon.Modul_Banka
{
    partial class frmbankaislemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbankaislemi));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rbtngiris = new System.Windows.Forms.RadioButton();
            this.rbtncikis = new System.Windows.Forms.RadioButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txttutar = new DevExpress.XtraEditors.TextEdit();
            this.txttarih = new DevExpress.XtraEditors.TextEdit();
            this.txtaciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txthesapadi = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txthesapno = new DevExpress.XtraEditors.TextEdit();
            this.txtbelgeno = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthesapadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesapno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbelgeno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl2);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txttutar);
            this.groupControl3.Controls.Add(this.txttarih);
            this.groupControl3.Controls.Add(this.txtaciklama);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 199);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(386, 194);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "İşlem Bilgileri";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rbtngiris);
            this.groupControl2.Controls.Add(this.rbtncikis);
            this.groupControl2.Location = new System.Drawing.Point(265, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(111, 80);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "İşlem Türü";
            // 
            // rbtngiris
            // 
            this.rbtngiris.AutoSize = true;
            this.rbtngiris.Location = new System.Drawing.Point(6, 23);
            this.rbtngiris.Name = "rbtngiris";
            this.rbtngiris.Size = new System.Drawing.Size(75, 17);
            this.rbtngiris.TabIndex = 0;
            this.rbtngiris.TabStop = true;
            this.rbtngiris.Text = "Giriş İşlemi";
            this.rbtngiris.UseVisualStyleBackColor = true;
            // 
            // rbtncikis
            // 
            this.rbtncikis.AutoSize = true;
            this.rbtncikis.Location = new System.Drawing.Point(5, 46);
            this.rbtncikis.Name = "rbtncikis";
            this.rbtncikis.Size = new System.Drawing.Size(76, 17);
            this.rbtncikis.TabIndex = 0;
            this.rbtncikis.TabStop = true;
            this.rbtncikis.Text = "Çıkış İşlemi";
            this.rbtncikis.UseVisualStyleBackColor = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Açıklama :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 71);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Tutar :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Tarih :";
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(105, 68);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(154, 20);
            this.txttutar.TabIndex = 3;
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(105, 42);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(154, 20);
            this.txttarih.TabIndex = 3;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(105, 109);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(271, 63);
            this.txtaciklama.TabIndex = 3;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Image = global::stoktakipotomasyon.Properties.Resources.guncelle;
            this.btnguncelle.Location = new System.Drawing.Point(280, 65);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(96, 35);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.Image = global::stoktakipotomasyon.Properties.Resources.Kapat24x24;
            this.btnkapat.Location = new System.Drawing.Point(280, 147);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(96, 35);
            this.btnkapat.TabIndex = 0;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnsil
            // 
            this.btnsil.Image = global::stoktakipotomasyon.Properties.Resources.Sil24x24;
            this.btnsil.Location = new System.Drawing.Point(280, 106);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(96, 35);
            this.btnsil.TabIndex = 0;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Image = global::stoktakipotomasyon.Properties.Resources.Kaydet24x24;
            this.btnkaydet.Location = new System.Drawing.Point(280, 26);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(96, 35);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txthesapadi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txthesapno);
            this.groupControl1.Controls.Add(this.txtbelgeno);
            this.groupControl1.Controls.Add(this.btnkapat);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(386, 199);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Temel Bilgiler";
            // 
            // txthesapadi
            // 
            this.txthesapadi.Location = new System.Drawing.Point(105, 80);
            this.txthesapadi.Name = "txthesapadi";
            this.txthesapadi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txthesapadi.Size = new System.Drawing.Size(169, 20);
            this.txthesapadi.TabIndex = 5;
            this.txthesapadi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txthesapadi_ButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hesap No :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Hesap Adı/Türü :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Belge No :";
            // 
            // txthesapno
            // 
            this.txthesapno.Location = new System.Drawing.Point(105, 106);
            this.txthesapno.Name = "txthesapno";
            this.txthesapno.Size = new System.Drawing.Size(169, 20);
            this.txthesapno.TabIndex = 3;
            // 
            // txtbelgeno
            // 
            this.txtbelgeno.Location = new System.Drawing.Point(105, 54);
            this.txtbelgeno.Name = "txtbelgeno";
            this.txtbelgeno.Size = new System.Drawing.Size(169, 20);
            this.txtbelgeno.TabIndex = 3;
            // 
            // frmbankaislemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 393);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbankaislemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka İşlem";
            this.Load += new System.EventHandler(this.frmbankaislemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthesapadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesapno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbelgeno.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtbelgeno;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rbtngiris;
        private System.Windows.Forms.RadioButton rbtncikis;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txttutar;
        private DevExpress.XtraEditors.TextEdit txttarih;
        private DevExpress.XtraEditors.MemoEdit txtaciklama;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txthesapno;
        private DevExpress.XtraEditors.ButtonEdit txthesapadi;
    }
}