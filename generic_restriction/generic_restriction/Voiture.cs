namespace generic_restriction
{
    internal class Voiture : IComparable<Voiture>
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }
        public int CompareTo(Voiture obj)
        {
            return Vitesse.CompareTo(obj.Vitesse);
        }






    }
}
