using System.ComponentModel.DataAnnotations;

namespace Videogames.VideogamesModel
{
    public class Videogame
    {
        [Key]
        public int IdVideogame { get; set; }
        public string Name { get; set; }
        public string PaymentType { get; set; }
        public bool Group { get; set; }
        public string Type { get; set; }
        public int IdUser { get; set; }
    }
}