using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KiemtraKethucMon
{
    class DongVat
    {
        private string keu;

        public string tiengkeu
        {
            get{return keu;}
            set{keu = value;}
        }

        public DongVat()
        {
        }
        private string MauLong;
        public string maulong
        {
            get{return MauLong;}
            set{MauLong = value;}
        }



        public virtual void Keu()
        {
            if (tiengkeu.Equals("Gâu gâu") && (maulong.Equals("trắng")))
                MessageBox.Show(this.tiengkeu + " Tôi là chó lông màu:" + this.maulong);
            else if (tiengkeu.Equals("Meo meo") && (maulong.Equals("nâu")))
                MessageBox.Show(this.tiengkeu + " Tôi là mèo lông màu:" + this.maulong);
        }
    }
}
