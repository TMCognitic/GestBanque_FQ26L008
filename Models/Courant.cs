namespace Models;

public class Courant : Compte
{
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

    public Courant(string numero, Personne titulaire) : base(numero, titulaire)
    {
    }

    public Courant(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
    {
        
    }

    public Courant(string numero, double ligneDeCredit, Personne titulaire) : base(numero, titulaire)
    {
        LigneDeCredit = ligneDeCredit;
    }

    public override void Retrait(double montant)
    {
        Retrait(montant, LigneDeCredit);
    }

    protected override double CalculInteret()
    {
        return Solde * (Solde > 0 ? 0.03 : 0.0975);
    }
}
