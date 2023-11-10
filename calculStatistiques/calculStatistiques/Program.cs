class Program
{
    // Définition du délégué pour le calcul de statistiques
    delegate double statisticalCalcul(List<double> numbers, Func<List<double>, double> calcul);

    static void Main()
    {
        // Création d'une liste de nombres doubles
        List<double> numbers = new List<double>();
        Random random = new Random();
        int i;
        for (i = 0; i < 10; i++)
        {
            int nombreAleatoire = random.Next(1, 100);
            numbers.Add(nombreAleatoire);


        }
        // Utilisation du délégué avec des fonctions lambda pour calculer la moyenne, la valeur minimale et maximale
        double moyenne = CalculerStatistique(numbers, nums => nums.Average());
        double valeurMinimale = CalculerStatistique(numbers, nums => nums.Min());
        double valeurMaximale = CalculerStatistique(numbers, nums => nums.Max());

        // Affichage des résultats
        Console.WriteLine($"Liste de nombres : {string.Join(", ", numbers)}");
        Console.WriteLine($"Moyenne : {moyenne}");
        Console.WriteLine($"Valeur Minimale : {valeurMinimale}");
        Console.WriteLine($"Valeur Maximale : {valeurMaximale}");
    }

    // Méthode générique qui utilise le délégué pour calculer une statistique
    static double CalculerStatistique(List<double> numeros, Func<List<double>, double> calcul)
    {
        return calcul(numeros);
    }
}

