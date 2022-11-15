using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_11_22_Predavanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReturnCompare_Click(object sender, EventArgs e)
        {
            Narudzba nar1 = new Narudzba(232, "Interspar", 23);
            Narudzba nar2 = new Narudzba(232, "Konzum", 12);
            Narudzba nar3 = new Narudzba(256, "NTL", 7);

            lblReturn1.Text += nar1.ToString() + "\n";
            lblReturn1.Text += nar2.ToString() + "\n";
            lblReturn1.Text += nar3.ToString() + "\n";

            Usporedi(nar1, nar2);
            Usporedi(nar1, nar3);
            Usporedi(nar2, nar3);

        }
        void Usporedi(Narudzba a, Narudzba b)
        {
            if (a.Equals(b))
            {
                lblReturn1.Text += "\nGreška! Pronađena narudžba s istim brojem: \n";
                lblReturn1.Text += $"Narudžba {a.BrojNarudzbe} za kupca: \"{a.ImeKupca}\" <---> Narudžba {b.BrojNarudzbe} za kupca: \"{b.ImeKupca}\"";
            }

            
        }
    }
}
