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
    public partial class ReportCarte : Form
    {
        public Carte carte;
        public ReportCarte()
        {
            InitializeComponent();
        }
        public ReportCarte(Carte c)
        {
            InitializeComponent();
            this.carte = c;
            tbAutorReport.Text = c.autor;
            tbtitluReport.Text = c.titlu;
        }
    }
}
