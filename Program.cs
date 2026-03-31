namespace TP_Classes_abstraites;

class Program
{
    static void Main(string[] args)
    {
        Appareil appareil1 = new Ordinateur("Asus", "modele1", new DateTime(2023, 11, 10) ,17);
        appareil1.Allumer();
        appareil1.AfficherType();
        appareil1.AfficherGarantie();
        appareil1.AfficherInfos();
        Console.WriteLine(appareil1.ToString());
    }
}
