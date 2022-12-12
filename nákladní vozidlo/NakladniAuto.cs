using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nákladní_vozidlo
{
    internal class NakladniAuto
    {
        private string SPZ = "";
        private double nosnost = 0;
        private readonly double Hmotnost_nakladu = 0;
        private double zbytek = 0;
        private double nalozeno = 0;
        public NakladniAuto(string SPZ, double nosnost, double Hmotnost_nakladu)
        {
            this.SPZ = SPZ;
            this.nosnost = nosnost;
            this.Hmotnost_nakladu = Hmotnost_nakladu;
            zbytek = Hmotnost_nakladu;
            nalozeno = 0;
        }

        public string NalozNaklad(double naloz)
        {
             if ((zbytek == 0)||(nalozeno !=0))
             {
                 return "nic tu neni nebo mas uz nalozeno";
             }
             else
             {
                if(naloz > nosnost)
                {
                    return "pozadavek prekonava nosnost";
                }
                else
                {
                    if (naloz > zbytek)
                    {
                        nalozeno = zbytek;
                        return "nalozily jsme:" + zbytek + " a bohuzel už nam tady nic jineho nezbylo";
                    }
                    if (naloz == zbytek)
                    {
                        nalozeno = zbytek;
                        return "nalozily jsme presne mnozstvi ktere jsme tady mely a uz nam nic jineho nezbylo";
                    }
                    else
                    {
                        double zbytecek = zbytek - naloz;
                        zbytek = zbytek - zbytecek;
                        nalozeno = nosnost;
                        return "nalozily jsme " + nosnost + "zbylo nam tady: " + zbytecek;
                    }
                }
             }
        }

        public string Vyloz_Naklad(double vyloz)
        {
            if(nalozeno == vyloz)
            {
                nalozeno = 0;
                return "naklad vylozen, pozadovane mnozstvi vylozeno, nic nezbyva, dekujeme za pouziti";
            }
            else if(vyloz < nalozeno)
            {
                
                double zbytek = nalozeno - vyloz;
                nalozeno = zbytek;
                return "bylo vylozeno " + vyloz + " zbytek činí " + zbytek;
            }
            else
            {
                vyloz = vyloz - nalozeno;
                nalozeno = 0;
                return "vylozily jsme vse, nicmene je jeste potreba " + vyloz + " materialu";
            }

        }

        public override string ToString()
        {
            try
            {
                return "Auto ma SPZ: " + SPZ + " a ma nalozeno" + nalozeno;
            }
            catch
            {
                return "error";
            }
        }


    }
}
