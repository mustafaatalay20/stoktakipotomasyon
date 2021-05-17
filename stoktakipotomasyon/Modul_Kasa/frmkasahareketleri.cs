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
    public partial class frmkasahareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int HareketID = -1;
        int EvrakID = -1;
        int KasaID = -1;
        string EvrakTURU;
  
        public frmkasahareketleri()
        {
            InitializeComponent();
        }

        private void frmkasahareketleri_Load(object sender, EventArgs e)
        {
                
        }

        public void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                txtkasakodu.Text = DB.tbl_kasalars.First(s => s.ID == KasaID).KASAKODU;
                txtkasaadi.Text = DB.tbl_kasalars.First(s => s.ID == KasaID).KASAADI;
                DurumGetir();
                Listele();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void DurumGetir()
        {
            Fonksiyonlar.vw_kasadurum Kasa = DB.vw_kasadurums.First(s => s.KASAID == KasaID);
            txtgiris.Text = Kasa.GIRIS.Value.ToString();
            txtcikis.Text = Kasa.CIKIS.Value.ToString();
            txtbakiye.Text = Kasa.BAKIYE.Value.ToString();
        }

        void Listele()
        {
            var lst = from s in DB.vw_kasahareketleris
                      where s.KASAID == KasaID
                      select s;
            Liste.DataSource = lst;
        }

        private void txtkasakodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if(ID>0)
            {
                Ac(ID);
                AnaForm.aktarma = -1;
            }
        }

        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                try
                {
                    EvrakID = int.Parse(gridView1.GetFocusedRowCellValue("EVRAKID").ToString());
                }
                catch (Exception)
                {
                    EvrakID = -1;
                }
                EvrakTURU = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception)
            {
                HareketID = -1;
                EvrakID = -1;
                EvrakTURU = "";
            }
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if(EvrakTURU=="Kasa Devir Kartı")
            {
                DevirKartiDuzenle.Enabled = true;
                TahsilatOdemeDuzenle.Enabled = false;
            }
            else if(EvrakTURU=="Kasa Tahsilat" ||EvrakTURU=="Kasa Ödeme")
            {
                DevirKartiDuzenle.Enabled = false;
                TahsilatOdemeDuzenle.Enabled = true;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void DevirKartiDuzenle_Click(object sender, EventArgs e)
        {

        }
    }
}