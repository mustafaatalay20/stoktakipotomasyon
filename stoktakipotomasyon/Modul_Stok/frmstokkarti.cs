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

namespace stoktakipotomasyon.Modul_Stok
{
    public partial class frmstokkarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();

        bool Edit = false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int GrupID = -1;
        int StokID = -1;
        public frmstokkarti()
        {
            InitializeComponent();
        }

        private void frmstokkarti_Load(object sender, EventArgs e)
        {
            txtstokkodu.Text=Numaralar.stokkodnumarası();
        }

        void Temizle()
        {
            txtstokkodu.Text = Numaralar.stokkodnumarası();
            txtstokadi.Text = "";
            txtsatiskdv.Text = "0";
            txtsatisfiyat.Text = "0";
            txtgrupkodu.Text = "";
            txtgrupadi.Text = "";
            txtbirim.SelectedIndex = 0;
            txtbarkod.Text = "";
            txtaliskdv.Text = "0";
            txtalisfiyat.Text = "0";
            pictureBox1.Image = null;
            Edit = false;
            Resim = false;
            GrupID = -1;
            StokID = -1;
            AnaForm.aktarma = -1;
        }

        void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg|*.jpeg|Png(*.png)|*.png";
            if(Dosya.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tbl_stoklar Stok = new Fonksiyonlar.tbl_stoklar();
                Stok.STOKADI = txtstokadi.Text;
                Stok.STOKALISFIYAT = decimal.Parse(txtalisfiyat.Text);
                Stok.STOKALISKDV = decimal.Parse(txtaliskdv.Text);
                Stok.BARKOD = txtbarkod.Text;
                Stok.STOKBIRIM = txtbirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtstokkodu.Text;
                Stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYAT = decimal.Parse(txtsatisfiyat.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtsatiskdv.Text);
                Stok.STOKSAVEDATE = DateTime.Now;
                Stok.STOKSAVEUSER = AnaForm.UserID;
                DB.tbl_stoklars.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kayıt Oluşturuldu");
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
                Mesajlar.Guncelle(true);
                Fonksiyonlar.tbl_stoklar Stok = DB.tbl_stoklars.First(s => s.ID == StokID);
                Stok.STOKADI = txtstokadi.Text;
                Stok.STOKALISFIYAT = decimal.Parse(txtalisfiyat.Text);
                Stok.STOKALISKDV = decimal.Parse(txtaliskdv.Text);
                Stok.BARKOD = txtbarkod.Text;
                Stok.STOKBIRIM = txtbirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtstokkodu.Text;
               if(Resim) Stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                Stok.STOKSATISFIYAT = decimal.Parse(txtsatisfiyat.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtsatiskdv.Text);
                Stok.STOKEDITDATE = DateTime.Now;
                Stok.STOKEDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
               
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
               
                DB.tbl_stoklars.DeleteOnSubmit(DB.tbl_stoklars.First(s => s.ID == StokID));
                DB.SubmitChanges();
                Temizle();

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            GrupID = ID;
            txtgrupadi.Text = DB.tbl_stokgruplarıs.First(s => s.ID == GrupID).GRUPADI;
            txtgrupkodu.Text = DB.tbl_stokgruplarıs.First(s => s.ID == GrupID).GRUPKODU;
        }

        public void Ac(int ID)
        {
            StokID = ID;
            Fonksiyonlar.tbl_stoklar Stok = DB.tbl_stoklars.First(s => s.ID == StokID);
            GrupAc(Stok.STOKGRUPID.Value);
            pictureBox1.Image = Resimleme.ResimGetirme(Stok.STOKRESIM.ToArray());
            txtalisfiyat.Text = Stok.STOKALISFIYAT.ToString();
            txtaliskdv.Text = Stok.STOKALISKDV.ToString();
            txtbarkod.Text = Stok.BARKOD;
            txtbirim.Text = Stok.STOKBIRIM;
            txtsatisfiyat.Text = Stok.STOKSATISFIYAT.ToString();
            txtsatiskdv.Text = Stok.STOKSATISKDV.ToString();
            txtstokadi.Text = Stok.STOKADI;
            txtstokkodu.Text = Stok.STOKKODU;
        }

        private void txtstokkodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID>0)
            {
                Ac(ID);
            }
            AnaForm.aktarma = -1;
        }

        private void txtgrupkodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ıd = Formlar.StokGruplari(true);
            if(ıd>0)
            {
               GrupAc(ıd);
            }
            AnaForm.aktarma = -1;
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

       
    }
}