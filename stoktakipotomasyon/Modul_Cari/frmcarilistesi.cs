using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoktakipotomasyon.Modul_Cari
{
    public partial class frmcarilistesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();


        public bool Secim = false;
        int SecimID = -1;

        public frmcarilistesi()
        {
            InitializeComponent();
        }

        private void frmcarilistesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var LST = from s in DB.tbl_carilers
                      where s.CARİADI.Contains(txtcariadi.Text) && s.CARİKODU.Contains(txtcarikodu.Text)
                      select s;
            Liste.DataSource = LST;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {

                SecimID = -1;
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.aktarma = SecimID;
                this.Close();
            }
        }
    }
}
