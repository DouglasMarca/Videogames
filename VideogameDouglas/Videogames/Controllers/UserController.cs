using Microsoft.AspNetCore.Mvc;
using Videogames.Context;
using Videogames.UserModel;

namespace Videogames.UserController
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
    
        private readonly ILogger<UserController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public UserController(
            ILogger<UserController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        //Create: Crear usuarios

        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] User user)
        {
            _aplicacionContexto.User.Add(user);
            _aplicacionContexto.SaveChanges();
            return Ok(user);
        }

        //READ: Obtener lista de usuarios
        
        [Route("")]
        [HttpGet]
        public IEnumerable<User> GetUser()
        {
            return _aplicacionContexto.User.ToList();
        }

        //Update: Modificar usuarios

        [Route("user")]
        [HttpPut]
        public IActionResult PutUser(
            [FromBody] User user)
        {
            _aplicacionContexto.User.Update(user);
            _aplicacionContexto.SaveChanges();
            return Ok(user);
        }

        //Delete: Eliminar usuarios

        [Route("user/{userId}")]
        [HttpDelete]
        public IActionResult DeleteUser(int userId)
        {
            _aplicacionContexto.User.Remove(
                _aplicacionContexto.User.ToList()
                .Where(x => x.IdUser == userId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges ();
            return Ok(userId);
        }
    }
}