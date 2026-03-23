using Models.Exceptions;

namespace Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        public static double operator +(double value, Compte compte)
        {
            return (value < 0 ? 0 : value) + (compte.Solde < 0 ? 0 : compte.Solde);
        }

        public string Numero { get; private set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; private set; }

        protected Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        protected Compte(string numero, Personne titulaire, double solde) : this(numero, titulaire)
        {
            Solde = solde;
        }

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant invalide");
                throw new ArgumentOutOfRangeException(nameof(montant), $"Compte.Depot(): Le montant doit être positif !");
            }

            Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0D);
        }

        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (ligneDeCredit < 0)
            {
                Console.WriteLine("Ligne de crédit invalide");
                throw new InvalidOperationException($"Compte.Retrait(): La ligne de crédit doit être supérieure ou égale à 0.");
            }

            if (montant <= 0)
            {
                Console.WriteLine("Montant invalide");
                throw new ArgumentOutOfRangeException(nameof(montant), $"Compte.Retrait(): Le montant doit être positif !");
            }

            if (Solde - montant < -ligneDeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                throw new SoldeInsuffisantException(nameof(montant), $"Compte.Retrait(): Le solde est insuffisant !");
            }

            Solde -= montant;
        }

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        protected abstract double CalculInteret();

    }
}