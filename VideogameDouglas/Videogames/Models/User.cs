using System.ComponentModel.DataAnnotations;

namespace Videogames.UserModel
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string Name { get; set; }
        public bool Genero { get; set; }
        public int Age { get; set; }
    }
}