using API_Vacanza.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Vacanza.Context
{
    public class VaContext : DbContext
    {
        public VaContext(DbContextOptions<VaContext> options) : base(options) 
        {

        }

        public DbSet<Destinazione> Destinazioni { get; set; }
        public DbSet<Pacchetto> Pacchetti { get; set; }

        public DbSet<DestinazionePacchetto> DestPacchettos { get; set; }

        public DbSet<Recensione> Recensioni { get; set; }
    }
}
