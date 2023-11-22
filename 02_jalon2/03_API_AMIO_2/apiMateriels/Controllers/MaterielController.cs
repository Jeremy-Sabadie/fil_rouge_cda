using domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiMateriels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterielController : ControllerBase
    {
        //POST->Création:
        [HttpPost()]
        public async Task<IActionResult> CreateMateriel([FromBody] Materiel materiel)
        {
            //verifier
            if (book.Title != null && book.Autor != null)
            {
                //faire
                Book newbook = new(5, book.Title, book.Autor);
                Book.books.Add(newbook);
                //repondre
                return Ok(newbook);
            }
            else
            {
                return BadRequest();
            }
            //PUT->Mise à jour:
            [HttpPut("{id}")]
            public IActionResult UpdateBook([FromRoute] int id, [FromBody] Book book)
            {
                if (Book.books.Exists(b => b.Id == id))
                {
                    Book b = Book.books.Find(b => b.Id == id);
                    b.Title = book.Title;
                    b.Autor = book.Autor;
                    return Ok(book);
                }

                else { return NotFound(); }
            }
            [HttpDelete("{id}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<IActionResult> DeleteBook([FromRoute] int id)
            {
                Book b = Book.books.Find(b => b.Id == id);
                if (b is null)
                {
                    return NotFound();
                }
                else
                {
                    Book.books.Remove(b);
                    return NoContent();
                }
                // GET: api/<MaterielController>
                [HttpGet]
                public IEnumerable<string> Get()
                {
                    return new string[] { "value1", "value2" };
                }

                // GET api/<MaterielController>/5
                [HttpGet("{id}")]
                public string Get(int id)
                {
                    return "value";
                }

                // POST api/<MaterielController>
                [HttpPost]
                public void Post([FromBody] string value)
                {
                }

                // PUT api/<MaterielController>/5
                [HttpPut("{id}")]
                public void Put(int id, [FromBody] string value)
                {
                }

                // DELETE api/<MaterielController>/5
                [HttpDelete("{id}")]
                public void Delete(int id)
                {
                }
            }
        }
