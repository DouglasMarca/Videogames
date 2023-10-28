using Microsoft.AspNetCore.Mvc;
using Videogames.Context;
using Videogames.EmailModel;

namespace Videogames.EmailController
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
    
        private readonly ILogger<EmailController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmailController(
            ILogger<EmailController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear Email
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Email email)
        {
            _aplicacionContexto.Email.Add(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        //READ: Obtener lista de Emails
       
        [Route("")]
        [HttpGet]
        public IEnumerable<Email> GetEmail()
        {
            return _aplicacionContexto.Email.ToList();
        }
        //Update: Modificar emails
        [Route("email")]
        [HttpPut]
        public IActionResult PutEmail(
            [FromBody] Email email)
        {
            _aplicacionContexto.Email.Update(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        //Delete: Eliminar emails
        [Route("email/{emailId}")]
        [HttpDelete]
        public IActionResult DeleteEmail(int emailId)
        {
            _aplicacionContexto.Email.Remove(
                _aplicacionContexto.Email.ToList()
                .Where(x => x.IdEmail == emailId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges ();
            return Ok(emailId);
        }
    }
}