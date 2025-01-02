using Microsoft.EntityFrameworkCore;

namespace Projekt_ASPNET.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
