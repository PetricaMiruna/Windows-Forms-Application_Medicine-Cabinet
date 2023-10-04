using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pacient : Persoana, ICloneable, IComparable
    {
        private int id;
        private int varsta;
        private string[] afectiuni;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }

        public int Varsta
        {
            get { return varsta; }
            set 
            { if(value>0)
                varsta = value; 
            }
        }

        public string[] Afectiuni
        {
            get => afectiuni;
            set => afectiuni = value; 
        }

        public Pacient() : base()
        {
            id = 0;
            varsta = 0;
            afectiuni = null;
            
        }

        public Pacient(int id, int varsta, string[] af,
            string nume, string prenume, string nr_telefon)
            : base(nume, prenume, nr_telefon)
        {
            this.id = id;
            this.varsta = varsta;
            afectiuni = new string[af.Length];
            for ( int i = 0; i < af.Length; i++)
            {
                afectiuni[i] = af[i].ToString();
            }
        }

        public object Clone()
        {
            Pacient clona = (Pacient)this.MemberwiseClone();
            string[] afectiuni_noi = (string[])afectiuni.Clone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            Pacient p = (Pacient)obj;
            if (this.afectiuni.Length > p.afectiuni.Length)
                return 1;
            else
                 if (this.afectiuni.Length < p.afectiuni.Length)
                return -1;
           return 0;

        }



        public string this[int index]
        {
            get
            {
                if (afectiuni != null && index >= 0 && index < afectiuni.Length)
                    return afectiuni[index];
                else
                    return null;
            }
            set
            {
                if (afectiuni != null && index >= 0 && index < afectiuni.Length)
                    afectiuni[index] = value;
            }
        }

        public static Pacient operator +(Pacient p, string afectiuneNoua)
        {
            string[] afectiuniNoi = new string[p.afectiuni.Length + 1];
            for (int i = 0; i < p.afectiuni.Length; i++)
                afectiuniNoi[i] = p.afectiuni[i];
            afectiuniNoi[afectiuniNoi.Length - 1] = afectiuneNoua;
            p.afectiuni = afectiuniNoi;
            return p;
        }

        public static Pacient operator +(string afectiuneNoua, Pacient p)
        {
            return p + afectiuneNoua;
        }

        public override string ToString()
        {
            string rezultat = base.ToString() + "are id-ul" + id + "si varsta" + varsta;
               
           
                rezultat += "si sufera de urmatoarele afectiuni:" +
                    Environment.NewLine;
                for (int i = 0; i < afectiuni.Length; i++)
                    rezultat += afectiuni[i] + ", ";
            
            return rezultat;
        }


    }
}
