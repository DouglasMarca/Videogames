using Microsoft.EntityFrameworkCore;
using Videogames.EmailModel;
using Videogames.UserModel;
using Videogames.VideogamesModel;

namespace Videogames.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Email> Email { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Videogame> Videogame { get; set; }
    }
}
