class Ordinateur : Appareil
{
    protected double tailleEcran;
    public Ordinateur(string Marque, string Modele, DateTime DateFabrication, double tailleEcran) :base(Marque, Modele, DateFabrication)
    {
        this.tailleEcran = tailleEcran;
    }
    public override void AfficherType()
    {
        Console.WriteLine("Je suis un ordinteur");
    }
    public override void AfficherInfos()
    {
        Console.WriteLine($"{Marque}, {Modele} | date de fabrication {DateFabrication} | taille: {tailleEcran} | {CalculerAnciennete()} ans");
    }
    public override int CalculerAnciennete()
    {
        return DateTime.Now.Year - DateFabrication.Year;
    }
    public override string ToString()
    {
        return $"Ordinateur - Marque : {Marque}, Modèle : {Modele}, Taille écran : {tailleEcran}";
    }
}