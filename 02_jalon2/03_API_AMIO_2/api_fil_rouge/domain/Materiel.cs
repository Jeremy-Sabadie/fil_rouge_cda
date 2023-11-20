namespace domain
{
    public class Materiel
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime serviceDat { get; set; }
        public DateTime endGarantee { get; set; }
        public int proprietaireId { get; set; }


    }
}
