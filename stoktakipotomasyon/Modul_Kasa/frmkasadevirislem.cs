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

namespace stoktakipotomasyon.Modul_Kasa
{
    public partial class frmkasadevirislem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public string KASAADI { get; set; }
        public string KASAKODU { get; set; }

        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;


        public frmkasadevirislem()
        {
            InitializeComponent();
        }

        private void frmkasadevirislem_Load(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
            txtacıklama.Text = "";
            txtbelgemakbuzno.Text = "";
            txtkasaadı.Text = "";
            txtkasakodu.Text = "";
            txttutar.Text = "0";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tbl_kasahareketleri Hareket = new Fonksiyonlar.tbl_kasahareketleri();
                Hareket.ACIKLAMA = txtacıklama.Text;
                Hareket.BELGENO = txtbelgemakbuzno.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtncıkıs.Checked) Hareket.GCKODU = "C";
                if (rbtngiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txttarih.Text);
                Hareket.TUTAR = decimal.Parse(txttutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.tbl_kasahareketleris.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Devir Kartı Hareket Kaydı İşlenmiştir.");
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
                Fonksiyonlar.tbl_kasahareketleri Hareket = DB.tbl_kasahareketleris.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtacıklama.Text;
                Hareket.BELGENO = txtbelgemakbuzno.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtncıkıs.Checked) Hareket.GCKODU = "C";
                if (rbtngiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
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
                DB.tbl_kasahareketleris.DeleteOnSubmit(DB.tbl_kasahareketleris.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyonlar.tbl_kasahareketleri Hareket = DB.tbl_kasahareketleris.First(s => s.ID == IslemID);
                txtacıklama.Text = Hareket.ACIKLAMA;
                txtbelgemakbuzno.Text = Hareket.BELGENO;
                KasaAc(Hareket.KASAID.Value);
                txttarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txttutar.Text = Hareket.TUTAR.Value.ToString();
                if (Hareket.GCKODU == "G") rbtngiris.Checked = true;
                if (Hareket.GCKODU == "C") rbtncıkıs.Checked = true;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtkasaadı.Text = DB.tbl_kasalars.First(s => s.ID == KasaID).KASAADI;
                txtkasakodu.Text = DB.tbl_kasalars.First(s => s.ID == KasaID).KASAKODU;
                
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Guncelle() == DialogResult.Yes)
                Guncelle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sil() == DialogResult.Yes)
                Sil();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtkasakodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.KasaListesi(true);
            if(Id > 0)
            {
                KasaAc(Id);
            }
            AnaForm.aktarma = -1;
        }
    }
}