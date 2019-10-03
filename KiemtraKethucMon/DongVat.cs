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
        public string maulong
        {
            get{return maulong;}
            set{maulong = value;}
        }



        public virtual void Keu()
        {
            if (tiengkeu.Equals("Gâu gâu"))
                MessageBox.Show("Chó kêu" + this.tiengkeu );
            else if (tiengkeu.Equals("Meo meo"))
                MessageBox.Show("Mèo kêu" +this.tiengkeu );
        }
    }
}
