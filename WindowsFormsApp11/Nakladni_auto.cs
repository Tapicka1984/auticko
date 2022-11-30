using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    class Nakladni_auto
    {
        private string spz;
        private double nostnost;
        private double hmotnost_nakladu;
        private double nalozeno;
        public Nakladni_auto(double hmotnost_nakladu)
        {
            spz = "A6E8 265";
            nostnost = 25.8;
            this.hmotnost_nakladu = hmotnost_nakladu;
        }
        
        public string NalozNaklad()
        {
            if (hmotnost_nakladu <= nostnost)
            {
                nalozeno = hmotnost_nakladu;
                return "vse bylo uspesne nalozeno";
            }
            else
            {
                nalozeno = 25.8;
                string zprava_pro_uzivatele = "nebylo nalozeno: " + (hmotnost_nakladu - 25.8).ToString();
                return zprava_pro_uzivatele;
            }
        }

        public string VylozNaklad(double vykladka)
        {
            double vyloz = vykladka;
            if(nalozeno>vykladka)
            {
                double promena = nalozeno - vyloz;
                return "vylozily jsme pozadovane mnozstvi a zbylo nam " + promena.ToString();
            }
            else if(nalozeno == vyloz)
            {
                return "vse vylozeno a nic nezbylo";
            }
            else
            {
                double potreba = vyloz - nalozeno;
                return "vylozily jsme pouze " + nalozeno.ToString() + " nicmene to nebylo dost a potrebujeme jeste" + potreba.ToString();
            }

        }
    }
}
