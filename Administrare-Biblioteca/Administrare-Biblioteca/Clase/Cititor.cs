using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrare_Biblioteca
{
  public  class Cititor
    {
        public string nume { get; set; }
        public string adresa { get; set; }
        public string cnp { get; set; }
        public int varsta { get; set; }
        public Cititor(string nume, string adresa, string cnp, int varsta)
        {
            this.adresa = adresa;
            this.cnp = cnp;

            this.nume = nume;
            this.varsta = varsta;
        }
    }
}
