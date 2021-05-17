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
    public partial class frmbankaaciliskarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        bool Edit = false;
        int SecimID = -1;

        public frmbankaaciliskarti()
        {
            InitializeComponent();
        }

        private void frmbankaaciliskarti_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Temizle()
        {
            txtadres.Text = "";
            txtbankaadi.Text = "";
            txthesapturuadi.Text = "";
            txthesapno.Text = "";
            txtiban.Text = "";
            txtbankasube.Text = "";
            txtsubetel.Text = "";
            txtyetkilitemsilci.Text = "";
            txtyetkilitemsilciemail.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.tbl_bankalars
                      select s;
            Liste.DataSource = lst;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tbl_bankalar Banka = new Fonksiyonlar.tbl_bankalar();
                Banka.ADRES = txtadres.Text;
                Banka.BANKAADI = txtbankaadi.Text;
                Banka.HESAPADI = txthesapturuadi.Text;
                Banka.HESAPNO = txthesapno.Text;
                Banka.IBAN = txtiban.Text;
                Banka.SUBE = txtbankasube.Text;
                Banka.TEL = txtsubetel.Text;
                Banka.TEMSILCI = txtyetkilitemsilci.Text;
                Banka.TEMSILCIEMAIL = txtyetkilitemsilciemail.Text;
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                DB.tbl_bankalars.InsertOnSubmit(Banka);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Banka Kaydı Açılmıştır.");
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
                Fonksiyonlar.tbl_bankalar Banka = DB.tbl_bankalars.First(s => s.ID == SecimID);
                Banka.ADRES = txtadres.Text;
                Banka.BANKAADI = txtbankaadi.Text;
                Banka.HESAPADI = txthesapturuadi.Text;
                Banka.HESAPNO = txthesapno.Text;
                Banka.IBAN = txtiban.Text;
                Banka.SUBE = txtbankasube.Text;
                Banka.TEL = txtsubetel.Text;
                Banka.TEMSILCI = txtyetkilitemsilci.Text;
                Banka.TEMSILCIEMAIL = txtyetkilitemsilciemail.Text;
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;
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
                DB.tbl_bankalars.DeleteOnSubmit(DB.tbl_bankalars.First(s => s.ID == SecimID));
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
                if (SecimID > 0) Ac();
                
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void Ac()
        {
            try
            {
                Fonksiyonlar.tbl_bankalar Banka = DB.tbl_bankalars.First(s => s.ID == SecimID);
                txtadres.Text = Banka.ADRES;
                txtbankaadi.Text = Banka.BANKAADI;
                txthesapturuadi.Text = Banka.HESAPADI;
                txthesapno.Text = Banka.HESAPNO;
                txtiban.Text = Banka.IBAN;
                txtbankasube.Text = Banka.SUBE;
                txtsubetel.Text = Banka.TEL;
                txtyetkilitemsilci.Text = Banka.TEMSILCI;
                txtyetkilitemsilciemail.Text = Banka.TEMSILCIEMAIL;
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

     
    }
}