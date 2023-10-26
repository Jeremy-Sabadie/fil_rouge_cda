namespace generic_restriction
{
    public interface IComparable<T>
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }

        public int CompareTo(Voiture obj)
        {
            Voiture voiture = (Voiture)obj;
            return Vitesse.CompareTo(voiture.Vitesse);


        }
    }
