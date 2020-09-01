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
    public partial class ReportFormular : Form
    {
        public Imprumut i;
        public ReportFormular()
        {
            InitializeComponent();
        }
        public ReportFormular(Imprumut ii)
        {
            InitializeComponent();
            this.i = ii;
            tbAdresa.Text = ii.cititor.adresa;
            tbCartereport.Text = ii.carte.titlu;
            tbcititorreport.Text = ii.cititor.nume;

        }
    }
}
