using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije
{
    internal class Osoba
    {
        string ime, prezime;
        int godRod;
        string rod, dodatak;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int GodRod { get => godRod; set => godRod = value; }
        public string Rod { get => rod; set => rod = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }

        public Osoba(string ime, string prezime, int godRod, string rod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRod = godRod;
            this.rod = rod;
        }

        public override string ToString()
        {
            string ispis =this.ime + "\t" + this.prezime + "\t" + this.godRod + "\t" + this.rod + "\t" + this.dodatak + "\r\n";
            return ispis;
        }
    }
}

