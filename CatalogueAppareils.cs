class CatalogueAppareils
{
    protected Dictionary<string, Appareil> appareils;
    public CatalogueAppareils(Dictionary<string, Appareil> appareils)
    {
        this.appareils = appareils;
    }
    public void AjouterAppareil(Appareil appareil)
    {
        appareils.Add(appareil.GetModel(), appareil);
    }
    public void RechercherAppareil(string modele)
    {
        try
        {
            Appareil appareil = appareils[modele];
            appareil.AfficherInfos();
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Aucun appareil trouvé pour cette clé.");
        }
    }
        

}