using examen.ContextModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using examen.Models;

namespace examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly AutorContext _autorContext;

        public AutorController(AutorContext autorContext)
        {
            this._autorContext = autorContext;
        }

        [HttpGet("Autori")]
        public async Task<IActionResult> GetAutori()
        {
            return Ok(await _autorContext.Autor.ToListAsync());
        }

        [HttpGet("Edituri")]
        public async Task<IActionResult> GetEdituri()
        {
            return Ok(await _autorContext.Editura.ToListAsync());
        }

        [HttpGet("Carti")]
        public async Task<IActionResult> GetCarti()
        {
            return Ok(await _autorContext.Carte.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAutor(int id)
        {
            var _autor = await _autorContext.Autor.Select(aut => new Autor()
            {
                Id = aut.Id,
                Nume = aut.Nume,
                EdituraId = aut.EdituraId
            }).SingleOrDefaultAsync(aut => aut.Id == id);
            if (_autor == null)
            {
                return NotFound();
            }
            return Ok(_autor);
        }

        [HttpPost]
        public async Task<ActionResult<Autor>> PostAutor(string Nume, int EdituraId)
        {
            var _autor = new Autor()
            {
                Nume = Nume,
                EdituraId = EdituraId
            };

            _autorContext.Autor.Add(_autor);
            _autorContext.SaveChanges();
            return Ok(_autor);
        }

        [HttpPost("AsignareAutori")]
        public async Task<IActionResult> PostCarte(int autorId, int carteId)
        {
            var _autor = _autorContext.Carte.FirstOrDefault(aut => aut.Id == autorId);
            if (_autor == null)
            {
                return NotFound();
            }
            var _carte = _autorContext.Carte.FirstOrDefault(car => car.Id == carteId);
            if (_carte == null)
            {
                return NotFound();
            }

            var _autoriCarti = new AutorCarte()
            {
                AutorId = autorId,
                CarteId = carteId
            };

            _autorContext.AutoriCarti.Add(_autoriCarti);
            _autorContext.SaveChanges();
            return Ok(_autoriCarti.Carte);
        }
    }
}
