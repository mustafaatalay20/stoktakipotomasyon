using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace stoktakipotomasyon.Modul_Stok
{
    public partial class frmstokgruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        

        public bool secim = false;
       static int secimid =-1;
        bool edit = false;


        public frmstokgruplari()
        {
            InitializeComponent();
        }

        private void frmstokgruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.tbl_stokgruplarıs
                      select s;
            Liste.DataSource = lst;
        }
        void Temizle()
        {
            txtgrupkodu.Text = "";
            txtgrupadi.Text = "";
           edit = false;
            Listele();
        }
       void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tbl_stokgrupları Grup = new Fonksiyonlar.tbl_stokgrupları();
                Grup.GRUPADI = txtgrupadi.Text;
                Grup.GRUPKODU = txtgrupkodu.Text;
                Grup.GRUPSAVEDATE = DateTime.Now;
                Grup.GRUPSAVEUSER = AnaForm.UserID;
                DB.tbl_stokgruplarıs.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Grup Kaydı Oluşturuldu");
                Temizle();
                
            }
            catch(Exception e)
            {
                Mesajlar.Hata(e);
            }
           
        }

        void Guncelle()
        {
            
           try
            {
                Fonksiyonlar.tbl_stokgrupları Grup = DB.tbl_stokgruplarıs.First(s => s.ID == secimid);
                Grup.GRUPKODU = txtgrupkodu.Text;
                Grup.GRUPADI = txtgrupadi.Text;
                Grup.GRUPEDITUSER = AnaForm.UserID;
                Grup.GRUPEDITDATE = DateTime.Now;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
           catch(Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
    
        void Sil()
        {
           
            try
            {
                DB.tbl_stokgruplarıs.DeleteOnSubmit(DB.tbl_stokgruplarıs.First(s => s.ID == secimid));
                DB.SubmitChanges();
                Temizle(); 

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
            if(Mesajlar.Sil()==DialogResult.Yes)
             Sil();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
             YeniKaydet();
        }

       
       void Sec()
        {
            
            try
            {
                edit = true;
                secimid = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtgrupadi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtgrupkodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
                this.Close();
            }
            catch (Exception)
            {

                edit = false;
                secimid = -1;
            }
         
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           Sec();
           if(secim && secimid>0)
            {
                AnaForm.aktarma=secimid;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(Mesajlar.Guncelle()==DialogResult.Yes)
            Guncelle();
        }

    }
}
