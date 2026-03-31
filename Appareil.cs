abstract class Appareil
{
    public string Marque { get; set; }
    public string Modele { get; set; }
    public DateTime DateFabrication { get; set; }
    public void Allumer()
    {
        Console.WriteLine("L'appareil s'allume");
    }
    public virtual void AfficherType()
    {
        Console.WriteLine("Je suis un appareil");
    }
    public virtual void AfficherGarantie()
    {
        Console.WriteLine("Garantie standard de l'appareil");
    }
    public abstract void AfficherInfos()
    {
        Console.WriteLine($"voiture: {marque}, {Modele} | date de fabrication {DateFabrication}");
    }
    public abstract void CalculerAnciennete()
    {
        int anciennete = DateTime.Now.Year - DateFabrication.Year;
        Console.WriteLine($"L'ancienneté de l'appareil est de {anciennete} ans");
    }
}