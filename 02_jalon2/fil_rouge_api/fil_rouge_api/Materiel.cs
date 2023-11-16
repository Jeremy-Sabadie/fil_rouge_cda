namespace fil_rouge_api
{
    public class Materiel
    {
        private string name { get; set; }
        private int fk_refCat { get; set; }
        private int fk_idMat { get; set; }
        private DateTime serviceDat { get; set; }
        private DateTime endGarantee { get; set; }
    }
}
