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

    public override void Retrait(double montant)
    {
        Retrait(montant, LigneDeCredit);
    }

    protected override double CalculInteret()
    {
        return Solde * (Solde > 0 ? 0.03 : 0.0975);
    }
}
