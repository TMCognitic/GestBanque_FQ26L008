namespace Models;

public class Epargne : Compte
{
    public DateTime DernierRetrait { get; private set; }

    public override void Retrait(double montant)
    {
        double oldSolde = Solde;
        base.Retrait(montant);

        if(Solde != oldSolde)
        {
            DernierRetrait = DateTime.Now;
        }
    }

    public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
    {
    }

    public Epargne(string numero, Personne titulaire, double solde, DateTime dernierRetrait) : base(numero, titulaire, solde)
    {
        DernierRetrait = dernierRetrait;
    }

    protected override double CalculInteret()
    {
        return Solde * 0.045;
    }
}
