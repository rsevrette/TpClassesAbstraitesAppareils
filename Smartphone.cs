class Smartphone : Appareil
{
    protected int nbCapteursPhoto;
    public Smartphone(string Marque, string Modele, DateTime DateFabrication, int nbCapteursPhoto) :base(Marque, Modele, DateFabrication)
    {
        this.nbCapteursPhoto = nbCapteursPhoto;
    }
    public override void AfficherInfos()
    {
        Console.WriteLine($"{Marque}, {Modele} | date de fabrication {DateFabrication} | nbr capteur photo: {nbCapteursPhoto} | {CalculerAnciennete()} ans");
    }
    public override int CalculerAnciennete()
    {
        return DateTime.Now.Year - DateFabrication.Year;
    }
}