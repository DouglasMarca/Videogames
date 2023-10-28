using Microsoft.AspNetCore.Mvc;
using Videogames.Context;
using Videogames.VideogamesModel;

namespace Videogames.VideogamesController
{
    [ApiController]
    [Route("[controller]")]
    public class VideogameController : ControllerBase
    {
    
        private readonly ILogger<VideogameController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public VideogameController(
            ILogger<VideogameController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        //Create: Crear Videojuego

        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Videogame videogame)
        {
            _aplicacionContexto.Videogame.Add(videogame);
            _aplicacionContexto.SaveChanges();
            return Ok(videogame);
        }

        //READ: Obtener lista de Videojuegos
       
        [Route("")]
        [HttpGet]
        public IEnumerable<Videogame> GetVideogames()
        {
            return _aplicacionContexto.Videogame.ToList();
        }

        //Update: Modificar Videojuego

        [Route("videogame")]
        [HttpPut]
        public IActionResult PutVideogame(
            [FromBody] Videogame videogame)
        {
            _aplicacionContexto.Videogame.Update(videogame);
            _aplicacionContexto.SaveChanges();
            return Ok(videogame);
        }

        //Delete: Eliminar Videojuegos

        [Route("videogame/{videogameId}")]
        [HttpDelete]
        public IActionResult DeleteVideogame(int videogameId)
        {
            _aplicacionContexto.Videogame.Remove(
                _aplicacionContexto.Videogame.ToList()
                .Where(x => x.IdVideogame == videogameId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges ();
            return Ok(videogameId);
        }
    }
}