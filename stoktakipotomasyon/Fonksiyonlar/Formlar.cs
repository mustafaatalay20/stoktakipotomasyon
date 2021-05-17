using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoktakipotomasyon.Fonksiyonlar
{
    class Formlar
    {
        #region Stok Formları
        public int StokListesi(bool secim = false)
        {
            Modul_Stok.frmstoklistesi frm = new Modul_Stok.frmstoklistesi();
            if (secim)
            {
                frm.secim = secim;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();

            }
            return AnaForm.aktarma;
        }

        public int StokGruplari(bool secim = true)
        {
            Modul_Stok.frmstokgruplari frm = new Modul_Stok.frmstokgruplari();
            if (secim) frm.secim = secim;
            frm.ShowDialog();
            return AnaForm.aktarma;
        }

        public void StokHareketleri(bool ac = false)
        {

        }

        public void StokKarti(bool ac = false)
        {
            Modul_Stok.frmstokkarti frm = new Modul_Stok.frmstokkarti();
            frm.ShowDialog();
        }
        #endregion

        #region Cari Formları
        public int CariGruplari(bool Secim = false)
        {
            Modul_Cari.frmcarigruplari frm = new Modul_Cari.frmcarigruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.aktarma;
        }

        public int CariListesi(bool Secim = false)
        {
            Modul_Cari.frmcarilistesi frm = new Modul_Cari.frmcarilistesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.aktarma;
        }

        public void CariAcilisKarti(bool Ac = false, int CariID = -1)
        {
            Modul_Cari.frmcariaciliskarti frm = new Modul_Cari.frmcariaciliskarti();
            if (Ac) frm.Ac(CariID);
            frm.ShowDialog();
        }
        #endregion

        #region Kasa Formları
        public void KasaAcilisKarti()
        {
            Modul_Kasa.frmkasaaciliskarti frm = new Modul_Kasa.frmkasaaciliskarti();
            frm.ShowDialog();
        }

        public void KasaDevirİslemKarti(bool Ac = false, int IslemID = -1)
        {
            Modul_Kasa.frmkasadevirislem frm = new Modul_Kasa.frmkasadevirislem();
            if (Ac) frm.Ac(IslemID);
            frm.ShowDialog();
        }

        public int KasaListesi(bool Secim = false)
        {
            Modul_Kasa.frmkasalistesi frm = new Modul_Kasa.frmkasalistesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.aktarma;

        }

        public void KasaTahsilatOdemeKarti(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.frmkasatahsilatodeme frm = new Modul_Kasa.frmkasatahsilatodeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public void KasaHareketleri(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.frmkasahareketleri frm = new Modul_Kasa.frmkasahareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.Ac(ID);
            frm.Show();
        } 
        #endregion

        public void BankaAcilisKarti()
        {
            Modul_Banka.frmbankaaciliskarti frm = new Modul_Banka.frmbankaaciliskarti();
            frm.ShowDialog();
        }

        public void BankaIslem(bool Ac=false, int ID=-1)
        {
            Modul_Banka.frmbankaislemi frm = new Modul_Banka.frmbankaislemi();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

      
    }
}
