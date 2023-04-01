using Microsoft.EntityFrameworkCore;
using SOSMulheres.Models;

namespace SosMulheres.Context
{
    public class SosMulheresContext : DbContext
    {
        public SosMulheresContext(DbContextOptions<SosMulheresContext> options) : base(options)
        {
        }

        public DbSet<Relatos> Relatos { get; set; }
        public DbSet<User> User { get; set; }
    }
}