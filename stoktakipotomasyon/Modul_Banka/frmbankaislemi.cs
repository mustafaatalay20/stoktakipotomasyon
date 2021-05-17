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


namespace stoktakipotomasyon.Modul_Banka
{
    public partial class frmbankaislemi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar=new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;
        public frmbankaislemi()
        {
            InitializeComponent();
        }

        private void frmbankaislemi_Load(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.tbl_bankahareketleri Hareket = DB.tbl_bankahareketleris.First(s => s.ID == IslemID);
                BankaAc(Hareket.BANKAID.Value);
                txtaciklama.Text = Hareket.ACIKLAMA;
                txtbelgeno.Text = Hareket.BELGENO;
                txttarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txttutar.Text = Hareket.TUTAR.ToString();
                if (Hareket.GCKODU == "G") rbtngiris.Checked = true;
                if (Hareket.GCKODU == "C") rbtncikis.Checked = true;

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txthesapadi.Text = DB.tbl_bankalars.First(s => s.ID == BankaID).HESAPADI;
                txthesapno.Text = DB.tbl_bankalars.First(s => s.ID == BankaID).HESAPNO;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Temizle()
        {
            txtaciklama.Text = "";
            txtbelgeno.Text = "";
            txthesapadi.Text = "";
            txthesapno.Text = "";
            txttarih.Text = DateTime.Now.ToShortDateString();
            txttutar.Text = "";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            AnaForm.aktarma = -1;
        }

        void YeniKayit()
        {
            try
            {
                Fonksiyonlar.tbl_bankahareketleri Hareket = new Fonksiyonlar.tbl_bankahareketleri();
                Hareket.ACIKLAMA = txtaciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtbelgeno.Text;
                Hareket.EVRAKTURU = "Banka İşlem";
                if (rbtngiris.Checked) Hareket.GCKODU = "G";
                if (rbtncikis.Checked) Hareket.GCKODU = "C";
                Hareket.TARIH = DateTime.Parse(txttarih.Text);
                Hareket.TUTAR = decimal.Parse(txttutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.tbl_bankahareketleris.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Banka İşlemi Kaydı Yapılmıştır.");
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.tbl_bankahareketleri Hareket = DB.tbl_bankahareketleris.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtaciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtbelgeno.Text;
                Hareket.EVRAKTURU = "Banka İşlem";
                if (rbtngiris.Checked) Hareket.GCKODU = "G";
                if (rbtncikis.Checked) Hareket.GCKODU = "C";
                Hareket.TARIH = DateTime.Parse(txttarih.Text);
                Hareket.TUTAR = decimal.Parse(txttutar.Text);
                Hareket.EDITDATE = DateTime.Now;
                Hareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Sil()
        {
            try
            {
                DB.tbl_bankahareketleris.DeleteOnSubmit(DB.tbl_bankahareketleris.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void txthesapadi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
        }
    }
}