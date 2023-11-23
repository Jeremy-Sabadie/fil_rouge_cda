using domain.Entities;

namespace BLL.interfaces
{
    internal interface IGestMaterielsService
    {
        public List<Materiel> GetMateriels();
        public Materiel GetMaterielById(int id);
        public Materiel DeleteMaterielById();
    }
}
