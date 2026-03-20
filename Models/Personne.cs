namespace Models;

public class Personne
{
    public string Nom { get; }
    public string Prenom { get; }
    public DateTime DateNaiss { get; }
    public Personne(string nom, string prenom, DateTime dateNaiss)
    {
        Nom = nom;
        Prenom = prenom;
        DateNaiss = dateNaiss;
    }
}
