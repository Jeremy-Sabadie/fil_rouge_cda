using Microsoft.AspNetCore.Mvc;

namespace api_fil_rouge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterielController : ControllerBase
    {
        [HttpGet]
        [Route("/materiels")]
        public IActionResult Materiels()
        {
            return Ok("Affichage de tous les materiels");
        }
    }
}
