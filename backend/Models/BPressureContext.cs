using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class BPressureContext : DbContext
    {
        public BPressureContext(DbContextOptions<BPressureContext> options) : base(options)
        {

        }
        public DbSet<BPressure> BPressures { get; set; }
    }
}