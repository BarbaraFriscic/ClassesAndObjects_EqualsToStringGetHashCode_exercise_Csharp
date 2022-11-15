using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_22_Predavanje
{
    internal class Narudzba
    {
        const double CIJENA = 19.95;
        public int BrojNarudzbe { get; set; }

        public string ImeKupca { get; set; }

        private int kolicina;

        public int Kolicina
        {
            get { return kolicina; }
            set { 
                kolicina = value; 
                ukupnaCijena = kolicina * CIJENA;
            }
        }
        private double ukupnaCijena;

        public double UkupnaCijena
        {
            get { return ukupnaCijena; }
            
        }

        public Narudzba(int BrNarudzbe, string ImeKupca, int kol)
        {
            this.BrojNarudzbe = BrNarudzbe;
            this.ImeKupca = ImeKupca;
            this.Kolicina = kol;
        }

        public override bool Equals(object obj)
        {
            Narudzba nar = (Narudzba)obj;
            if (this.BrojNarudzbe == nar.BrojNarudzbe)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return BrojNarudzbe;
        }
        public override string ToString()
        {
            return (GetType().Name + "BrNar: " + GetHashCode() + " Kupac: " + ImeKupca + " - Količina: " + Kolicina + " - Ukupno: " + UkupnaCijena);
        }

    }
}
