// Importe la classe `GenericList`

// Crée une nouvelle instance de la classe `GenericList`
// avec le type `int` comme paramètre de type
var list = new System.Collections.Generic.GenericList<int>();

// Ajoute des éléments à la liste
list.Add(1);
list.Add(2);
list.Add(3);

// Itère sur la liste et imprime les valeurs des éléments
foreach (int item in list)
{
    // Imprime la valeur de l'élément courant
    Console.WriteLine(item);
}