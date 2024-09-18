namespace Inlamning_Diagram_
{
    public class FordonsTyp
    {
        public string Lastbil;

        public string Bil;

        public string Skåpbil;

        public string FordonsUnderhållsHistorik;
    }
    public class ValdFordon : FordonsTyp
    {
        public string Modell;

        public string Bränsle;

        public string MiljöBil;
    }
    public class FordonsBasPris : FordonsTyp
    {
        public string Lastbil;

        Console.WriteLine("Lastbils pris från 2000kr/dygn");

        public string Bil;

        Console.WriteLine("Bil pris från 400kr/dygn");

        public string Skåpbil;

        Console.WriteLine("Skåpbil pris från 1000kr/dygn");
     }
        
    public class UnderhållsHistorik : FordonsTyp
    {
        public string verksadsBesök;

        public string Service;

        public string Däckbyte;

        public string Olyckor;
    }
        

}
