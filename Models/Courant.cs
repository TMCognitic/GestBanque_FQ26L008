namespace Models;

public class Courant
{
    public string Numero { get; set; }
    public double Solde { get; private set; }
    public double LigneDeCredit
    {
        get { return field; }
        set 
        {
            if (value < 0)
                return; //Erreur!!!

            field = value; 
        }
    }
    public Personne Titulaire { get; set; }

    public void Depot(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Montant invalide");
            return; //Erreur!!!
        }

        Solde += montant;
    }

    public void Retrait(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Montant invalide");
            return; //Erreur!!!
        }

        if (Solde - montant < -LigneDeCredit)
        {
            Console.WriteLine("Solde insuffisant");
            return; //Erreur!!!
        }

        Solde -= montant;
    }
}
