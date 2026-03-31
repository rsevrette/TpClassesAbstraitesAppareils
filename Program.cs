namespace TP_Classes_abstraites;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n__________________Exo 1__________________");
        Appareil appareil1 = new Ordinateur("Asus", "modele1", new DateTime(2023, 11, 10) ,17);
        appareil1.Allumer();
        appareil1.AfficherType();
        appareil1.AfficherGarantie();
        appareil1.AfficherInfos();
        Console.WriteLine(appareil1.ToString());

        Console.WriteLine("\n__________________Exo 2__________________");
        Appareil appareil2 = new Smartphone("Apple", "iphone 16", new DateTime(2024, 11, 10), 2);
        appareil2.Allumer();
        appareil2.AfficherType();
        appareil2.AfficherGarantie();
        appareil2.AfficherInfos();
    }
}
