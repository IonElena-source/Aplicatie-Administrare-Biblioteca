using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrare_Biblioteca
{
   public class Imprumut
    {
        public int numar { get; set; }
        public DateTime data_imprumut { get; set; }
        public DateTime data_limita { get; set; }
        public Carte carte { get; set; }
        public Cititor cititor { get; set; }
        public DateTime restituire { get; set; }

        public Imprumut(int nr, DateTime di, Carte c, Cititor ci)
        {
            this.numar = nr;
            this.data_imprumut = di;
            this.carte = new Carte(c.titlu, c.autor, c.domeniu, c.cota, c.nr_raft);
            this.cititor = new Cititor(ci.nume, ci.adresa, ci.cnp, ci.varsta);
            this.data_limita = new DateTime(data_imprumut.Year, data_imprumut.Month, data_imprumut.Day + 7);

        }
    }
}
