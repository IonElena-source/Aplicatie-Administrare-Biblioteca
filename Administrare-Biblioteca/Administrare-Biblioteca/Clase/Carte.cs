using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrare_Biblioteca
{
    [Serializable]
    public class Carte
    {
        public string titlu { get; set; }
        public string autor { get; set; }
        public string domeniu { get; set; }
        public int cota { get; set; }
        public int nr_raft { get; set; }
        public Carte(string titlu, string autor, string domeniu, int cota, int nr_Raft)
        {
            this.autor = autor;
            this.domeniu = domeniu;
            this.cota = cota;
            this.nr_raft = nr_Raft;
            this.titlu = titlu;
        }
        public Carte(string titlu, string autor)
        {
            this.titlu = titlu;
            this.autor = autor;
        }
    }
}
