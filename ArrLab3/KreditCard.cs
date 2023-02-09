using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrLab3
{
    public class KreditCard
    {
        public int numbercard;
        public string Name;
        public int CVC;
        public string timeofend;
        
        
        public int NameCard
        {
            get { return numbercard; }

            set { numbercard = value; }
        }
        public int CCVVCC
        {
            get { return CVC; }

            set { CVC = value; }
        }
        public String NamePerson
        {
            get { return Name; }

            set { Name = value; }
        }
        public string Endcard
        {
            get { return timeofend; }

            set { timeofend = value; }
        }
        public KreditCard() {
            Random r = new Random();
            numbercard = r.Next(10000000,99999999);
            Name = "None";
            CVC = r.Next(100,999);
            timeofend = "None";
        }
        public KreditCard(int numbercard, string Name, int CVC, string timeofend)
        {
            this.numbercard = numbercard;
            this.Name = Name;
            this.CVC = CVC;
            this.timeofend = timeofend;

        }
        public override string ToString()
        {
            return $"Card:{numbercard}\nName:{Name}\nCVC:{CVC}\nEnd card:{timeofend}";
        }

    }
}

