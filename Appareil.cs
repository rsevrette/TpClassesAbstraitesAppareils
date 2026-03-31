abstract class Appareil
{
    protected string Marque; 
    protected string Modele; 
    protected DateTime DateFabrication;
    public string GetModel()
    {
        return Modele;
    }
    public Appareil(string Marque, string Modele, DateTime DateFabrication)
    {
        this.Marque = Marque;
        this.Modele = Modele;
        this.DateFabrication = DateFabrication;
    } 
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
    public abstract void AfficherInfos();
    public abstract int CalculerAnciennete();
}