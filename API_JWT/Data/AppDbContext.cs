using API_JWT.Models;
using Microsoft.EntityFrameworkCore;

namespace API_JWT.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
