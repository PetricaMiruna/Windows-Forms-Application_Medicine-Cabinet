using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Reteta: ICloneable, IComparable
    {
        DateTime data_eliberare;
        int id;
        string[] medicamente;
        float[] preturi;
        Medic medic;
        Pacient pacient;

        public DateTime Data_eliberare
        {
            get { return data_eliberare; }
            set { data_eliberare = value; }
        }

        public int Id
        {
            get { return id; }
            set
            { if(value>0)
                id = value;
            }
        }

        public string[] Medicamente
        {
            get { return medicamente; }
            set { medicamente = value; }

        }
        public Medic Medic
        {
            get { return medic; }
            set{ medic = value; }
        }

        public Pacient Pacient
        {
            get { return pacient; }
            set { pacient = value; }
        }

        public float[] Preturi
        {
            get { return preturi; }
 
            set 
            {
                while (preturi.Length <= medicamente.Length)
                {
                    foreach (int i in preturi)
                    { 
                        preturi = value;
                    }
                }
            }
        }

        Reteta(DateTime data_eliberare, int id, string[] med, float[] pr, Medic medic, Pacient pacient)
        {
            this.data_eliberare = data_eliberare;
            this.id = id;
            this.medic = medic;
            this.pacient = pacient;
            medicamente=new string[med.Length];
            for (int i = 0; i < med.Length; i++)
            {
                medicamente[i] = med[i];
            }
            preturi = new float[pr.Length];
            for (int i = 0; i < pr.Length; i++)
            {
                preturi[i] = pr[i];
            }
           
        }
        Reteta() : base(){
            data_eliberare = new DateTime();
            id = 0;
            medicamente = null;
            preturi = null;
        }

        public float calculeazaValoare()
        {
            float valoare = 0.0f;
            for (int i = 0; i < medicamente.Length; i++)
            {
                for (int j=0; j <preturi.Length; j++)
                {
                    valoare = valoare + preturi[j];
                }
            }
            return valoare;
        }
        public object Clone()
        {
            Reteta clona = (Reteta)this.MemberwiseClone();
            string[] medicamente_noi = (string[])medicamente.Clone();
            float[] preturi_noi = (float[])preturi.Clone();
            return clona;
        }

        public static explicit operator float(Reteta r)
        {
            return r.calculeazaValoare();
        }

        public int CompareTo(object obj)
        {
            Reteta r = (Reteta)obj;
            if ((float)this > (float)r)
        
                return -1;
            
            else if ((float)this < (float)r)

                return 1;

            else return 0;
            
        }

        public float this[int ind]
        {
            get
            {
                if ( preturi!= null && ind >= 0 && ind < preturi.Length
                    && medicamente.Length == preturi.Length)
                    return preturi[ind];
                else
                    return 0;
            }
            set
            {
                if (preturi!= null && ind >= 0 && ind < preturi.Length
                    && medicamente.Length==preturi.Length)
                    preturi[ind] = value;
            }
        }


    }
}
