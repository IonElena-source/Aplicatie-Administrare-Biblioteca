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
    public partial class FormContract : Form
    {
        public FormContract()
        {
            InitializeComponent();
        }
        public Imprumut imprumut;
        public FormContract(Imprumut imprumut = null)
        {
            InitializeComponent();

            this.imprumut = imprumut;
            if (imprumut == null)
            {
                this.Text = "Adaugare Contract";
            }
            else
            {
                this.Text = "Modifica Contract";
                tbNumarContract.ReadOnly = true;
                tbZi.ReadOnly = true;
                tbAn.ReadOnly = true;
                tbLuna.ReadOnly = true;
                tbNumarContract.Text = imprumut.numar.ToString();
                tbZi.Text = imprumut.data_imprumut.Day.ToString();
                tbLuna.Text = imprumut.data_imprumut.Month.ToString();
                tbAn.Text = imprumut.data_imprumut.Year.ToString();

            }


        }
        public Imprumut Imprumut { get { return imprumut; } }
        public void modificareAdaugareRestituire()
        {
            this.imprumut.restituire = new DateTime(int.Parse(tbAnRestituire.Text), int.Parse(tbLunaRestituire.Text), int.Parse(tbZiRestituire.Text));

        }

        private void tbNumarContract_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format incorect!\nIntroduceti din nou!");
            }

        }

        private void tbZi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format incorect!\nIntroduceti din nou!");
            }
        }

        private void tbLuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format incorect!\nIntroduceti din nou!");
            }
        }

        private void tbAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format incorect!\nIntroduceti din nou!");
            }
        }

        private void tbZiRestituire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format incorect!\nIntroduceti din nou!");
            }
        }

        private void tbLunaRestituire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format incorect!\nIntroduceti din nou!");
            }
        }

        private void tbAnRestituire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format incorect!\nIntroduceti din nou!");
            }
        }

        private void tbNumarContract_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Format incorect!\nIntroduceti din nou!");
            }
        }
    }
}
