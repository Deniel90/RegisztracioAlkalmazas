using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class Ember
    {
        private string nev;
        private DateTime szuldatum;
        private string nem;
        private string[] hobbik;
        private string kedvencHobbi;

        public Ember(string nev, DateTime szuldatum, string nem, string[] hobbik, string kedvencHobbi)
        {
            this.Nev = nev;
            this.Szuldatum = szuldatum;
            this.Nem = nem;
            this.Hobbik = hobbik;
            this.KedvencHobbi = kedvencHobbi;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuldatum { get => szuldatum; set => szuldatum = value; }
        public string Nem { get => nem; set => nem = value; }
        public string[] Hobbik { get => hobbik; set => hobbik = value; }
        public string KedvencHobbi { get => kedvencHobbi; set => kedvencHobbi = value; }
    }
}
