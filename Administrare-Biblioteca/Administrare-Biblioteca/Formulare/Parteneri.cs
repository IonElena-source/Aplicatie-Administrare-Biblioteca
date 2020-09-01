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
    public partial class Parteneri : Form
    {
        public Parteneri()
        {
            InitializeComponent();
            string text = "Fundatia Europeana Ideea";
            lbparteneri.Items.Add(text);
            string text1 = "Paralela 45";
            lbparteneri.Items.Add(text1);
            string text2 = "Editura Corint";
            lbparteneri.Items.Add(text2);

            string text4 = "Ediatura Aquila";
            lbpremium.Items.Add(text4);
            string text5 = "Primaria Bucuresti";
            lbpremium.Items.Add(text5);



        }

        private void lbparteneri_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lista = sender as ListBox;
            lista.DoDragDrop(lista.SelectedItem, DragDropEffects.Move);
            lista.Items.Remove(lista.SelectedItem);
        }

        private void lbpremium_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (e.AllowedEffect == DragDropEffects.Move)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lbpremium_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            ListBox lista = sender as ListBox;
            lista.Items.Add(text);

        }
    }
}
