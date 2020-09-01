using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrare_Biblioteca
{
    public partial class formCititor : Form
    {
        public formCititor()
        {
            InitializeComponent();
        }
        public Cititor cititor;
        public formCititor(Cititor cititor = null)
        {
            InitializeComponent();

            this.cititor = cititor;
            if (cititor == null)
            {
                return;
            }
            else
            {
                this.Text = "Informatii Cititor";
                tbNume.Text = cititor.nume;
                tbAdresa.Text = cititor.adresa;
                tbCnp.Text = cititor.cnp;
                tbVarsta.Text = cititor.varsta.ToString();
                tbNume.ReadOnly = true; ;
                tbAdresa.ReadOnly = true;
                tbCnp.ReadOnly = true;
                tbVarsta.ReadOnly = true;



            }


        }
        public Cititor Cititor { get { return cititor; } }


        private void tbVarsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format invalid\nIntroduceti din nou!");
            }
        }
    }
}
