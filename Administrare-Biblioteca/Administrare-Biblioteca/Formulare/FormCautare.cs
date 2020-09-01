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
    public partial class FormCautare : Form
    {
       
        List<Imprumut> listaImprumut;
        List<Carte> listaCarti;
        public FormCautare(List<Imprumut> imprumuturi, List<Carte> carti)
        {
            InitializeComponent();
            listaImprumut = imprumuturi;
            listaCarti = carti;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            tbCautare.DoDragDrop(tbCautare.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;//anulam toate efectele anterioare
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                {
                    e.Effect = DragDropEffects.Move;
                }

            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {

            string text = e.Data.GetData(typeof(string)).ToString();
            foreach (var i in listaImprumut)
            {
                if (i.carte.titlu.Equals(text))
                {
                    ListViewItem item = new ListViewItem(new string[] { i.cititor.nume, i.cititor.adresa, i.cititor.cnp, i.cititor.varsta.ToString() });
                    if (listView1.Items.Contains(item) == false)
                    {
                        listView1.Items.Add(item);
                    }
                }
            }

        }
    }
}
