namespace exemple_generic
{
    internal interface Voiture : IComparable
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }



    }
}
