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
    public partial class frmcarigruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();


        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;

        public frmcarigruplari()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtgrupadi.Text = "";
            txtgrupkodu.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.tbl_carigruplaris
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtgrupadi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtgrupkodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
               this.Close();
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tbl_carigruplari grup = new Fonksiyonlar.tbl_carigruplari();
                grup.GRUPADI = txtgrupadi.Text;
                grup.GRUPKODU = txtgrupkodu.Text;
                grup.SAVEDATE = DateTime.Now;
                grup.SAVEUSER = AnaForm.UserID;
                DB.tbl_carigruplaris.InsertOnSubmit(grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Cari Grup Kaydı Oluşturuldu");
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
                Fonksiyonlar.tbl_carigruplari grup = DB.tbl_carigruplaris.First(s => s.ID == SecimID);
                grup.GRUPADI = txtgrupadi.Text;
                grup.GRUPKODU = txtgrupkodu.Text;
                grup.EDITDATE = DateTime.Now;
                grup.EDITUSER = AnaForm.UserID;
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
                DB.tbl_carigruplaris.DeleteOnSubmit(DB.tbl_carigruplaris.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sil() == DialogResult.Yes)
                Sil();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Guncelle() == DialogResult.Yes)
                Guncelle();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcarigruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.aktarma = SecimID;
            }
        }
    }
}