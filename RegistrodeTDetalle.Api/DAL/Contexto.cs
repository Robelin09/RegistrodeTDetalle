using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace RegistrodeTDetalle.Api.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<DetallesTickets> DetallesTickets { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
