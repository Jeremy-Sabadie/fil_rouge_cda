namespace domain.Entities
{
    public class Materiel
    {


        public string Name { get; set; }
        public DateTime ServiceDat { get; set; }
        public DateTime EndGarantee { get; set; }
        private int PropriétaireId { get; set; }
        public Materiel(string name, DateTime serviceDat, DateTime endGarantee, int propriétaireId)
        {
            Name = name;
            ServiceDat = serviceDat;
            EndGarantee = endGarantee;
            PropriétaireId = propriétaireId;
        }
    }
}
