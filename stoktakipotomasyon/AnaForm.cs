using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace stoktakipotomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public static int UserID = -1;
        public static int aktarma = -1;
   
        public AnaForm()
        {
            InitializeComponent();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
        }

        private void barbtnstokkarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void barbtnstoklistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void barbtnstokgruplari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void barbtnstokhareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void barbtncariaciliskarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void barbtncarigruplari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void barbtncarilistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void barbtncarihareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barbtnkasaaciliskarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void barbtnkasalistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void barbtnkasadevirislemkarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.KasaDevirİslemKarti();
        }

        private void barbtnkasatahsilatodeme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void barbtnkasahareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        private void barbtnbankaaciliskarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void barbtnbankaislemi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.BankaIslem();
        }
    }
}
