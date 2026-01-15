using Microsoft.EntityFrameworkCore;
using GameAdminPanel.Models;

namespace GameAdminPanel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {
        }

        public DbSet<Erou> Eroi { get; set; }
    }
}
