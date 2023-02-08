using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresar
{
    internal class Kontakt
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ulica { get; set; }
        public int KucniBroj { get; set; }
        public string Grad { get; set; }
        public int BrojTelefona { get; set; }
        public string Email { get; set; }

        public Kontakt(string ime, string prezime, string ulica, int kucniBroj, string grad)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Ulica = ulica;
            this.KucniBroj = kucniBroj;
            this.Grad = grad;
        }
    }
}
