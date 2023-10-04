using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Persoana
    {
        private string nume;
        private string prenume;
        private string nr_telefon;
       

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }

        }

        public string Nr_telefon
        {
            get { return nr_telefon; }
            set { nr_telefon = value; }
        }

        public Persoana() : base()
        {
            nume = "Anonim";
            prenume = "Anonim";
            nr_telefon = "Anonim";
            
        }

        public Persoana(string nume, string prenume, string nr_telefon)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.nr_telefon = nr_telefon;
            
            
        }
        public override string ToString()
        {
            return "Persoana cu numele " + nume + prenume;
        }

    }

}
