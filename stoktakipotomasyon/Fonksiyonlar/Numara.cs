using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoktakipotomasyon.Fonksiyonlar
{
    class Numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        Mesajlar mesajlar = new Mesajlar();
        public string stokkodnumarası()
        {
            try
            {
                int numara = int.Parse((from s in DB.tbl_stoklars orderby s.ID descending select s).First().STOKKODU);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001"; 
            }
        }

        public string carikodnumarası()
        {
            try
            {
                int numara = int.Parse((from s in DB.tbl_carilers orderby s.ID descending select s).First().CARİKODU);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }

        public string kasakodnumarası()
        {
            try
            {
                int numara = int.Parse((from s in DB.tbl_kasalars orderby s.ID descending select s).First().KASAKODU);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
