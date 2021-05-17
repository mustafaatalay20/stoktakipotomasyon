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
    public partial class frmkasaaciliskarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();

        bool Edit = false;
        int SecimID = -1;


        public frmkasaaciliskarti()
        {
            InitializeComponent();
        }

        private void frmkasaaciliskarti_Load(object sender, EventArgs e)
        {
            txtkasakodu.Text = Numaralar.kasakodnumarası();
            Listele();
        }

        void Temizle()
        {
            txtkasakodu.Text = Numaralar.kasakodnumarası();
            txtkasaadi.Text = "";
            txtaciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tbl_kasalar Kasa = new Fonksiyonlar.tbl_kasalar();
            
                Kasa.ACIKLAMA = txtaciklama.Text;
                Kasa.KASAADI = txtkasaadi.Text;
                Kasa.KASAKODU = txtkasakodu.Text;
                Kasa.SAVEDATE = DateTime.Now;
                Kasa.SAVEUSER = AnaForm.UserID;
                DB.tbl_kasalars.InsertOnSubmit(Kasa);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kasa Kaydı Oluşturulmuştur");
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
                Fonksiyonlar.tbl_kasalar Kasa = DB.tbl_kasalars.First(s => s.ID == SecimID);
                Kasa.ACIKLAMA = txtaciklama.Text;
                Kasa.KASAADI = txtkasaadi.Text;
                Kasa.KASAKODU = txtkasakodu.Text;
                Kasa.EDITDATE = DateTime.Now;
                Kasa.EDITUSER = AnaForm.UserID;
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
                DB.tbl_kasalars.DeleteOnSubmit(DB.tbl_kasalars.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtkasakodu.Text = gridView1.GetFocusedRowCellValue("KASAKODU").ToString();
                txtkasaadi.Text = gridView1.GetFocusedRowCellValue("KASAADI").ToString();
                txtaciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString(); 
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void Listele()
        {
            var lst = from s in DB.tbl_kasalars
                      select s;
            Liste.DataSource = lst;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if(txtkasaadi.Text!=""&&txtaciklama.Text!="")
            {
                YeniKaydet();
            }
            else
            {
                MessageBox.Show("Kasa Adı ve Açıklama Girilmesi Gereklidir", "İşlem Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}