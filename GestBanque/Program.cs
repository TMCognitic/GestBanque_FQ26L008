using Models;
using Models.OperatorsExo;

Celsius celsius = new Celsius() { Temperature = 30 };
Fahrenheit fahrenheit = celsius;

celsius = (Celsius)fahrenheit;



Banque banque = new Banque("Techno Banking");

Personne john = new Personne("Doe", "John", new DateTime(1970, 1, 1));

try
{
    Courant courant = new Courant("00001", 100, john);
    banque.Ajouter(courant);
}
catch (Exception e)
{
    Console.WriteLine($"[LOG] Erreur déclenchée: {e.Message}");
}
Epargne epargne = new Epargne("00002", john);

banque.Ajouter(epargne);

try
{
    banque["00001"].Depot(-20);
    Console.WriteLine($"Solde après un dépot de -20 : {banque["00001"].Solde}");
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
try
{
    banque["00001"].Depot(200);
    Console.WriteLine($"Solde après un dépot de 200 : {banque["00001"].Solde}");
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
try
{
    banque["00001"].Retrait(-20);
    Console.WriteLine($"Solde après un retrait de -20 : {banque["00001"].Solde}");
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
try
{
    banque["00001"].Retrait(100);
    Console.WriteLine($"Solde après un retrait de 100 : {banque["00001"].Solde}");
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
try
{
    banque["00001"].Retrait(200);
    Console.WriteLine($"Solde après un retrait de 200 : {banque["00001"].Solde}");
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
try
{
    banque["00001"].Retrait(100);
    Console.WriteLine($"Solde après un retrait de 100 : {banque["00001"].Solde}");
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
try
{
    banque["00002"].Depot(2000);
    Console.WriteLine($"Solde après un dépot de 2000 : {banque["00002"].Solde}");
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}

banque["00001"].AppliquerInteret();
banque["00002"].AppliquerInteret();

Console.WriteLine($"Avoir des comptes de {john.Prenom} {john.Nom} : {banque.AvoirDesComptes(john)}");