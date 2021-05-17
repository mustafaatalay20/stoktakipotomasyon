using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace stoktakipotomasyon.Modul_Stok
{
    public partial class frmstoklistesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public bool secim = false;
        int secimid = -1;
        public frmstoklistesi()
        {
            InitializeComponent();
        }

        private void frmstoklistesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.tbl_stoklars where s.STOKADI.Contains(txtstokadi.Text) && s.BARKOD.Contains(txtbarkod.Text) && s.STOKKODU.Contains(txtstokkodu.Text) select s;
            Liste.DataSource = lst;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            txtbarkod.Text = "";
            txtstokadi.Text = "";
            txtstokkodu.Text = "";
        }

        void sec()
        {
            try
            {
                secimid = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                secimid = -1;
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            sec();
           if(secim && secimid>0)
            {
                AnaForm.aktarma = secimid;
                this.Close();
            }
        }
    }
}