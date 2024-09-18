using System.Dynamic;

namespace Inlamning_Diagram_
{
    public class Kund
    {
        private string KundNamn;

        private int KundTelefonNummer;

        private string KundAdress;

        public Kund(string kundNamn, int kundTelefonNummer, string kundAdress)
        {
            KundNamn = kundNamn;
            KundTelefonNummer = kundTelefonNummer;
            KundAdress = kundAdress;
        }
        public string KundNamn
        {
            get { return kundnamn; }
            set { kundnamn = value; }
        }
        public int KundTelefonNummer
        {
            get { return KundTelefonNummer; }
            set { KundTelefonNummer = value; }
        }
        public string KundAdress
        {
            get { return KundAdress; }
            set { KundAdress = value; }
        }
    }
    
    


}

