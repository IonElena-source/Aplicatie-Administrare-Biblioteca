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
    public partial class FormCarte : Form
    {
        public FormCarte()
        {
            InitializeComponent();
        }
        public Carte carte;
        public FormCarte(Carte carte = null)
        {
            InitializeComponent();

            this.carte = carte;
            if (carte == null)
            {
                return;
            }
            else
            {
                this.Text = "Informatii Carte";
                tbTitlu.ReadOnly = true;
                tbAutor.ReadOnly = true;
                tbDomeniu.ReadOnly = true;
                tbCota.ReadOnly = true;
                tbRaft.ReadOnly = true;
                tbRaft.Text = carte.nr_raft.ToString();
                tbAutor.Text = carte.autor;
                tbTitlu.Text = carte.titlu;
                tbDomeniu.Text = carte.domeniu;
                tbCota.Text = carte.cota.ToString();


            }
        }
    }
}
