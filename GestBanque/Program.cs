using Models;

Personne john = new Personne()
{
    Nom = "Doe",
    Prenom = "John",
    DateNaiss = new DateTime(1970, 1, 1)
};

Courant courant = new Courant()
{
    Numero = "00001",
    LigneDeCredit = 100,
    Titulaire = john
};

courant.Depot(-20);
Console.WriteLine($"Solde après un dépot de -20 : {courant.Solde}");

courant.Depot(200);
Console.WriteLine($"Solde après un dépot de 200 : {courant.Solde}");

courant.Retrait(-20);
Console.WriteLine($"Solde après un retrait de -20 : {courant.Solde}");

courant.Retrait(100);
Console.WriteLine($"Solde après un retrait de 100 : {courant.Solde}");

courant.Retrait(200);
Console.WriteLine($"Solde après un retrait de 200 : {courant.Solde}");

courant.Retrait(100);
Console.WriteLine($"Solde après un retrait de 100 : {courant.Solde}");