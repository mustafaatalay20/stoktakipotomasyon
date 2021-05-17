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

namespace stoktakipotomasyon.Modul_Cari
{
    public partial class frmcariaciliskarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar=new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();


        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;


        public frmcariaciliskarti()
        {
            InitializeComponent();
        }

        private void frmcariaciliskarti_Load(object sender, EventArgs e)
        {
            txtcarikodu.Text = Numaralar.carikodnumarası();
        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";

            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";
            txtcarikodu.Text = Numaralar.carikodnumarası();
            Edit = false;
            CariID = -1;
            GrupID = -1;
            AnaForm.aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tbl_cariler Cari = new Fonksiyonlar.tbl_cariler();
                Cari.ADRES = txtadres.Text;
                Cari.CARİADI = txtcariadi.Text;
                Cari.CARİKODU = txtcarikodu.Text;
                Cari.FAX1 = txtfax1.Text;
                Cari.FAX2 = txtfax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtilce.Text;
                Cari.EPOSTA = txteposta.Text;
                Cari.SEHIR = txtsehir.Text;
                Cari.TELEFON1 = txttelefon1.Text;
                Cari.TELEFON2 = txttelefon2.Text;
                Cari.ULKE = txtulke.Text;
                Cari.VERGİDAİRESİ = txtvergidairesi.Text;
                Cari.VERGİNO = txtvergino.Text;
                Cari.WEBADRES = txtwebadres.Text;
                Cari.YETKILI1 = txtyetkili1.Text;
                Cari.YETKILI2 = txtyetkili2.Text;
                Cari.YETKILI1EPOSTA = txtyetkili1eposta.Text;
                Cari.YETKILI2EPOSTA = txtyetkili2eposta.Text;
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                DB.tbl_carilers.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Cari Kaydı Oluşturuldu");
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
                Fonksiyonlar.tbl_cariler Cari = DB.tbl_carilers.First(s => s.ID == CariID);
                Cari.ADRES = txtadres.Text;
                Cari.CARİADI = txtcariadi.Text;
                Cari.CARİKODU = txtcarikodu.Text;
                Cari.FAX1 = txtfax1.Text;
                Cari.FAX2 = txtfax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtilce.Text;
                Cari.EPOSTA = txteposta.Text;
                Cari.SEHIR = txtsehir.Text;
                Cari.TELEFON1 = txttelefon1.Text;
                Cari.TELEFON2 = txttelefon2.Text;
                Cari.ULKE = txtulke.Text;
                Cari.VERGİDAİRESİ = txtvergidairesi.Text;
                Cari.VERGİNO = txtvergino.Text;
                Cari.WEBADRES = txtwebadres.Text;
                Cari.YETKILI1 = txtyetkili1.Text;
                Cari.YETKILI2 = txtyetkili2.Text;
                Cari.YETKILI1EPOSTA = txtyetkili1eposta.Text;
                Cari.YETKILI2EPOSTA = txtyetkili2eposta.Text;
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
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
                DB.tbl_carilers.DeleteOnSubmit(DB.tbl_carilers.First(s => s.ID == CariID));
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
                Edit = true;
                CariID = ID;
                Fonksiyonlar.tbl_cariler Cari = DB.tbl_carilers.First(s => s.ID == CariID);
                txtadres.Text = Cari.ADRES;
                txtcariadi.Text = Cari.CARİADI;
                txtcarikodu.Text = Cari.CARİKODU;
                txtfax1.Text = Cari.FAX1;
                txtfax2.Text = Cari.FAX2;
                txtilce.Text = Cari.ILCE;
                txteposta.Text = Cari.EPOSTA;
                txtsehir.Text = Cari.SEHIR;
                txttelefon1.Text = Cari.TELEFON1;
                txttelefon2.Text = Cari.TELEFON2;
                txtulke.Text = Cari.ULKE;
                txtvergidairesi.Text = Cari.VERGİDAİRESİ;
                txtvergino.Text = Cari.VERGİNO;
                txtwebadres.Text = Cari.WEBADRES;
                txtyetkili1.Text = Cari.YETKILI1;
                txtyetkili2.Text = Cari.YETKILI2;
                txtyetkili1eposta.Text = Cari.YETKILI1EPOSTA;
                txtyetkili2eposta.Text = Cari.YETKILI2EPOSTA;
                GrupAc(Cari.GRUPID.Value);
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            try
            {
                GrupID=ID;
                txtcarigrupadi.Text = DB.tbl_carigruplaris.First(s => s.ID == GrupID).GRUPADI;
                txtcarigrupkodu.Text = DB.tbl_carigruplaris.First(s => s.ID == GrupID).GRUPKODU;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sil() == DialogResult.Yes)
                Sil();
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

        private void txtcarigrupkodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariGruplari(true);
            if(ID > 0)
            {
                GrupAc(ID);
            }
            AnaForm.aktarma = -1;
        }

        private void txtcarikodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if(ID > 0)
            {
                Ac(ID);
            }
            AnaForm.aktarma = -1;
        }
    }
}