using domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiMateriels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterielController : ControllerBase
    {
        //POST->Création materiel:
        #region post materiel
        [HttpPost()]
        public async Task<IActionResult> CreateMateriel([FromBody] Materiel materiel)
        {
            //verification:
            if (materiel.Name != null && materiel.ServiceDat != null && materiel.EndGarantee != null)
            {



                Materiel newmaterial = new(materiel.Name, materiel.ServiceDat, materiel.EndGarantee);
                //Ajout dant la liste des matériels:
                Materiel.materiels.Add(newmaterial);
                //reponse si réussi:
                return Ok(newmaterial);
            }
            //reponse si échec:
            else
            {
                return BadRequest();
            }
        }
        #endregion
        //Update meteriel:
        #region PUT( update materiel)
        //PUT->Mise à jour par id:
        [HttpPut("{id}")]
        public IActionResult UpdateMateriel([FromRoute] int id, [FromBody] Materiel materiel)
        {
            if (Materiel.materiels.Exists(m => m.Id == id))
            {
                Materiel m = Materiel.materiels.Find(m => m.Id == id);
                m.Name = materiel.Name;
                m.ServiceDat = materiel.ServiceDat;
                return Ok(materiel);
            }

            else { return NotFound("Le matériel à mettre à jour n'existe pas."); }
        }
        #endregion
        #region delete materiel
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteMateriel([FromRoute] int id)
        {
            Materiel m = Materiel.materiels.Find(m => m.Id == id);
            if (m is null)
            {
                return NotFound("Le matériel à supprimer n'existe pas.");
            }
            else
            {
                Materiel.materiels.Remove(m);
                return NoContent();
            }
        }
        #endregion


        // GET
        #region get materiel by id
        [HttpGet("{id}")]
        [Route("/materiel/{id}")]
        public IActionResult GetMateriel([FromRoute] int id)
        {
            if (id > 0)
            {
                Materiel m = Materiel.materiels.Find(m => m.Id == id);
                if (m is null)
                {
                    return NotFound("Le matériel à supprimer n'existe pas.");
                }
                else { return Ok(m); }
            }
            else
            {
                return NotFound("Le matériel à supprimer n'existe pas.");
            }
        }


        #region getAllMateriels
        [HttpGet]
        [Route("/materiels")]
        public IActionResult getAllMateriels()
        {
            return Ok(Materiel.materiels);
        }
        #endregion




    }
}
#endregion

