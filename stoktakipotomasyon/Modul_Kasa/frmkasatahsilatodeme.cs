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
    public partial class frmkasatahsilatodeme : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();


        bool Edit = false;
        int IslemID = -1;
        int CariHareketID = -1;
        int KasaID = -1;
        int CariID = -1;


        public frmkasatahsilatodeme()
        {
            InitializeComponent();
        }

        private void frmkasatahsilatodeme_Load(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtislemturu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void Temizle()
        {
            txtaciklama.Text = "";
            txtbelgemakbuzno.Text = "";
            txtcariadi.Text = "";
            txtcarikodu.Text = "";
            txtislemturu.SelectedIndex = 0;
            txtkasaadi.Text = "";
            txtkasakodu.Text = "";
            txttarih.Text = DateTime.Now.ToShortDateString();
            txttutar.Text = "0";
            Edit = false;
            IslemID = -1;
            KasaID = -1;
            CariID = -1;
            CariHareketID = -1;
            AnaForm.aktarma = -1;
        }

        public void Ac(int HareketID)
        {
            try
            {
                Edit = true;
                IslemID = HareketID;
                Fonksiyonlar.tbl_kasahareketleri KasaHareketi = DB.tbl_kasahareketleris.First(s => s.ID == IslemID);
                CariHareketID=DB.tbl_carihareketleris.First(s=>s.EVRAKTURU==KasaHareketi.EVRAKTURU && s.EVRAKID==IslemID).ID;
                MessageBox.Show("Cari Hareket ID : " + CariHareketID.ToString());
                txtaciklama.Text = KasaHareketi.ACIKLAMA;
                txtbelgemakbuzno.Text = KasaHareketi.BELGENO;
                if (KasaHareketi.EVRAKTURU == "Kasa Tahsilat") txtislemturu.SelectedIndex = 0;
                if (KasaHareketi.EVRAKTURU == "Kasa Ödeme") txtislemturu.SelectedIndex = 1;
                txttarih.Text = KasaHareketi.TARIH.Value.ToShortDateString();
                txttutar.Text = KasaHareketi.TUTAR.Value.ToString();
                KasaAc(KasaHareketi.KASAID.Value);
                CariAc(KasaHareketi.CARIID.Value);
            }
            catch (Exception e)
            {
                Temizle();
                Mesajlar.Hata(e);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                
                KasaID = ID;
                txtkasaadi.Text = DB.tbl_kasalars.First(s => s.ID == KasaID).KASAADI;
                txtkasakodu.Text = DB.tbl_kasalars.First(s => s.ID == KasaID).KASAKODU;
            }
            catch (Exception)
            {
                KasaID = -1;
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtcariadi.Text = DB.tbl_carilers.First(s => s.ID == CariID).CARİADI;
                txtcarikodu.Text = DB.tbl_carilers.First(s => s.ID == CariID).CARİKODU;
            }
            catch (Exception)
            {
                CariID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tbl_kasahareketleri KasaHareketi = new Fonksiyonlar.tbl_kasahareketleri();
                KasaHareketi.ACIKLAMA = txtaciklama.Text;
                KasaHareketi.BELGENO = txtbelgemakbuzno.Text;
                KasaHareketi.CARIID = CariID;
                KasaHareketi.EVRAKTURU = txtislemturu.SelectedItem.ToString();
                if (txtislemturu.SelectedIndex == 0) KasaHareketi.GCKODU = "G";
                if (txtislemturu.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = KasaID;
                KasaHareketi.SAVEDATE = DateTime.Now;
                KasaHareketi.SAVEUSER = AnaForm.UserID;
                KasaHareketi.TARIH = DateTime.Parse(txttarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(txttutar.Text);
                DB.tbl_kasahareketleris.InsertOnSubmit(KasaHareketi);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtislemturu.SelectedItem.ToString() + " Yeni Kasa Hareketi Olarak İşlenmiştir.");
                Fonksiyonlar.tbl_carihareketleri CariHareket = new Fonksiyonlar.tbl_carihareketleri();
                CariHareket.ACIKLAMA = txtbelgemakbuzno.Text + " Belge Numaralı" + txtislemturu.SelectedItem.ToString() + " İşlemi";
                if (txtislemturu.SelectedIndex == 0) CariHareket.ALACAK = decimal.Parse(txttutar.Text);
                if (txtislemturu.SelectedIndex == 1) CariHareket.BORC = decimal.Parse(txttutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = KasaHareketi.ID;
                CariHareket.EVRAKTURU = txtislemturu.SelectedItem.ToString();
                CariHareket.TARIH = DateTime.Parse(txttarih.Text);
                if (txtislemturu.SelectedIndex == 0) CariHareket.TIPI = "Kasa Tahsilat";
                if (txtislemturu.SelectedIndex == 1) CariHareket.TIPI = "Kasa Ödeme";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.tbl_carihareketleris.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtislemturu.SelectedItem.ToString() + " Yeni Cari Hareketi Olarak İşlenmiştir.");
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
                Fonksiyonlar.tbl_kasahareketleri KasaHareketi = DB.tbl_kasahareketleris.First(s => s.ID == IslemID);
                KasaHareketi.ACIKLAMA = txtaciklama.Text;
                KasaHareketi.BELGENO = txtbelgemakbuzno.Text;
                KasaHareketi.CARIID = CariID;
                KasaHareketi.EVRAKTURU = txtislemturu.SelectedItem.ToString();
                if (txtislemturu.SelectedIndex == 0) KasaHareketi.GCKODU = "G";
                if (txtislemturu.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = KasaID;
                KasaHareketi.EDITDATE = DateTime.Now;
                KasaHareketi.EDITUSER = AnaForm.UserID;
                KasaHareketi.TARIH = DateTime.Parse(txttarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(txttutar.Text);
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Fonksiyonlar.tbl_carihareketleri CariHareket = DB.tbl_carihareketleris.First(s => s.ID==CariHareketID);
                CariHareket.ACIKLAMA = txtbelgemakbuzno.Text + " Belge Numaralı" + txtislemturu.SelectedItem.ToString() + " İşlemi";
                if (txtislemturu.SelectedIndex == 0) CariHareket.ALACAK = decimal.Parse(txttutar.Text);
                if (txtislemturu.SelectedIndex == 1) CariHareket.BORC = decimal.Parse(txttutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = KasaHareketi.ID;
                CariHareket.EVRAKTURU = txtislemturu.SelectedItem.ToString();
                CariHareket.TARIH = DateTime.Parse(txttarih.Text);
                if (txtislemturu.SelectedIndex == 0) CariHareket.TIPI = "Kasa Tahsilat";
                if (txtislemturu.SelectedIndex == 1) CariHareket.TIPI = "Kasa Ödeme";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
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
                DB.tbl_carihareketleris.DeleteOnSubmit(DB.tbl_carihareketleris.First(s => s.ID == CariHareketID));
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void txtkasakodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            int Id= Formlar.KasaListesi(true);
            if(Id > 0)
            {
                KasaAc(Id);
            }
            AnaForm.aktarma = -1;
        }

        private void txtcarikodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if(Id > 0)
            {
                CariAc(Id);
            }
            AnaForm.aktarma = -1;
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
    }
}