using System.Net.Sockets;

namespace TP_Classes_abstraites;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n__________________Exo 2__________________");
        Appareil appareil1 = new Ordinateur("Asus", "modele1", new DateTime(2023, 11, 10) ,17);
        appareil1.Allumer();
        appareil1.AfficherType();
        appareil1.AfficherGarantie();
        appareil1.AfficherInfos();
        Console.WriteLine(appareil1.ToString());

        Console.WriteLine("\n__________________Exo 3__________________");
        Appareil appareil2 = new Smartphone("Apple", "iphone 16", new DateTime(2024, 11, 10), 2);
        appareil2.Allumer();
        appareil2.AfficherType();
        appareil2.AfficherGarantie();
        appareil2.AfficherInfos();

        Console.WriteLine("\n__________________Exo 4__________________");
        Appareil appareil3 = new Ordinateur("Lenovo", "modele2", new DateTime(2021, 1, 15), 15);
        Appareil appareil4 = new Smartphone("Samsung", "aaaa", new DateTime(2020, 5, 25), 3);
        Console.WriteLine(appareil1.CalculerAnciennete());
        Console.WriteLine(appareil2.CalculerAnciennete());
        Console.WriteLine(appareil3.CalculerAnciennete());
        Console.WriteLine(appareil4.CalculerAnciennete());

        Console.WriteLine("\n__________________Exo 5__________________");
        List<Appareil> appareils = new List<Appareil>();
        appareils.Add(appareil1);
        appareils.Add(appareil2);
        appareils.Add(appareil3);
        appareils.Add(appareil4);
        foreach (Appareil appareil in appareils)
        {
            Console.WriteLine("-----------------");
            appareil.Allumer();
            appareil.AfficherType();
            appareil.AfficherType();
            appareil.AfficherInfos();
        }

        Console.WriteLine("\n__________________Exo 6__________________");
        Dictionary<string, Appareil> dicoAppareils = new Dictionary<string, Appareil>();
        dicoAppareils.Add(appareil1.GetModel(), appareil1);
        dicoAppareils.Add(appareil2.GetModel(), appareil2);
        dicoAppareils.Add(appareil3.GetModel(), appareil3);
        dicoAppareils.Add(appareil4.GetModel(), appareil4);
        Console.WriteLine(dicoAppareils["modele1"].ToString());

    }
}
