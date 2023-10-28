using System.ComponentModel.DataAnnotations;

namespace Videogames.EmailModel
{
    public class Email
    {
        [Key]
        public int IdEmail { get; set; }
        public string email { get; set; }
        public int IdUser { get; set; }
    }
}