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
    public partial class frmparatransferi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;

        public frmparatransferi()
        {
            InitializeComponent();
        }

        private void frmparatransferi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.tbl_bankalars
                      where s.HESAPADI.Contains(txthesapadi.Text) && s.HESAPNO.Contains(txthesapno.Text) && s.IBAN.Contains(txtiban.Text)
                      select s;
            Liste.DataSource = lst;
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
            if(Secim && SecimID>=0)
            {
                AnaForm.aktarma = SecimID;
                this.Close();
            }
        }
    }
}