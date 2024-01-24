using Microsoft.EntityFrameworkCore;
using nesk_webapi.Models;

namespace nesk_webapi.AppDbContext
{
    public class neskDbContext:DbContext
    {
        public neskDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Roles> Roles { get; set; }
    }
}
