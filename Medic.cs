using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Medic: Persoana, ICloneable, IComparable
    {
      
        private string specializare;
        private int id;
        private float vechime;

        public string Specializare
        {
            get { return specializare; }
            set { specializare = value; }
        }

        public int Id
        {
            get { return Id; }
            set { Id = value; }

        }

        public float Vechime
        {
            get { return Vechime; }
            set
            {
                Vechime = value;
            }
        }

        public Medic() : base()
        {
      
            specializare = "Anonim";
            id = 0;
            vechime = 0;
        }
        public Medic(string specializare, int id, float vechime)
        {
           
            this.specializare = specializare;
            this.id = id;
            this.vechime = vechime;
           

        }

        public static explicit operator float(Medic m)
        {
            return m.vechime;
        }

        public static Medic operator ++(Medic medic)
        {
            medic.Id++;
            return medic;
        }

        public object Clone()
        {
            Medic clona = (Medic)this.MemberwiseClone();
            return clona;

        }

        public int CompareTo(object obj)
        {
            Medic m = (Medic)obj;
            if ((float)this > (float)m)
                return -1;
            else
                return 1;

        }

        public string anulAngajarii()
        {
            return (System.DateTime.Now.Year - vechime).ToString();
        }
        ~Medic()
        {

        }
    }

}
