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
    public partial class frmkasalistesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public bool Secim = false;
        int SecimID = -1;
        public  string KASA_ADI;
        public  int KASA_KODU = 0;
      
        public frmkasalistesi()
        {
            InitializeComponent();
        }

        private void frmkasalistesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.tbl_kasalars
                      where s.KASAKODU.Contains(txtkasakodu.Text) && s.KASAADI.Contains(txtkasaadi.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec() 
        {
            try
            {
                
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                 KASA_KODU= int.Parse(gridView1.GetFocusedRowCellValue("KASAKODU").ToString());
                KASA_ADI = gridView1.GetFocusedRowCellValue("KASAADI").ToString();
                // Form f1 = (Form)Application.OpenForms["frmkasadevirislem"];
                 
                this.Close();

            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID>0)
            {
                AnaForm.aktarma = SecimID;
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}