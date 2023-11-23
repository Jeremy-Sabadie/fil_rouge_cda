namespace domain.Entities
{
    public class Materiel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ServiceDat { get; set; }
        public DateTime EndGarantee { get; set; }
        public static List<Materiel> materiels { get; set; }
        public Materiel(string name, DateTime serviceDat, DateTime endGarantee)
        {
            Name = name;
            ServiceDat = serviceDat;
            EndGarantee = endGarantee;

        }
    }
}
