namespace test_generic
{
    //Déclaration de la classe GenericList  avec un paramètre de type T.Ce paramètre de type T représente le type des éléments de la liste.
    public class genericList<T>
    {   // Untableau de T _items est déclaré comme attribut de la classe.
        private T[] _items;
        // Le constructeur de la classe `GenericList` crée une nouvelle liste vide.

        public void GenericList()
        {
            _items = new T[0];
        }
        // La méthode `Add()` ajoute un élément à la liste.
        public void Add(T item)
        {
            _items.Append(item);
        }

        public T GetItem(int index)
        {
            return default(T);
            //return _items[index];
        }
    }
}
