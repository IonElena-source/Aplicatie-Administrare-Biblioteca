using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrare_Biblioteca
{
    public partial class Form1 : Form
    {
        public List<Imprumut> imprumuturi;
        public List<Carte> carti = new List<Carte>();
        public int sectiune = 0;
        int an2015 = 2;
        int an2016 = 3;
        int an2017 = 3;
        int an2018 = 5;
        int an2019 = 2;
        double[] vector = new double[6];
        public Form1()
        {
            InitializeComponent();
            ListView listaImprumut = new ListView();
            imprumuturi = new List<Imprumut>();
            imprumuturi.Add(new Imprumut(1000, new DateTime(2015, 05, 18),
                         new Carte("Fratii Jderi", "Mihail Sadoveanu", "Roman istoric", 2145, 2),
                         new Cititor("Vasile Ana", "Strada Crinilor,nr 2 Bloc A3,etaj 1", "2990608510014", 20)));
            imprumuturi.Add(new Imprumut(1001, new DateTime(2015, 04, 10),
                new Carte("La tiganci", "Mircea Eliade", "Nuvela", 2444, 2),
                new Cititor("Stroe Maria", "Strada Nufarului nr 2 Bloc:B3 etaj:2", "2990608510014", 20)));
            imprumuturi.Add(new Imprumut(1002, new DateTime(2016, 08, 18),
               new Carte("La tiganci", "Mircea Eliade", "Nuvela", 2144, 3),
               new Cititor("Stroe Maria", "Strada Nufarului nr 2 Bloc:B3 etaj:2", "2990608510014", 40)));
            imprumuturi.Add(new Imprumut(1003, new DateTime(2016, 08, 18),
               new Carte("Insula Misterioasa", "Jules Verne", "Roman", 2194, 2),
               new Cititor("Marin Gabriela", "Strada Cuza  nr 2 Bloc:C3 etaj:2", "2960608510014", 30)));
            imprumuturi.Add(new Imprumut(1004, new DateTime(2016, 08, 18),
                        new Carte("Amurg", "Stephenie Meyer", "Roman fantastic", 2135, 2),
                        new Cititor("Ionita Mihaela", "Strada Ceaune,nr 2 Bloc G3,etaj 2", "2990608510014", 20)));
            imprumuturi.Add(new Imprumut(1005, new DateTime(2017, 08, 18),
                        new Carte("Somnul", "Cezar Petrecu", "Nuvela psihologica", 2745, 2),
                        new Cititor("Crisan Dana", "Strada Tei,nr 2 Bloc F3,etaj 1", "2940608510014", 20)));
            imprumuturi.Add(new Imprumut(1006, new DateTime(2017, 08, 18),
                        new Carte("Omul care si-a gasit umbra", "Cezar Petrescu", "Nuvela psihologica", 4145, 2),
                        new Cititor("Leicu Radu", "Strada Dumbrava,nr 5 Bloc A3,etaj 4", "2990628510014", 19)));

            imprumuturi.Add(new Imprumut(1007, new DateTime(2017, 05, 18),
                        new Carte("Praslea cel voinic si merele de aur", "Petre Ispirescu", "Basm popular", 2175, 6),
                        new Cititor("Badea Mihai", "Strada Ionilor,nr 2 Bloc A3,etaj 1", "2990508510014", 22)));
            imprumuturi.Add(new Imprumut(1008, new DateTime(2018, 08, 18),
                        new Carte("Memorii", "Mircea Eliade", "Roman biografic", 2155, 7),
                        new Cititor("Iancu Ana", "Strada Crinilor,nr 3 Bloc A3,etaj 7", "2990608510014", 20)));
            imprumuturi.Add(new Imprumut(1009, new DateTime(2018, 08, 18),
                        new Carte("Romanul adolescentului miop", "Mircea Eliade", "Roman ", 2325, 2),
                        new Cititor("Nutu Petre", "Strada Matasei,nr 6 Bloc G2,etaj 3", "2990608510014", 23)));
            imprumuturi.Add(new Imprumut(1010, new DateTime(2018, 08, 23),
                        new Carte("Burse de calatorie", "Jules Verne", "Roman", 5115, 4),
                        new Cititor("Marin Ana Maria", "Strada Tonea,nr 4 Bloc E1,etaj 2", "2990608510014", 24)));
            imprumuturi.Add(new Imprumut(1011, new DateTime(2018, 08, 18),
                       new Carte("Cancelarul", "Jules Verne", "Romab", 4115, 3),
                       new Cititor("Cristian Toma", "Strada Danilor,nr 4 Bloc D2,etaj 4", "2890608510014", 26)));
            imprumuturi.Add(new Imprumut(1012, new DateTime(2018, 8, 19),
                       new Carte("Calul balan", "Agatha Cristie", "Roman politist", 2135, 6),
                       new Cititor("Danciu Adela", "Strada Manisa,nr 2 Bloc H2,etaj 4", "2990205510014", 20)));
            imprumuturi.Add(new Imprumut(1013, new DateTime(2019, 8, 22),
                       new Carte("Instelata aventura", "George Ceausu", "Roman ", 1215, 8),
                       new Cititor("Apostol Ana", "Strada Lalelelor,nr 2 Bloc C2,etaj 4", "2990608510014", 20)));
            imprumuturi.Add(new Imprumut(1014, new DateTime(2019, 8, 21),
                       new Carte("Enigma Otiliei", "George Calinescu", "Roman realist", 6495, 4),
                       new Cititor("Matei Denisa", "Strada Badea,nr 2 Bloc C2,etaj 4", "2990608510014", 20)));

            afisareImprumuturi();
            carti.Add(new Carte("Doamnisoara Christine", "Agatha Cristie", "Basm", 1023, 4));
            carti.Add(new Carte("La tiganci", "Mircea Eliade", "Nuvela", 2144, 3));
            carti.Add(new Carte("O scrisoare pierdutta", "Ion Luca Caragiale", "Comedie", 1223, 5));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var introd = new Introducere())
            {
                if (introd.ShowDialog() == DialogResult.OK)
                {
                    using (var form = new Form1())
                    {

                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        void incarcareDate()
        {
            foreach (var x in imprumuturi)
            {
                if (x.data_imprumut.Year == 2015) an2015++;
                if (x.data_imprumut.Year == 2016) an2016++;
                if (x.data_imprumut.Year == 2017) an2017++;
                if (x.data_imprumut.Year == 2018) an2018++;
                if (x.data_imprumut.Year == 2019) an2019++;
            }
        }
        void afisareCartiDisponibile()
        {
            listaImprumut.Visible = false;
            listaCarti.Visible = true;


            foreach (var x in carti)
            {

                ListViewItem item = new ListViewItem(new string[] { x.titlu, x.autor, x.domeniu, x.cota.ToString(), x.nr_raft.ToString() });

                if (listaCarti.Items.Contains(item) == false)
                {
                    listaCarti.Items.Add(item);
                }

                item.Tag = x;

            }
        }
        void incarcareVector(double[] vector)
        {
            vector[0] = an2015;
            vector[1] = an2016;
            vector[2] = an2017;
            vector[3] = an2018;
            vector[4] = an2019;

        }
        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaImprumut.Items.Clear();
        }
        void afisareImprumuturi()
        {
            if (listaCarti.Visible == true) listaCarti.Visible = false; ;
            if (listaImprumut.Visible == false) listaImprumut.Visible = true;

            foreach (var x in imprumuturi)
            {
                ListViewItem item = new ListViewItem(new string[] { x.numar.ToString(), x.carte.titlu, x.cititor.nume, x.data_imprumut.ToString(), x.data_limita.ToString(), x.restituire.ToString() });

                if (listaImprumut.Items.Contains(item) == false)
                {
                    listaImprumut.Items.Add(item);
                }

                item.Tag = x;
            }


            incarcareVector(vector);
        }

        private void nouToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listaImprumut.Items.Clear();
        }

        private void contracteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listaCarti.Visible = false;
            listaImprumut.Visible = true;
            imprumuturi.Clear();
            listaImprumut.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                var linii = File.ReadAllLines(ofd.FileName);
                for (int i = 0; i < linii.Length; i = i + 3)
                {
                    var linieFormContract = linii[i].Split(',');
                    var numarContractDinFisier = linieFormContract[0];
                    var linieDataImprumut = linieFormContract[1].Split('-');
                    var ziImprumutDinFisier = linieDataImprumut[0];
                    var lunaImprumutDinFisie = linieDataImprumut[1];
                    var AnImprumutDinFisie = linieDataImprumut[2];
                    var linieCarte = linii[i + 1].Split(',');
                    var titluDinFisier = linieCarte[0];
                    var AutorDinFisier = linieCarte[1];
                    var DomeniuDinFisier = linieCarte[2];
                    var cotaDinFisier = linieCarte[3];
                    var raftDinFisier = linieCarte[4];

                    var linieCititor = linii[i + 2].Split('-');
                    var denumireCititorDinFisier = linieCititor[0];
                    var adresaCtitiroDinFisier = linieCititor[1];
                    var cnpDinFisier = linieCititor[2];
                    var varstaDinFisier = linieCititor[3];




                    imprumuturi.Add(new Imprumut(int.Parse(numarContractDinFisier),
                        new DateTime(int.Parse(AnImprumutDinFisie), int.Parse(lunaImprumutDinFisie), int.Parse(ziImprumutDinFisier)),
                        new Carte(titluDinFisier, AutorDinFisier, DomeniuDinFisier, int.Parse(cotaDinFisier), int.Parse(raftDinFisier)),
                        new Cititor(denumireCititorDinFisier, adresaCtitiroDinFisier, cnpDinFisier, int.Parse(varstaDinFisier))));




                }

                afisareImprumuturi();
                incarcareDate();
            }
        }

        private void cartiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listaCarti.BringToFront();
            listaImprumut.Visible = false;
            listaCarti.Visible = true;
            listaCarti.Enabled = true;
            carti.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var linii = File.ReadAllLines(ofd.FileName);
                foreach (var linie in linii)
                {
                    var linieDesp = linie.Split(',');
                    String carteTitlu = linieDesp[0];
                    String autorCarte = linieDesp[1];
                    String DomeniuCarte = linieDesp[2];
                    String Cota = linieDesp[3];
                    String nrRaft = linieDesp[4];
                    var carteDinFisier = new Carte(carteTitlu, autorCarte, DomeniuCarte, int.Parse(Cota), int.Parse(nrRaft));
                    carti.Add(carteDinFisier);

                }
                afisareCartiDisponibile();
            }
        }

        private void previzualizarePrintareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(print);
            PrintPreviewDialog pp = new PrintPreviewDialog();
            pp.Document = pd;
            pp.ShowDialog();
        }
        private void print(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            Pen pen = new Pen(Color.Black, 1);
            Rectangle rect = new Rectangle(e.PageBounds.X + 10, e.PageBounds.Y + 20, e.PageBounds.Width - 20, e.PageBounds.Height - 45);
            //  g.DrawRectangle(pen, rect);
            double latime = rect.Width / vector.Length / 2;
            double vMax = vector.Max();
            double distanta = (rect.Width - vector.Length * latime) / vector.Length + 10;
            Rectangle[] rectv = new Rectangle[vector.Length];
            Brush br = new SolidBrush(Color.Blue);
            for (int i = 0; i < vector.Length; i++)
            {
                rectv[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime), (int)(rect.Location.Y + rect.Height - vector[i] / vMax * rect.Height),
                    (int)latime, (int)(vector[i] / vMax * rect.Height));


                //g.DrawString(vector[i].ToString(), new Font(FontFamily.GenericSansSerif,18), new SolidBrush(Color.Black), new Point(rectv[i].Location.X + rectv[i].Width / 2, rectv[i].Location.Y - this.Font.Height));
                g.DrawString((i + 2015).ToString(), new Font(FontFamily.GenericSansSerif, 18), new SolidBrush(Color.Black), new Point(rectv[i].Location.X + rectv[i].Width / 2 - 5, rectv[i].Location.Y));
            }
            //g.FillRectangles(br, rectv);
            for (int i = 0; i < vector.Length - 2; i++)
            {
                g.DrawLine(new Pen(Color.Red, 5), new Point(rectv[i].Location.X + rectv[i].Width / 2, rectv[i].Location.Y),
                    new Point(rectv[i + 1].Location.X + rectv[i + 1].Width / 2, rectv[i + 1].Location.Y));

            }

        }
     

        private void arhivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaCarti.Items.Clear();
            listaCarti.BringToFront();
            listaImprumut.Visible = false;

            const String sirConectare = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Cristina\source\repos\ProiectFinal\Date\ProiectPaw.mdb";
            using (var conexiune = new OleDbConnection(sirConectare))
            {

                conexiune.Open();
                using (var comanda = new OleDbCommand("SELECT * from Carti", conexiune))
                {
                    using (var reader = comanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString(), reader.GetInt32(4).ToString() });


                            listaCarti.Items.Add(item);

                        }
                    }
                }
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaImprumut.Visible == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Fisiere text (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.InitialDirectory = "c:";
                StringBuilder textLista = new StringBuilder();
                if (sfd.ShowDialog() != DialogResult.Cancel)
                {
                    foreach (var imp in imprumuturi)
                    {
                        textLista.Append(imp.numar);
                        textLista.Append(",");
                        textLista.Append(imp.data_imprumut.Day);
                        textLista.Append("-");
                        textLista.Append(imp.data_imprumut.Month);
                        textLista.Append("-");
                        textLista.Append(imp.data_imprumut.Year);
                        textLista.AppendLine();
                        textLista.Append(imp.carte.titlu);
                        textLista.Append(",");
                        textLista.Append(imp.carte.autor);
                        textLista.Append(",");
                        textLista.Append(imp.carte.domeniu);
                        textLista.Append(",");
                        textLista.Append(imp.carte.cota);
                        textLista.Append(",");
                        textLista.Append(imp.carte.nr_raft);
                        textLista.AppendLine();
                        textLista.Append(imp.cititor.nume);
                        textLista.Append("-");
                        textLista.Append(imp.cititor.adresa);
                        textLista.Append("-");
                        textLista.Append(imp.cititor.cnp);
                        textLista.Append("-");
                        textLista.Append(imp.cititor.varsta);
                        textLista.AppendLine();




                    }
                    File.WriteAllText(sfd.FileName, textLista.ToString());
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                if (listaCarti.Visible == true)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = sfd.Filter = "Fisiere text (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.InitialDirectory = "c:";
                    StringBuilder textLista = new StringBuilder();
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var carte in carti)
                        {
                            textLista.Append(carte.titlu);
                            textLista.Append(",");
                            textLista.Append(carte.autor);
                            textLista.Append(",");
                            textLista.Append(carte.domeniu);
                            textLista.Append(",");
                            textLista.Append(carte.cota);
                            textLista.Append(",");
                            textLista.Append(carte.nr_raft);
                            textLista.Append("\n");

                        }

                        File.WriteAllText(sfd.FileName, textLista.ToString());
                    }


                }


            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rasfoiesteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Text = "Contracte";
            listaImprumut.BringToFront();
            listaImprumut.Items.Clear();
            listaImprumut.Enabled = true;
            listaImprumut.Visible = true;
            afisareImprumuturi();
        }

        private void listaCarti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelDesen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            Pen pen = new Pen(Color.Black, 1);
            Rectangle rect = new Rectangle(panelDesen.ClientRectangle.X + 10, panelDesen.ClientRectangle.Y + 20, panelDesen.ClientRectangle.Width - 20, panelDesen.ClientRectangle.Height - 45);
            //  g.DrawRectangle(pen, rect);
            double latime = rect.Width / vector.Length / 2;
            double vMax = vector.Max();
            double distanta = (rect.Width - vector.Length * latime) / vector.Length + 10;
            Rectangle[] rectv = new Rectangle[vector.Length];
            Brush br = new SolidBrush(Color.Blue);
            for (int i = 0; i < vector.Length; i++)
            {
                rectv[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime), (int)(rect.Location.Y + rect.Height - vector[i] / vMax * rect.Height),
                    (int)latime, (int)(vector[i] / vMax * rect.Height));


                g.DrawString(vector[i].ToString(), this.Font, new SolidBrush(Color.Black), new Point(rectv[i].Location.X + rectv[i].Width / 2, rectv[i].Location.Y - this.Font.Height));
                g.DrawString((i + 2015).ToString(), this.Font, new SolidBrush(Color.Black), new Point(rectv[i].Location.X + rectv[i].Width / 2 - 7, rectv[i].Location.Y + rectv[i].Height + 10));
            }
            g.FillRectangles(br, rectv);
            for (int i = 0; i < vector.Length - 2; i++)
            {
                g.DrawLine(new Pen(Color.Red, 3), new Point(rectv[i].Location.X + rectv[i].Width / 2, rectv[i].Location.Y),
                    new Point(rectv[i + 1].Location.X + rectv[i + 1].Width / 2, rectv[i + 1].Location.Y));

            }
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaImprumut.BringToFront();
            listaImprumut.Enabled = true;
            if (listaImprumut.Visible == false) { listaImprumut.Visible = true; }
            if (listaCarti.Visible == true) { listaCarti.Visible = true; }
            using (var formular = new FormContract(null))
            {
                if (formular.ShowDialog() == DialogResult.OK)
                {


                    using (var formCarte = new FormCarte())
                    {

                        if (formCarte.ShowDialog() == DialogResult.OK)
                        {

                            using (var formCititor = new formCititor())

                            {


                                if (formCititor.ShowDialog() == DialogResult.OK)
                                {
                                    var nouImprumut = new Imprumut(int.Parse(formular.tbNumarContract.Text)
                                        , new DateTime(int.Parse(formular.tbAn.Text), int.Parse(formular.tbLuna.Text), int.Parse(formular.tbZi.Text)),
                                        new Carte(formCarte.tbTitlu.Text,
                                        formCarte.tbAutor.Text,
                                        formCarte.tbDomeniu.Text,
                                        int.Parse(formCarte.tbCota.Text),
                                        int.Parse(formCarte.tbRaft.Text)),
                                        new Cititor(formCititor.tbNume.Text, formCititor.tbAdresa.Text, formCititor.tbCnp.Text, int.Parse(formCititor.tbVarsta.Text)));
                                    imprumuturi.Add(nouImprumut);
                                    if (nouImprumut.data_imprumut.Year == 2015) an2015++;
                                    if (nouImprumut.data_imprumut.Year == 2016) an2016++;
                                    if (nouImprumut.data_imprumut.Year == 2017) an2017++;
                                    if (nouImprumut.data_imprumut.Year == 2018) an2018++;
                                    if (nouImprumut.data_imprumut.Year == 2019) an2019++; ;
                                    incarcareVector(vector);
                                    afisareImprumuturi();


                                }


                            }



                        }
                    }
                }
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaImprumut.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                listaImprumut.Items.Remove(listaImprumut.SelectedItems[0]);

            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listaImprumut.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                var imprumutMod = (Imprumut)listaImprumut.SelectedItems[0].Tag;
                using (var formularModificaContract = new FormContract(imprumutMod))
                {

                    if (formularModificaContract.ShowDialog(this) == DialogResult.OK)
                    {
                        formularModificaContract.modificareAdaugareRestituire();
                    }

                }


            }
        }

        private void analizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDesen.Dock = DockStyle.Fill;
            this.Text = "Analiza contractelor pe 2015-2019";
            panelDesen.Enabled = true;
            panelDesen.Visible = true;
            panelDesen.BringToFront();
          


            if (vector.Length == 0)
            {
                return;
            }
            else
            {
                incarcareVector(vector);
                panelDesen.Invalidate();
            }
        }

        private void rasfoiesteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Text = "Carti";
            listaCarti.BringToFront();
            listaCarti.Items.Clear();
            if (listaCarti.Visible == false) listaCarti.Visible = true;
            if (carti == null)
            {
                MessageBox.Show("Nu sunt carti disponibile");
            }
            else
            {
                afisareCartiDisponibile();
            }
        }

        private void adaugareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //listaImprumut.Visible = false;
            if (listaCarti.Visible == false) listaCarti.Visible = true;

            using (var formular = new FormCarte())
            {
                if (formular.ShowDialog(this) == DialogResult.OK)
                {
                    var carteDisponibila = new Carte(formular.tbTitlu.Text, formular.tbAutor.Text, formular.tbDomeniu.Text, int.Parse(formular.tbCota.Text), int.Parse(formular.tbRaft.Text));
                    carti.Add(carteDisponibila);
                    afisareCartiDisponibile();

                }
            }
        }

        private void arhivaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            listaCarti.Items.Clear();
            listaCarti.BringToFront();
            listaImprumut.Visible = false;

            const String sirConectare = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Cristina\source\repos\ProiectFinal\Date\ProiectPaw.mdb";
            using (var conexiune = new OleDbConnection(sirConectare))
            {

                conexiune.Open();
                using (var comanda = new OleDbCommand("SELECT * from Carti", conexiune))
                {
                    using (var reader = comanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString(), reader.GetInt32(4).ToString() });


                            listaCarti.Items.Add(item);

                        }
                    }
                }
            }
        }

        private void cititorDupaCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormCautare(imprumuturi, carti))
            {
                form.ShowDialog();
            }
        }

        private void parteneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Parteneri())
            {
                form.ShowDialog();
            }
        }
        private void listaImprumut_KeyDown(object sender, KeyEventArgs e)
        {
            var imprumutMod = (Imprumut)listaImprumut.SelectedItems[0].Tag;
            Carte c = imprumutMod.carte;
            Cititor ci = imprumutMod.cititor;
            if (e.KeyCode == Keys.Enter)
            {
                using (var formularModificaContract = new FormContract(imprumutMod))
                {

                    if (formularModificaContract.ShowDialog(this) == DialogResult.OK)
                    {
                        using (var form = new FormCarte(c))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                using (var formc = new formCititor(ci))
                                {
                                    formc.ShowDialog();
                                }
                            }
                        }
                    }

                }

            }
        }

        private void listaImprumut_DoubleClick(object sender, EventArgs e)
        {
            if (listaImprumut.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                var imprumutMod = (Imprumut)listaImprumut.SelectedItems[0].Tag;
                using (var formularModificaContract = new FormContract(imprumutMod))
                {

                    if (formularModificaContract.ShowDialog(this) == DialogResult.OK)
                    {
                        listaImprumut.Items.Clear();
                        formularModificaContract.modificareAdaugareRestituire();

                        afisareImprumuturi();
                    }

                }


            }
        }


        private void listaCartiItems_MouseDown(object sender, MouseEventArgs e)
        {
            ListView lista = sender as ListView;

            Carte c = (Carte)lista.SelectedItems[0].Tag;
            lista.DoDragDrop((Carte)lista.SelectedItems[0].Tag, DragDropEffects.Copy);

        }




        private void listaCarti_DoubleClick(object sender, EventArgs e)
        {
            ListView lista = sender as ListView;

            Carte c = (Carte)lista.SelectedItems[0].Tag;
            using (var report = new ReportCarte(c))
            {
                report.ShowDialog();
            }


        }

        private void listaCartiItems_MouseDown(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void utilizator1_Click(object sender, EventArgs e)
        {
            if (listaCarti.Visible == true)
            {
                if (listaCarti.SelectedItems.Count > 0)
                {
                    Carte c = (Carte)listaCarti.SelectedItems[0].Tag;
                    using (var report = new ReportCarte(c))
                    {
                        report.ShowDialog();
                    }
                }
                else
                {
                    using (var reporti = new ReportCarte())
                    {
                        reporti.ShowDialog();
                    }
                }
            }
            else
            {
                if (listaImprumut.Visible == true)
                {
                    if (listaImprumut.SelectedItems.Count > 0)
                    {
                        Imprumut i = (Imprumut)listaImprumut.SelectedItems[0].Tag;
                        using (var formi = new ReportFormular(i))
                        {
                            formi.ShowDialog();
                        }
                    }
                    else
                    {
                        using (var formis = new ReportFormular())
                        {
                            formis.ShowDialog();
                        }

                    }

                }
            }
        }
    }
}
