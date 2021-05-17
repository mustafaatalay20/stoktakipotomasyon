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
    public partial class frmparatransfer : DevExpress.XtraEditors.XtraForm
    {
        string IslemTuru = "Banka Havale";



        public frmparatransfer()
        {
            InitializeComponent();
        }

        private void txttransferturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txttransferturu.SelectedIndex==0)
            {
                rbtngelen.Text = "Gelen Havale";
                rbtngiden.Text = "Giden Havale";
                IslemTuru = "Banka Havale";
            }
            else if(txttransferturu.SelectedIndex==1)
            {
                rbtngelen.Text = "Gelen EFT";
                rbtngiden.Text = "Giden EFT";
                IslemTuru = "Banka EFT";
            }
        }

        private void frmbparatransfer_Load(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}